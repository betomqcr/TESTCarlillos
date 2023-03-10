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
    public class MonedasManagerBL : IMonedaManagerBL
    {
        private readonly IMonedasManagerDA _monedasManager;

        public MonedasManagerBL(IMonedasManagerDA monedaManager)
        {
            _monedasManager = monedaManager;
        }

        public ResponseGeneric<List<Moneda>> getMonedas()
        {
            return _monedasManager.getMonedas();
        }
    }
}
