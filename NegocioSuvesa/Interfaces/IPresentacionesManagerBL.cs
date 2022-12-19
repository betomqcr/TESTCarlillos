using Datos.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioSuvesa.Interfaces
{
    public interface IPresentacionesManagerBL
    {
        ResponseGeneric<List<Datos.Models.Presentacione>> getPresentaciones();
    }
}
