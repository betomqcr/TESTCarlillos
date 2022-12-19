Namespace Logica
    Public Class Empaquetado


        Private db As Datos.Class.Empaquetado

        Sub New()
            Me.db = New Datos.Class.Empaquetado
        End Sub

        Public Function Buscar(ByVal CodMarca As Integer) As List(Of Datos.Models.DetalleEmpaquetado)
            Return db.BuscarDetalleEmpaquetado(CodMarca)
        End Function

        Public Function Crear(empaquetar As Datos.Models.Empaquetado) As String
            Return db.Crear(empaquetar).ToString
        End Function

    End Class
End Namespace