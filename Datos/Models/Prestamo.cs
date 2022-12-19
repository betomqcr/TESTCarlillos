using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Prestamo
    {
        public Prestamo()
        {
            DetallePrestamos = new HashSet<DetallePrestamo>();
        }

        public long Id { get; set; }
        public DateTime Fecha { get; set; }
        public bool Estado { get; set; }
        public bool Anulado { get; set; }
        public bool Entrada { get; set; }
        public bool Salida { get; set; }
        public string Observacion { get; set; }
        public string NombreDestino { get; set; }
        public string Boleta { get; set; }
        public long Destinatario { get; set; }
        public string NombreDestinatario { get; set; }
        public long Destino { get; set; }
        public string Transportista { get; set; }
        public string IdUsuariCreo { get; set; }
        public string BoletaProveedor { get; set; }

        public virtual ICollection<DetallePrestamo> DetallePrestamos { get; set; }
    }
}
