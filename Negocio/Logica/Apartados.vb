Namespace Logica
    Public Class Apartados


        Private db As Datos.Class.Apartados

        Sub New()
            Me.db = New Datos.Class.Apartados
        End Sub

        Public Function cargarApartadosPendientes(porNombre As Boolean, filtro As String) As List(Of Datos.Models.ViewApartadosActivo)
            Return Me.db.Buscar(porNombre, filtro)
        End Function

    End Class
End Namespace