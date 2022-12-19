Namespace Modelo
    Public Class abonocpagar
        Public Property Id_Abonocpagar As Long
        Public Property Documento As Long
        Public Property TipoDocumento As String
        Public Property CuentaBancaria As String
        Public Property Codigo_banco As Long
        Public Property Saldo_Cuenta As Decimal
        Public Property Monto As Decimal
        Public Property Saldo_Actual As Decimal
        Public Property Fecha As DateTime
        Public Property Contabilizado As Boolean
        Public Property Recibo As String
        Public Property Cedula_Usuario As String
        Public Property Cod_Proveedor As Integer
        Public Property Anulado As Boolean
        Public Property cod_Moneda As Integer
        Public Property TipoCambio As Decimal
        Public Property MontoLetras As String
        Public Property CuentaDestino As Long
        Public Property FechaEntrada As DateTime
        Public Property Observaciones As String

    End Class
End Namespace

