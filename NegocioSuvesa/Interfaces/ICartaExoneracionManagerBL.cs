using Datos.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioSuvesa.Interfaces
{
    public interface ICartaExoneracionManagerBL
    {
        Task<ResponseGeneric<Datos.DTOs.CartaExoneracionDTO>> addCartaExoneracionEntry(Datos.DTOs.CartaExoneracionDTO request);

        Task<ResponseGeneric<Datos.DTOs.CartaExoneracionDTO>> editCartaExoneracionEntry(Datos.DTOs.CartaExoneracionDTO request);

        Task<ResponseGeneric<Datos.DTOs.CartaExoneracionDTO>> disableCartaExoneracion(Datos.DTOs.BuscarCartaExoneracionDTO request);

        Task<ResponseGeneric<Datos.DTOs.CartaExoneracionDTO>> enableCartaExoneracion(Datos.DTOs.BuscarCartaExoneracionDTO request);

        Task<ResponseGeneric<Datos.DTOs.CartaExoneracionDTO>> getCartaExoneracionByCedula(Datos.DTOs.BuscarCartaExoneracionDTO request);
    }
}
