Namespace Modelo
    Public Class ordencompra
        Public Property Orden As Integer
        Public Property Proveedor As Integer
        Public Property Nombre As String
        Public Property Fecha As Date
        Public Property contado As Boolean
        Public Property credito As Boolean
        Public Property diascredito As Decimal
        Public Property Plazo As Integer
        Public Property Descuento As Decimal
        Public Property Impuesto As Decimal
        Public Property Total As Decimal
        Public Property Observaciones As String
        Public Property Usuario As String
        Public Property NombreUsuario As String
        Public Property entregar As String
        Public Property Cod_Moneda As Integer
        Public Property SubTotalGravado As Decimal
        Public Property SubTotalExento As Decimal
        Public Property SubTotal As Decimal
        Public Property Anulado As Boolean
    End Class
End Namespace
