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
    public class BodegasManagerBL : IBodegasManagerBL
    {
        private readonly IBodegasManagerDA _bodegasManager;

        public BodegasManagerBL(IBodegasManagerDA bodegasManager)
        {
            _bodegasManager = bodegasManager;
        }

        public ResponseGeneric<List<Bodega>> getBodegas()
        {
            return _bodegasManager.getBodegas();
        }
    }
}
