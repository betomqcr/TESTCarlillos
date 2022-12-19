Namespace Modelo
    Public Class ventas
        Public Property Id As Long
        Public Property Num_Factura As Decimal
        Public Property Tipo As String
        Public Property Cod_Cliente As Long
        Public Property Nombre_Cliente As String
        Public Property Orden As String
        Public Property Cedula_Usuario As String
        Public Property Pago_Comision As Boolean
        Public Property SubTotal As Decimal
        Public Property Descuento As Decimal
        Public Property Imp_Venta As Decimal
        Public Property Total As Decimal
        Public Property Fecha As Date
        Public Property Vence As Date
        Public Property Cod_Encargado_Compra As String
        Public Property Contabilizado As Boolean
        Public Property AsientoVenta As Long
        Public Property ContabilizadoCVenta As Boolean
        Public Property AsientoCosto As Long
        Public Property Anulado As Boolean
        Public Property PagoImpuesto As Integer
        Public Property FacturaCancelado As Boolean
        Public Property Num_Apertura As Long
        Public Property Entregado As Boolean
        Public Property Cod_Moneda As Integer
        Public Property Moneda_Nombre As String
        Public Property Direccion As String
        Public Property Telefono As String
        Public Property SubTotalGravada As Decimal
        Public Property SubTotalExento As Decimal
        Public Property Transporte As Decimal
        Public Property Tipo_Cambio As Decimal
        Public Property Observaciones As String
        Public Property Exonerar As Boolean
        Public Property Taller As Boolean
        Public Property Mascotas As Boolean
        Public Property Num_Caja As Long
        Public Property agente As Boolean
        Public Property cod_agente As Long
        Public Property apartado As Long
        Public Property EnviadoMH As Boolean
        Public Property Cedula As String
        Public Property ClaveMH As String
        Public Property EstadoMH As String
        Public Property TipoCedula As String
        Public Property ConsecutivoMH As String
        Public Property excluirCxC As Boolean
        Public Property Id_Adelanto As Integer
        Public Property Reenviar As Boolean
        Public Property NumeroReenvio As Integer
        Public Property ClaveReenvio As String
        Public Property ConsecutivoReenvio As String
        Public Property Archivada As Boolean
        Public Property UsuarioArchivo As String
        Public Property FechaArchivo As Date
        Public Property Frecuente As Boolean
        Public Property Id_FacturaRemplaza As Integer
        Public Property Renta As Boolean
        Public Property Etapa As Integer
        Public Property FechaEtapa As Date
        Public Property EnProcesoIncobrable As Boolean
        Public Property Ventas_Detalle As New List(Of Modelo.ventas_detalle)

    End Class
End Namespace
