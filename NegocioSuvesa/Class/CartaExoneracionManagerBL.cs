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
    public class CartaExoneracionManagerBL : ICartaExoneracionManagerBL
    {
        private readonly ICartaExoneracionManagerDA _cartaExoneracionManager;
        private readonly IClienteManagerBL _clienteManager;
        private IValidaciones _validaciones;

        public CartaExoneracionManagerBL(
                ICartaExoneracionManagerDA cartaExoneracionManager,
                IClienteManagerBL clienteManager,
                IValidaciones validaciones)
        {
            _cartaExoneracionManager = cartaExoneracionManager;
            _clienteManager = clienteManager;
            _validaciones = validaciones;
        }

        public async Task<ResponseGeneric<CartaExoneracionDTO>> addCartaExoneracionEntry(CartaExoneracionDTO request)
        {
            // Validaciones Cedula
            if (_validaciones.isEmpty(request.Cedula) || !_validaciones.isOnlyNumeric(request.Cedula))
            {
                return new ResponseGeneric<CartaExoneracionDTO>("Error: Cédula incorrecta");
            }

            // Validaciones Tipo Exoneracion
            if (request.IdTipoExoneracion == 0)
            {
                return new ResponseGeneric<CartaExoneracionDTO>("Error: Motivo Exoneracion incorrecto");
            }

            // Validaciones Numero Documento
            if (_validaciones.isEmpty(request.NumeroDocumento) || _validaciones.hasSpecialCharacters(request.NumeroDocumento))
            {
                return new ResponseGeneric<CartaExoneracionDTO>("Error: Número Documento incorrecto");
            }

            // Validaciones Fecha Emision
            if (_validaciones.isEmpty(request.FechaEmision.ToString()))
            {
                return new ResponseGeneric<CartaExoneracionDTO>("Error: Fecha Emision incorrecta");
            }

            // Validaciones Fecha Vence
            if (_validaciones.isEmpty(request.FechaVence.ToString()))
            {
                return new ResponseGeneric<CartaExoneracionDTO>("Error: Fecha Vence incorrecta");
            }

            // Validaciones Porcentaje Compra
            if (!(request.PorcentajeCompra >= 1 && request.PorcentajeCompra <= 100))
            {
                return new ResponseGeneric<CartaExoneracionDTO>("Error: Porcentaje Compra incorrecta");
            }

            // Validaciones Impuesto
            if (_validaciones.isEmpty(request.Impuesto.ToString()) || !(request.Impuesto >= 0 && request.Impuesto <= 13))
            {
                return new ResponseGeneric<CartaExoneracionDTO>("Error: Impuesto incorrecta");
            }

            ResponseGeneric<int> idCliente = await _clienteManager.getIDClient(request.Cedula);

            return await _cartaExoneracionManager.addCartaExoneracionEntry(request, idCliente.Responses);
        }

        public async Task<ResponseGeneric<CartaExoneracionDTO>> editCartaExoneracionEntry(CartaExoneracionDTO request)
        {
            // Validaciones Cedula
            if (_validaciones.isEmpty(request.Cedula) || !_validaciones.isOnlyNumeric(request.Cedula))
            {
                return new ResponseGeneric<CartaExoneracionDTO>("Error: Cédula incorrecta");
            }

            // Validaciones Tipo Exoneracion
            if (request.IdTipoExoneracion == 0)
            {
                return new ResponseGeneric<CartaExoneracionDTO>("Error: Motivo Exoneracion incorrecto");
            }

            // Validaciones Numero Documento
            if (_validaciones.isEmpty(request.NumeroDocumento) || _validaciones.hasSpecialCharacters(request.NumeroDocumento))
            {
                return new ResponseGeneric<CartaExoneracionDTO>("Error: Número Documento incorrecto");
            }

            // Validaciones Fecha Emision
            if (_validaciones.isEmpty(request.FechaEmision.ToString()))
            {
                return new ResponseGeneric<CartaExoneracionDTO>("Error: Fecha Emision incorrecta");
            }

            // Validaciones Fecha Vence
            if (_validaciones.isEmpty(request.FechaVence.ToString()))
            {
                return new ResponseGeneric<CartaExoneracionDTO>("Error: Fecha Vence incorrecta");
            }

            // Validaciones Porcentaje Compra
            if (!(request.PorcentajeCompra >= 1 && request.PorcentajeCompra <= 100))
            {
                return new ResponseGeneric<CartaExoneracionDTO>("Error: Porcentaje Compra incorrecta");
            }

            // Validaciones Impuesto
            if (_validaciones.isEmpty(request.Impuesto.ToString()) || !(request.Impuesto >= 0 && request.Impuesto <= 13))
            {
                return new ResponseGeneric<CartaExoneracionDTO>("Error: Impuesto incorrecta");
            }

            return await _cartaExoneracionManager.editCartaExoneracionEntry(request);
        }

        public async Task<ResponseGeneric<CartaExoneracionDTO>> getCartaExoneracionByCedula(BuscarCartaExoneracionDTO request)
        {
            // Validaciones Cedula
            if (_validaciones.isEmpty(request.Cedula) || !_validaciones.isOnlyNumeric(request.Cedula))
            {
                return new ResponseGeneric<CartaExoneracionDTO>("Error: Cédula incorrecta");
            }

            ResponseGeneric<int> idCliente = await _clienteManager.getIDClient(request.Cedula);

            ResponseGeneric<CartaExoneracionDTO> resp =  await _cartaExoneracionManager.getCartaExoneracionByCedula(idCliente.Responses);

            if(resp.Responses != null)
            {
                resp.Responses.Cedula = request.Cedula;
            }

            return resp;
        }

        public async Task<ResponseGeneric<CartaExoneracionDTO>> disableCartaExoneracion(BuscarCartaExoneracionDTO request)
        {
            // Validaciones Cedula
            if (_validaciones.isEmpty(request.Cedula) || !_validaciones.isOnlyNumeric(request.Cedula))
            {
                return new ResponseGeneric<CartaExoneracionDTO>("Error: Cédula incorrecta");
            }

            ResponseGeneric<int> idCliente = await _clienteManager.getIDClient(request.Cedula);

            return await _cartaExoneracionManager.disableCartaExoneracion(idCliente.Responses);
        }

        public async Task<ResponseGeneric<CartaExoneracionDTO>> enableCartaExoneracion(BuscarCartaExoneracionDTO request)
        {
            // Validaciones Cedula
            if (_validaciones.isEmpty(request.Cedula) || !_validaciones.isOnlyNumeric(request.Cedula))
            {
                return new ResponseGeneric<CartaExoneracionDTO>("Error: Cédula incorrecta");
            }

            ResponseGeneric<int> idCliente = await _clienteManager.getIDClient(request.Cedula);

            return await _cartaExoneracionManager.enableCartaExoneracion(idCliente.Responses);
        }

    }
}
