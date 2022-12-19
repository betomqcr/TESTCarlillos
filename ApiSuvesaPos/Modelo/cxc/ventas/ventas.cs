using System;
using System.Collections.Generic;

namespace Modelo
{
    public class ventas
    {
        public long Id { get; set; }
        public decimal Num_Factura { get; set; }
        public string Tipo { get; set; }
        public long Cod_Cliente { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Orden { get; set; }
        public string Cedula_Usuario { get; set; }
        public bool Pago_Comision { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Imp_Venta { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Vence { get; set; }
        public string Cod_Encargado_Compra { get; set; }
        public bool Contabilizado { get; set; }
        public long AsientoVenta { get; set; }
        public bool ContabilizadoCVenta { get; set; }
        public long AsientoCosto { get; set; }
        public bool Anulado { get; set; }
        public int PagoImpuesto { get; set; }
        public bool FacturaCancelado { get; set; }
        public long Num_Apertura { get; set; }
        public bool Entregado { get; set; }
        public int Cod_Moneda { get; set; }
        public string Moneda_Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public decimal SubTotalGravada { get; set; }
        public decimal SubTotalExento { get; set; }
        public decimal Transporte { get; set; }
        public decimal Tipo_Cambio { get; set; }
        public string Observaciones { get; set; }
        public bool Exonerar { get; set; }
        public bool Taller { get; set; }
        public bool Mascotas { get; set; }
        public long Num_Caja { get; set; }
        public bool agente { get; set; }
        public long cod_agente { get; set; }
        public long apartado { get; set; }
        public bool EnviadoMH { get; set; }
        public string Cedula { get; set; }
        public string ClaveMH { get; set; }
        public string EstadoMH { get; set; }
        public string TipoCedula { get; set; }
        public string ConsecutivoMH { get; set; }
        public bool excluirCxC { get; set; }
        public int Id_Adelanto { get; set; }
        public bool Reenviar { get; set; }
        public int NumeroReenvio { get; set; }
        public string ClaveReenvio { get; set; }
        public string ConsecutivoReenvio { get; set; }
        public bool Archivada { get; set; }
        public string UsuarioArchivo { get; set; }
        public DateTime FechaArchivo { get; set; }
        public bool Frecuente { get; set; }
        public int Id_FacturaRemplaza { get; set; }
        public bool Renta { get; set; }
        public int Etapa { get; set; }
        public DateTime FechaEtapa { get; set; }
        public bool EnProcesoIncobrable { get; set; }
        public List<Modelo.ventas_detalle> Ventas_Detalle { get; set; } = new List<Modelo.ventas_detalle>();
    }
}
