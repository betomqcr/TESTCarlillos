using System;
using System.Collections.Generic;

#nullable disable

namespace DatosFE.Models
{
    public partial class Configuracione
    {
        public string Cedula { get; set; }
        public string Empresa { get; set; }
        public string Tel01 { get; set; }
        public string Tel02 { get; set; }
        public string Fax01 { get; set; }
        public string Fax02 { get; set; }
        public string Direccion { get; set; }
        public double ImpVenta { get; set; }
        public string Frase { get; set; }
        public int Cajeros { get; set; }
        public byte[] Logo { get; set; }
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
        public bool ImprimirEnFacturaPersonalizada { get; set; }
        public bool FormatoCheck { get; set; }
        public bool Contabilidad { get; set; }
        public bool CambiaPrecioCredito { get; set; }
        public bool Mascotas { get; set; }
        public long MascotasContado { get; set; }
        public long MascotasCredito { get; set; }
        public bool? Regalias { get; set; }
        public string Empresa1 { get; set; }
        public string Empresa2 { get; set; }
        public string Empresa3 { get; set; }
        public bool? EditarNombre { get; set; }
        public bool FacturaElectronica { get; set; }
        public bool SoloPve { get; set; }
        public bool ModoCaja { get; set; }
        public bool AplicaTemperatura { get; set; }
        public bool ImprimeContadoPve { get; set; }
        public bool TokenNegativo { get; set; }
        public int IdEmisor { get; set; }

        public virtual Emisor IdEmisorNavigation { get; set; }
    }
}
