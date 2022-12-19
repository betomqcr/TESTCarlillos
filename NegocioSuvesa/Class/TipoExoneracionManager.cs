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
    public class TipoExoneracionManager : ITipoExoneracionBL
    {
        private readonly ITipoExoneracionManagerDA _tipoExoneracionManager;

        public TipoExoneracionManager(ITipoExoneracionManagerDA tipoExoneracionManager)
        {
            _tipoExoneracionManager = tipoExoneracionManager;
        }

        public ResponseGeneric<List<TipoExoneracion>> getTipoExoneracion()
        {
            return _tipoExoneracionManager.getTipoExoneracion();
        }
    }
}
