using Datos.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioSuvesa.Interfaces
{
    public interface IProveedoresManagerBL
    {
        Task<ResponseGeneric<IEnumerable<Datos.DTOs.ProveedoresFilterInventarioDTO>>> getProveedoresFilterInventarios();
    }
}
