using Datos.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IArticulosRelacionadosManagerDA
    {
        Task<ResponseGeneric<DTOs.ArticulosRelacionadosDTO>> addArticulosRelacionadosEntry(Datos.DTOs.ArticulosRelacionadosDTO request);

        Task<ResponseGeneric<DTOs.ArticulosRelacionadosDTO>> disableArticulosRelacionados(Datos.DTOs.ArticulosRelacionadosDTO request);

        Task<ResponseGeneric<IEnumerable<DTOs.ArticulosRelacionadosDTO>>> getArticulosRelacionadosByCodigoPrincipal(Datos.DTOs.ArticulosRelacionadosDTO request);
    }
}
