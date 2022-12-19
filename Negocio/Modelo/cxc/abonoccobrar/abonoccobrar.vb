Namespace Modelo
    Public Class abonoccobrar
        Public Property Id_Recibo As Long
        Public Property Num_Recibo As Long
        Public Property Cod_Cliente As Long
        Public Property Nombre_Cliente As String
        Public Property Saldo_Cuenta As Decimal
        Public Property Monto As Decimal
        Public Property Saldo_Actual As Decimal
        Public Property Fecha As DateTime
        Public Property Observaciones As String
        Public Property Anula As Boolean
        Public Property Ced_Usuario As String
        Public Property Contabilizado As Boolean
        Public Property Asiento As Long
        Public Property Cod_Moneda As Integer
        Public Property Cheque As String
        Public Property Num_Caja As Integer
        Public Property banco As String
        Public Property Num_Apertura As Integer
        Public Property EstadoEnvio As String
    End Class
End Namespace

