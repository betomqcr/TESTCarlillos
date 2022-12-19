namespace Modelo
{
    public class proveedores
    {
        public int CodigoProv { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public string Telefono_Cont { get; set; }
        public string Observaciones { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public decimal MontoCredito { get; set; }
        public int Plazo { get; set; }
        public bool CostoTotal { get; set; }
        public bool ImpIncluido { get; set; }
        public int PedidosMes { get; set; }
        public decimal Utilidad_Inventario { get; set; }
        public bool Utilidad_Fija { get; set; }
        public string CuentaContable { get; set; }
        public string DescripcionCuentaContable { get; set; }
        public bool Actualizado { get; set; }
        public bool Inhabilitado { get; set; }
        public bool FEC { get; set; }
        public string TipoProveedor { get; set; }
        public int Id_Provincia { get; set; }
        public int Id_Canton { get; set; }
        public int Id_Distrito { get; set; }
        public string OtrasSenas { get; set; }
        public string CodigoActividad { get; set; }
        public string CorreoElectronico { get; set; }
        public bool Serie { get; set; }
        public bool Bloqueado { get; set; }
        public cuentas_bancarias_proveedor Cuentas_Bancarias_Proveedor { get; set; }
    }
}

