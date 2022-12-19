using Datos.DTOs;
using Datos.Helpers;
using Datos.Interfaces;
using NegocioSuvesa.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioSuvesa.Class
{
    public class ArticulosRelacionadosManagerBL : IArticulosRelacionadosManagerBL
    {
        private readonly IArticulosRelacionadosManagerDA _articulosRelacionadosManagerDA;
        private IValidaciones _validaciones;

        public ArticulosRelacionadosManagerBL(
                IArticulosRelacionadosManagerDA articulosRelacionadosManagerDA,
                IValidaciones validaciones)
        {
            _articulosRelacionadosManagerDA = articulosRelacionadosManagerDA;
            _validaciones = validaciones;
        }

        public async Task<ResponseGeneric<IEnumerable<ArticulosRelacionadosDTO>>> addArticulosRelacionadosEntry(IEnumerable<ArticulosRelacionadosDTO> request)
        {
            List<ArticulosRelacionadosDTO> articulosrelacionados = new List<ArticulosRelacionadosDTO>();

            foreach (ArticulosRelacionadosDTO item in request)
            {
                // Validaciones Codigo Principal
                if (_validaciones.isEmpty(item.CodigoPrincipal.ToString()) || !_validaciones.isOnlyNumeric(item.CodigoPrincipal.ToString()))
                {
                    return new ResponseGeneric<IEnumerable<ArticulosRelacionadosDTO>> ("Error: Codigo Principal incorrecta");
                }

                // Validaciones Codigo
                if (_validaciones.isEmpty(item.Codigo.ToString()) || !_validaciones.isOnlyNumeric(item.Codigo.ToString()))
                {
                    return new ResponseGeneric<IEnumerable<ArticulosRelacionadosDTO>> ("Error: Codigo incorrecto");
                }

                // Validaciones CodArticulo
                if (_validaciones.isEmpty(item.CodArticulo) || !_validaciones.isOnlyNumeric(item.CodArticulo))
                {
                    return new ResponseGeneric<IEnumerable<ArticulosRelacionadosDTO>> ("Error: CodArticulo incorrecto");
                }

                // Validaciones Cantidad
                if (item.Cantidad == 0)
                {
                    return new ResponseGeneric<IEnumerable<ArticulosRelacionadosDTO>> ("Error: Cantidad incorrecta");
                }

                ResponseGeneric<ArticulosRelacionadosDTO> articulosRelacionados = await _articulosRelacionadosManagerDA.addArticulosRelacionadosEntry(item);

                if(articulosRelacionados.Responses.Id != 0)
                {
                    articulosrelacionados.Add(articulosRelacionados.Responses);
                } 
                else
                {
                    return new ResponseGeneric<IEnumerable<ArticulosRelacionadosDTO>>("Error: Al ingresar los articulos relacionados");
                }

            }

            return new ResponseGeneric < IEnumerable<ArticulosRelacionadosDTO>>(articulosrelacionados);
            
        }

        public async Task<ResponseGeneric<ArticulosRelacionadosDTO>> disableArticulosRelacionados(ArticulosRelacionadosDTO request)
        {
            // Validaciones Id
            if (request.Id == 0)
            {
                return new ResponseGeneric<ArticulosRelacionadosDTO>("Error: Id incorrecta");
            }

            return await _articulosRelacionadosManagerDA.disableArticulosRelacionados(request);
        }

        public async Task<ResponseGeneric<IEnumerable<ArticulosRelacionadosDTO>>> getArticulosRelacionadosByCodigoPrincipal(ArticulosRelacionadosDTO request)
        {
            // Validaciones CodigoPrincipal
            if (_validaciones.isEmpty(request.CodigoPrincipal.ToString()) || !_validaciones.isOnlyNumeric(request.CodigoPrincipal.ToString()))
            {
                return new ResponseGeneric<IEnumerable<ArticulosRelacionadosDTO>> ("Error: CodigoPrincipal incorrecta");
            }

            return await _articulosRelacionadosManagerDA.getArticulosRelacionadosByCodigoPrincipal(request);
        }
    }
}
