using Datos.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioSuvesa.Interfaces
{
    public interface IArticulosRelacionadosManagerBL
    {
        Task<ResponseGeneric<IEnumerable<Datos.DTOs.ArticulosRelacionadosDTO>>> addArticulosRelacionadosEntry(IEnumerable<Datos.DTOs.ArticulosRelacionadosDTO> request);

        Task<ResponseGeneric<Datos.DTOs.ArticulosRelacionadosDTO>> disableArticulosRelacionados(Datos.DTOs.ArticulosRelacionadosDTO request);

        Task<ResponseGeneric<IEnumerable<Datos.DTOs.ArticulosRelacionadosDTO>>> getArticulosRelacionadosByCodigoPrincipal(Datos.DTOs.ArticulosRelacionadosDTO request);
    }
}
