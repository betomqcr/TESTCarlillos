Namespace Modelo
    Public Class cierrecaja
        Public Property NumeroCierre As Integer
        Public Property Cajera As String
        Public Property Nombre As String
        Public Property Apertura As Integer
        Public Property Usuario As String
        Public Property Fecha As DateTime
        Public Property NombreUsuario As String
        Public Property Anulado As Boolean
        Public Property Devoluciones As Decimal
        Public Property Subtotal As Decimal
        Public Property TotalSistema As Decimal
        Public Property Equivalencia As Decimal
        Public Property EfectivoColones As Decimal
        Public Property EfectivoDolares As Decimal
        Public Property TarjetaColones As Decimal
        Public Property TarjetaDolares As Decimal
        Public Property Cheques As Decimal
        Public Property ChequeDol As Decimal
        Public Property DepositosCol As Decimal
        Public Property DepositosDol As Decimal
        Public Property CierreCaja_DetMon As New List(Of Modelo.cierrecaja_detmon)
        Public Property CierreCaja_DetTarj As New List(Of Modelo.cierrecaja_dettarj)
    End Class

    Public Class cierrecaja_detmon
        Public Property Id_DetaMoneda As Integer
        Public Property Id_CierreCaja As Integer
        Public Property Id_Moneda As Integer
        Public Property MontoSistema As Decimal
        Public Property MontoCajero As Decimal
    End Class

    Public Class cierrecaja_dettarj
        Public Property Id_DetalleTarjeta As Integer
        Public Property Id_CierreCaja As Integer
        Public Property Id_TipoTarjeta As Integer
        Public Property MontoSistema As Decimal
        Public Property MontoCajero As Decimal
    End Class

End Namespace