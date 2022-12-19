Namespace Modelo
    Public Class prestamo
        Public Property ID As Integer
        Public Property fecha As DateTime
        Public Property estado As Boolean
        Public Property anulado As Boolean
        Public Property Entrada As Boolean
        Public Property Salida As Boolean
        Public Property observacion As String
        Public Property nombre_destino As String
        Public Property boleta As String
        Public Property destinatario As Integer
        Public Property nombre_destinatario As String
        Public Property destino As Integer
        Public Property transportista As String
        Public Property Id_UsuariCreo As String
        Public Property BoletaProveedor As String
        Public Property Detalle_Prestamo As New List(Of detalle_prestamo)
    End Class
End Namespace