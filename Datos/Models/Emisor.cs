using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Emisor
    {
        public Emisor()
        {
            Configuraciones = new HashSet<Configuracione>();
            EmpresaActividades = new HashSet<EmpresaActividade>();
            MensajeReceptors = new HashSet<MensajeReceptor>();
            Venta = new HashSet<Venta>();
        }

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

        public virtual TiposIdentificacion IdTipoIdentificacionNavigation { get; set; }
        public virtual ICollection<Configuracione> Configuraciones { get; set; }
        public virtual ICollection<EmpresaActividade> EmpresaActividades { get; set; }
        public virtual ICollection<MensajeReceptor> MensajeReceptors { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
