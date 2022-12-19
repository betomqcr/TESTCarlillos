using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class AbonoApartadosdetalle
    {
        public long IdDetalleabono { get; set; }
        public long Apartado { get; set; }
        public long IdAbonoapartado { get; set; }
        public double Monto { get; set; }
        public double SaldoAnt { get; set; }
        public double Intereses { get; set; }
        public double Abono { get; set; }
        public double AbonoSuMoneda { get; set; }
        public double Saldo { get; set; }

        public virtual Apartado ApartadoNavigation { get; set; }
        public virtual AbonoApartado IdAbonoapartadoNavigation { get; set; }
    }
}
