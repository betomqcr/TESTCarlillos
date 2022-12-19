Namespace Modelo
    Public Class autorizacionventa
        Public Property Id As Integer
        Public Property Id_Factura As Integer
        Public Property Id_Cajero As String
        Public Property Id_Admin As String
        Public Property Cedula_Retira As String
        Public Property Nombre_Retira As String
        Public Property Cancelada As Boolean
        Public Property FechaCancelacion As Date
        Public Property IdApertura As Integer
        Public Property NumRecibo As Integer
        Public Property Telefono_Retira As String
        Public Property Express As Boolean
    End Class
End Namespace