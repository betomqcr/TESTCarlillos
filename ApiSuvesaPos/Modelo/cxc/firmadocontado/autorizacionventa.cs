using System;

namespace Modelo
{
    public class autorizacionventa
    {
        public int Id { get; set; }
        public int Id_Factura { get; set; }
        public string Id_Cajero { get; set; }
        public string Id_Admin { get; set; }
        public string Cedula_Retira { get; set; }
        public string Nombre_Retira { get; set; }
        public bool Cancelada { get; set; }
        public DateTime FechaCancelacion { get; set; }
        public int IdApertura { get; set; }
        public int NumRecibo { get; set; }
        public string Telefono_Retira { get; set; }
        public bool Express { get; set; }
    }
}
