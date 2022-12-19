Namespace Logica
    Public Class Bancos

        Private db As Datos.Class.Bancos

        Sub New()
            Me.db = New Datos.Class.Bancos
        End Sub

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.Banco)
            Return Me.db.Buscar(porNombre, Filtro)
        End Function

        Public Function Crear(banco As Datos.Models.Banco) As String
            Return Me.db.Crear(banco)
        End Function

        Public Function Editar(id As Integer, banco As Datos.Models.Banco) As String
            Dim res As String = Me.db.Editar(id, banco)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

        Public Function Eliminar(id As Integer) As String
            Dim res As String = Me.db.Borrar(id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

    End Class
End Namespace

