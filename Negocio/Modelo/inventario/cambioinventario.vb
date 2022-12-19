Namespace Modelo
    Public Class cambioinventario
        Public Property Id As Integer
        Public Property IdUsuario As String
        Public Property Fecha As DateTime
        Public Property CodigoFacturado As Integer
        Public Property CantidadFacturado As Decimal
        Public Property CodigoEntregado As Integer
        Public Property CantidadEntregado As Decimal
        Public Property Diferencia As Decimal
        Public Property Aplicado As Boolean
    End Class
End Namespace