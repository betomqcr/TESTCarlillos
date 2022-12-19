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
    public class SubUbicacionesManagerBL : ISubUbicacionesManagerBL
    {
        private readonly ISubUbicacionesManagerDA _subUbicacionesManager;
        private IValidaciones _validaciones;

        public SubUbicacionesManagerBL(ISubUbicacionesManagerDA subUbicacionesManager, IValidaciones validaciones)
        {
            _subUbicacionesManager = subUbicacionesManager;
            _validaciones = validaciones;
        }

        public async Task<ResponseGeneric<IEnumerable<SubUbicacionesFilterInventarioDTO>>> getSubUbicacionesFilterInventarios()
        {
            return await _subUbicacionesManager.getSubUbicacionesFilterInventarios();
        }
    }
}
