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
    public class PresentacionesManagerBL : IPresentacionesManagerBL
    {
        private readonly IPresentacionesManagerDA _presentacionesManager;

        public PresentacionesManagerBL(IPresentacionesManagerDA presentacionesManager)
        {
            _presentacionesManager = presentacionesManager;
        }

        public ResponseGeneric<List<Presentacione>> getPresentaciones()
        {
            return _presentacionesManager.getPresentaciones();
        }
    }
}
