Namespace Modelo
    Public Class familias
        Public Property Codigo As Integer
        Public Property Descripcion As String
        Public Property Observaciones As String
        Public Property CuentaGra As String
        Public Property DescripcionGra As String
        Public Property CuentaExe As String
        Public Property DescripcionExe As String
        Public Property CuentaCosto As String
        Public Property DescripcionCosto As String
        Public Property SubFamilias As List(Of subFamilias)
    End Class

End Namespace
