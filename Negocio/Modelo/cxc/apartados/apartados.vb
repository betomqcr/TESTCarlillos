Namespace Modelo
    Public Class apartados
        Public Property Id_Apartado As Long
        Public Property Id_Cliente As Long
        Public Property Nombrecliente As String
        Public Property Cedulausuario As String
        Public Property SubTotal As Decimal
        Public Property Imp_Venta As Decimal
        Public Property Total As Decimal
        Public Property Fecha As DateTime
        Public Property Vence As DateTime
        Public Property Anulado As Boolean
        Public Property Cancelado As Boolean
        Public Property SubTotalGravada As Decimal
        Public Property SubTotalExento As Decimal
        Public Property Observaciones As String
        Public Property Monto As Decimal
        Public Property Descuento As Decimal
        Public Property Tipo_Cambio As Decimal
        Public Property Cod_Moneda As Integer
        Public Property Apartado_Detalle As New List(Of Modelo.apartado_detalle)
    End Class

End Namespace
