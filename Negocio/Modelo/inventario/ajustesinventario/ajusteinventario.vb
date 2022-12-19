Namespace Modelo
    Public Class ajusteinventario
        Public Property Consecutivo As Long
        Public Property Fecha As DateTime
        Public Property Anula As Boolean
        Public Property Cedula As String
        Public Property TotalEntrada As Decimal
        Public Property TotalSalida As Decimal
        Public Property SaldoAjuste As Decimal
        Public Property Asiento As Decimal
        Public Property Contabilizado As Boolean
        Public Property AjusteInventario_Detalle As New List(Of ajusteinventario_detalle)
    End Class

End Namespace
