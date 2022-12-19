using Datos.Helpers;
using Datos.Interfaces;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Class
{
    public class MarcaManagerDA : IMarcaManagerDA
    {
        private readonly SeePOSContext _entities;

        public MarcaManagerDA()
        {
            _entities = new SeePOSContext();
        }

        public ResponseGeneric<List<Marca>> getMarca()
        {
            try
            {
                List<Marca> temp = _entities.Marcas.ToList().FindAll(marca => marca.Estado == true);

                return new ResponseGeneric<List<Models.Marca>>(temp);
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<Models.Marca>>(ex);
            }
        }
    }
}
