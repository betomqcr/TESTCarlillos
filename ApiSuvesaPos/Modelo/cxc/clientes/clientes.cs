namespace Modelo
{
    public class clientes
    {
        public long identificacion { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string observaciones { get; set; }
        public string Telefono_01 { get; set; }
        public string telefono_02 { get; set; }
        public string fax_01 { get; set; }
        public string fax_02 { get; set; }
        public string e_mail { get; set; }
        public char abierto { get; set; }
        public string direccion { get; set; }
        public decimal impuesto { get; set; }
        public decimal max_credito { get; set; }
        public int Plazo_credito { get; set; }
        public decimal descuento { get; set; }
        public char empresa { get; set; }
        public int tipoprecio { get; set; }
        public char sinrestriccion { get; set; }
        public string usuario { get; set; }
        public string nombreusuario { get; set; }
        public string agente { get; set; }
        public int CodMonedaCredito { get; set; }
        public bool Cliente_Moroso { get; set; }
        public bool PrecioSugerido { get; set; }
        public bool Anulado { get; set; }
        public bool notificar { get; set; }
        public string tipo_cedula { get; set; }
        public bool OrdenCompra { get; set; }
        public int IdTipoExoneracion { get; set; }
        public string TipoCliente { get; set; }
        public string CorreoComprobante { get; set; }
        public bool Actualizado { get; set; }
        public decimal DescuentoEspecial { get; set; }
        public bool Relacionados { get; set; }
        public bool MAG { get; set; }
        public bool EnviarRecibo { get; set; }
        public string CorreoRecibo { get; set; }
        public bool Fallecido { get; set; }
        public bool Usointerno { get; set; }
    }
}
