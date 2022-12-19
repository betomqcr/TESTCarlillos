Namespace Modelo
    Public Class arqueocajas
        Public Property Id As Long
        Public Property EfectivoColones As Decimal
        Public Property EfectivoDolares As Decimal
        Public Property TarjetaColones As Decimal
        Public Property TarjetaDolares As Decimal
        Public Property Cheques As Decimal
        Public Property ChequesDol As Decimal
        Public Property DepositoCol As Decimal
        Public Property DepositoDol As Decimal
        Public Property Total As Decimal
        Public Property IdApertura As Integer
        Public Property Fecha As DateTime
        Public Property Cajero As String
        Public Property Anulado As Boolean
        Public Property TipoCambioD As Decimal
        Public Property Observaciones As String
        Public Property TarjetaSistema As Decimal
        Public Property OtrasTarjetas As Decimal
        Public Property ArqueoDeposito As New List(Of Modelo.arqueodeposito)
        Public Property ArqueoeEectivo As New List(Of Modelo.arqueoefectivo)
        Public Property ArqueoTarjeta As New List(Of Modelo.arqueotarjeta)
    End Class

    Public Class arqueodeposito
        Public Property Id As Integer
        Public Property IdArqueo As Integer
        Public Property Banco As String
        Public Property Cuenta As String
        Public Property Moneda As String
        Public Property Numero As String
        Public Property Monto As Decimal
        Public Property IdApertura As Integer
        Public Property Tipo As String
    End Class

    Public Class arqueoefectivo
        Public Property Id As Integer
        Public Property Id_Arqueo As Long
        Public Property Id_Denominacion As Long
        Public Property Monto As Decimal
        Public Property Cantidad As Integer
    End Class

    Public Class arqueotarjeta
        Public Property Id As Integer
        Public Property Id_Arqueo As Long
        Public Property Id_Tarjeta As Integer
        Public Property Monto As Decimal
    End Class
End Namespace