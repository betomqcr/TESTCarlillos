namespace Modelo
{
    public class movimientosbodega_detalle
    {
        public int Id_Detalle { get; set; }
        public long Boleta_Movimiento { get; set; }
        public string Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public bool Tipo_Entrada { get; set; }
        public bool Tipo_Salida { get; set; }
        public string Numero { get; set; }
        public decimal ExistenciaForzada { get; set; }
        public decimal ExistVeteForzada { get; set; }
        //public List<serie> Serie { get; set; } = new List<serie>(); // las series que salen o que entran
    }
}

