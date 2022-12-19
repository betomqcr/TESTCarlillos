Namespace Modelo
    Public Class devoluciones_ventas
        Public Property Devolucion As Long
        Public Property Id_Factura As Long
        Public Property SaldoAnt_Fact As Decimal
        Public Property SubTotalGravado As Decimal
        Public Property SubTotalExcento As Decimal
        Public Property Descuento As Decimal
        Public Property Impuesto As Decimal
        Public Property Monto As Decimal
        Public Property Fecha As DateTime
        Public Property Contabilizado As Boolean
        Public Property NumeroAsiento As Long
        Public Property Anulado As Boolean
        Public Property Cedula_Usuario As String
        Public Property Cod_Moneda As Integer
        Public Property Transporte As Decimal
        Public Property ContabilizadoCosto As Boolean
        Public Property NumeroAsientoCosto As Long
        Public Property caja As Integer
        Public Property CONSECUTIVO As Long
        Public Property ENVIADODGT As Boolean
        Public Property ESTADODGT As String
        Public Property CONSECUTIVODGT As String
        Public Property CLAVEDGT As String
        Public Property MontoDevolucion As Decimal
        Public Property Num_Apertura As Integer
        Public Property UsuarioRecibio As String
        Public Property NotasDevolucion As String
        Public Property Articulos_Ventas_Devueltos As New Modelo.articulos_ventas_devueltos

    End Class
End Namespace

