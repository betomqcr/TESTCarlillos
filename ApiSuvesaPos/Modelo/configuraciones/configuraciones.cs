namespace Modelo
{
    public class configuraciones
    {
        public string Cedula { get; set; }
        public string Empresa { get; set; }
        public string Tel_01 { get; set; }
        public string Tel_02 { get; set; }
        public string Fax_01 { get; set; }
        public string Fax_02 { get; set; }
        public string Direccion { get; set; }
        public decimal Imp_Venta { get; set; }
        public string Frase { get; set; }
        public int Cajeros { get; set; }
        public string Logo { get; set; } // image
        public int Intereses { get; set; }
        public bool UnicoConsecutivo { get; set; }
        public long NumeroConsecutivo { get; set; }
        public bool ConsContado { get; set; }
        public long NumeroContado { get; set; }
        public bool ConsCredito { get; set; }
        public long NumeroCredito { get; set; }
        public bool ConsPuntoVenta { get; set; }
        public long NumeroPuntoVenta { get; set; }
        public bool Taller { get; set; }
        public long TallerContado { get; set; }
        public long TallerCredito { get; set; }
        public bool Imprimir_en_Factura_Personalizada { get; set; }
        public bool FormatoCheck { get; set; }
        public bool Contabilidad { get; set; }
        public bool CambiaPrecioCredito { get; set; }
        public bool Mascotas { get; set; }
        public long MascotasContado { get; set; }
        public long MascotasCredito { get; set; }
        public bool regalias { get; set; }
        public string empresa1 { get; set; }
        public string empresa2 { get; set; }
        public string empresa3 { get; set; }
        public bool editar_nombre { get; set; }
        public bool FacturaElectronica { get; set; }
        public bool SoloPVE { get; set; }
        public bool ModoCaja { get; set; }
        public bool AplicaTemperatura { get; set; }
        public bool ImprimeContadoPVE { get; set; }
        public bool TokenNegativo { get; set; }
    }
}
