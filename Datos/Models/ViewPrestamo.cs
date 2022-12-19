using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ViewPrestamo
    {
        public long Destino { get; set; }
        public long Destinatario { get; set; }
        public string Boleta { get; set; }
        public string BoletaProveedor { get; set; }
        public long Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public double Entra { get; set; }
        public double Salida { get; set; }
        public double Devuelto { get; set; }
        public string NombreDestinatario { get; set; }
        public string NombreDestino { get; set; }
        public DateTime Fecha { get; set; }
        public double Precio { get; set; }
    }
}
