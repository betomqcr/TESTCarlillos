Namespace Logica
    Public Class Cajas_Cantidad

        Private db As Datos.Class.CajasCantidad

        Sub New()
            Me.db = New Datos.Class.CajasCantidad
        End Sub

        Public Function Buscar() As List(Of Datos.Models.CajasCantidad)
            Return Me.db.ObtenerCajasCantidad
            'Me.AdapterNumCaja.Fill(Me.DataSetAperturaCaja1.Cajas_Cantidad)

        End Function

    End Class
End Namespace