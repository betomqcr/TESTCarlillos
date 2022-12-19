Namespace Modelo
    Public Class devoluciones_compras
        Public Property Devolucion As Long
        Public Property Id_Factura_Compra As Long
        Public Property SaldoAnt_Fact As Decimal
        Public Property SubTotalGravado As Decimal
        Public Property SubTotalExcento As Decimal
        Public Property Descuento As Decimal
        Public Property Impuesto As Decimal
        Public Property Monto As Decimal
        Public Property Fecha As DateTime
        Public Property Contabilizado As Boolean
        Public Property Asiento As Decimal
        Public Property Anulado As Boolean
        Public Property Cedula_Usuario As String
        Public Property Cod_Moneda As Integer
        Public Property NombrePro As String
        Public Property ContaInventario As Boolean
        Public Property AsientoInventario As Decimal
        Public Property FechaEntrada As DateTime

    End Class
End Namespace

