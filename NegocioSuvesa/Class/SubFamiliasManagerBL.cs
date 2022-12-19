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
    public class SubFamiliasManagerBL : ISubFamiliasManagerBL
    {
        private readonly ISubFamiliasManagerDA _subFamiliasManager;
        private IValidaciones _validaciones;

        public SubFamiliasManagerBL(ISubFamiliasManagerDA subFamiliasManager, IValidaciones validaciones)
        {
            _subFamiliasManager = subFamiliasManager;
            _validaciones = validaciones;
        }

        public async Task<ResponseGeneric<IEnumerable<SubFamiliasFilterInventarioDTO>>> getSubFamiliasFilterInventarios()
        {
            return await _subFamiliasManager.getSubFamiliasFilterInventarios();
        }
    }
}
