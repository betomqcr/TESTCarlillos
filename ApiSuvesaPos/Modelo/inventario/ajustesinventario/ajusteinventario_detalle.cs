namespace Modelo
{
    public class ajusteinventario_detalle
    {
        public long Consecutivo { get; set; }
        public long Cons_Ajuste { get; set; }
        public long Cod_Articulo { get; set; }
        public string CodArticulo { get; set; }
        public string Desc_Articulo { get; set; }
        public decimal Cantidad { get; set; }
        public bool Entrada { get; set; }
        public bool Salida { get; set; }
        public string observacion { get; set; }
        public string cuenta_contable { get; set; }
        public decimal TotalEntrada { get; set; }
        public decimal TotalSalida { get; set; }
        public decimal Existencia { get; set; }
        public decimal CostoUnit { get; set; }
        public string CUENTACONTABLE { get; set; }
        public string DESCRIPCIONCUENTACONTABLE { get; set; }
        public string Numero { get; set; }
        public long gasto { get; set; }
        public bool muerte { get; set; }
        public bool Actualizado { get; set; }
    }
}

