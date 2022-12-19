using System;
using System.Collections.Generic;

#nullable disable

namespace APIFacturacionElectronica.Models
{
    public partial class Emisores
    {
        public string TipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Sucursal { get; set; }
        public decimal Provincia { get; set; }
        public decimal Canton { get; set; }
        public decimal Distrito { get; set; }
        public string OtrasSeñas { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string Certificado { get; set; }
        public string NumeroResolucion { get; set; }
        public string FechaResolucion { get; set; }
        public int? IdTipoIdentificacion { get; set; }
        public int Id { get; set; }
        public DateTime? VenceCertificado { get; set; }

    }
}
