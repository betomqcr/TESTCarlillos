using Datos.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioSuvesa.Interfaces
{
    public interface IBodegasManagerBL
    {
        ResponseGeneric<List<Datos.Models.Bodega>> getBodegas();
    }
}
