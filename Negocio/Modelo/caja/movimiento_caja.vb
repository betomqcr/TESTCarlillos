Namespace Modelo
    Public Class movimiento_caja
        Public Property Id As Integer
        Public Property Entrada As Boolean
        Public Property Salida As Boolean
        Public Property Monto As Decimal
        Public Property CodMoneda As Integer
        Public Property Usuario As String
        Public Property Fecha As Date
        Public Property Observaciones As String
        Public Property Anulado As Boolean
        Public Property NumApertura As Integer
        Public Property TipoCambio As Decimal
    End Class
End Namespace