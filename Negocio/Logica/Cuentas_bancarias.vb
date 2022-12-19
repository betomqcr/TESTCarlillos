Namespace Logica
    Public Class Cuentas_bancarias
        Private db As Datos.Class.CuentasBancarias

        Sub New()
            Me.db = New Datos.Class.CuentasBancarias
        End Sub

        Public Function Buscar(porNombre As Boolean, filtro As String) As List(Of Datos.Models.CuentasBancaria)
            Return Me.db.Buscar(porNombre, filtro)
        End Function

        Public Function CuentasxCodigoBanco(Codigo As Long) As List(Of Datos.Models.CuentasBancaria)
            Return Me.db.CuentasxCodigoBanco(Codigo)
        End Function

        Public Function Crear(cuenta As Datos.Models.CuentasBancaria) As String
            Return Me.db.Crear(cuenta)
        End Function

        Public Function Editar(id As Integer, cuenta As Datos.Models.CuentasBancaria) As String
            Dim res As String = Me.db.Editar(id, cuenta)
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


