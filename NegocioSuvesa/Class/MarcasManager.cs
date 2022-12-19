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
    public class MarcasManager : IMarcaManagerBL
    {
        private readonly IMarcaManagerDA _marcaManager;

        public MarcasManager(IMarcaManagerDA marcaManager)
        {
            _marcaManager = marcaManager;
        }

        public ResponseGeneric<List<Marca>> getMarcas()
        {
            return _marcaManager.getMarca();
        }
    }
}
