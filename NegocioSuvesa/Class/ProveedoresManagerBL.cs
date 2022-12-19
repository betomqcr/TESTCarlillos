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
    public class ProveedoresManagerBL : IProveedoresManagerBL
    {
        private readonly IProveedoresManagerDA _proveedoresManager;
        private IValidaciones _validaciones;

        public ProveedoresManagerBL(IProveedoresManagerDA proveedoresManager, IValidaciones validaciones)
        {
            _proveedoresManager = proveedoresManager;
            _validaciones = validaciones;
        }
        
        public async Task<ResponseGeneric<IEnumerable<ProveedoresFilterInventarioDTO>>> getProveedoresFilterInventarios()
        {
            return await _proveedoresManager.getProveedoresFilterInventarios();
        }
    }
}
