Namespace Modelo
    Public Class agente_ventas
        Public Property id As Integer
        Public Property cedula As String
        Public Property nombre As String
        Public Property telefono As String
        Public Property direccion As String
        Public Property correo As String
        Public Property activo As Boolean
        Public Property anulado As Boolean
        Public Property TipoPrecio As Integer
        Public Property PrecioDiferenciado As List(Of Modelo.preciodiferenciado)
    End Class
End Namespace