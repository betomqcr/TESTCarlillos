namespace Modelo
{
    public class bancos
    {
        public long Codigo_banco { get; set; }
        public string Descripcion { get; set; }
        public Modelo.cuentas_bancarias Cuentas_Bancarias { get; set; }
    }
}
