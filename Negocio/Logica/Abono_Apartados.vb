Namespace Logica
    Public Class Abono_Apartados


        Private db As Datos.Class.AbonosApartados

        Sub New()
            Me.db = New Datos.Class.AbonosApartados
        End Sub

        Public Function cargarAbonosApartados(IdApartado As Long) As List(Of Datos.Models.AbonoApartadosdetalle)
            Return Me.db.AbonosporApartado(IdApartado)
        End Function

        Public Function Crear(Abono As Datos.Models.AbonoApartado) As String
            Return Me.db.CrearAbonoApartado(Abono)
        End Function

    End Class
End Namespace