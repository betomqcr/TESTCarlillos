﻿using Datos.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IPresentacionesManagerDA
    {
        ResponseGeneric<List<Models.Presentacione>> getPresentaciones();
    }
}
