using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class VistaPrestamosInventario
    {
        public long Id { get; set; }
        public string Boleta { get; set; }
        public long Destino { get; set; }
        public long Destinatario { get; set; }
        public long Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public bool Entregado { get; set; }
        public double Devuelto { get; set; }
        public bool Entrada { get; set; }
        public bool Salida { get; set; }
        public bool Anulado { get; set; }
        public double Cantidad { get; set; }
        public string NombreDestinatario { get; set; }
        public string NombreDestino { get; set; }
        public string BoletaProveedor { get; set; }
        public DateTime Fecha { get; set; }
        public double Precio { get; set; }
    }
}
