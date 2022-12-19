using Datos.Helpers;
using Datos.Interfaces;
using Datos.Models;
using NegocioSuvesa.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioSuvesa.Class
{
    public class ImpuestosManagerBL : IImpuestoManagerBL
    {
        private readonly IImpuestosManagerDA _impuestosManager;

        public ImpuestosManagerBL(IImpuestosManagerDA impuestosManager)
        {
            _impuestosManager = impuestosManager;
        }

        public ResponseGeneric<List<Impuesto>> getImpuestos()
        {
            return _impuestosManager.getImpuestos();
        }
    }
}
