Namespace Logica
    Public Class Bodega
        Private db As Datos.Class.Bodegas

        Sub New()
            Me.db = New Datos.Class.Bodegas
        End Sub

        Public Function Buscar(porNombre As Boolean, filtro As String) As List(Of Datos.Models.Bodega)
            Return Me.db.Buscar(porNombre, filtro)
        End Function

        Public Function cargarInventario() As List(Of Datos.Models.Inventario)
            Dim inventario As New List(Of Datos.Models.Inventario)
            ' If X <> 0 Then Me.SqlDataAdapterInventario.Fill(Me.DataSetBodegas, "Inventario")
            Return inventario
        End Function

        Public Function Crear(bodega As Datos.Models.Bodega) As String
            Return Me.db.Crear(bodega)
        End Function

        Public Function Editar(id As Integer, bodega As Datos.Models.Bodega) As String
            Return Me.db.Editar(id, bodega)
        End Function

        Public Function Eliminar(id As Integer) As String
            Return Me.db.Borrar(id)
        End Function


    End Class
End Namespace

