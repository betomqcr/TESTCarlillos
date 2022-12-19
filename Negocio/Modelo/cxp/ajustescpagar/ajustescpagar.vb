Namespace Modelo
    Public Class ajustescpagar
        Public Property ID_Ajuste As Long
        Public Property AjusteNo As Long
        Public Property Tipo As Char
        Public Property Cod_Proveedor As Integer
        Public Property Nombre_Proveedor As String
        Public Property Fecha As DateTime
        Public Property Saldo_Prev As Decimal
        Public Property Monto As Decimal
        Public Property Saldo_Act As Decimal
        Public Property Observaciones As String
        Public Property Anula As Boolean
        Public Property Cod_Usuario As String
        Public Property Contabilizado As Boolean
        Public Property Cod_Moneda As Integer
        Public Property Asiento As Long
        Public Property FechaEntrada As DateTime

    End Class
End Namespace

