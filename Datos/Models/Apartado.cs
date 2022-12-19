using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Apartado
    {
        public Apartado()
        {
            AbonoApartadosdetalles = new HashSet<AbonoApartadosdetalle>();
            ApartadoDetalles = new HashSet<ApartadoDetalle>();
        }

        public long IdApartado { get; set; }
        public long IdCliente { get; set; }
        public string Nombrecliente { get; set; }
        public string Cedulausuario { get; set; }
        public double SubTotal { get; set; }
        public double ImpVenta { get; set; }
        public double Total { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Vence { get; set; }
        public bool Anulado { get; set; }
        public bool Cancelado { get; set; }
        public double SubTotalGravada { get; set; }
        public double SubTotalExento { get; set; }
        public string Observaciones { get; set; }
        public double Monto { get; set; }
        public double Descuento { get; set; }
        public double TipoCambio { get; set; }
        public int CodMoneda { get; set; }
        public int IdSucursal { get; set; }

        public virtual ICollection<AbonoApartadosdetalle> AbonoApartadosdetalles { get; set; }
        public virtual ICollection<ApartadoDetalle> ApartadoDetalles { get; set; }
    }
}
