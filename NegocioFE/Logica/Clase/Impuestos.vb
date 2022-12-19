Namespace Logica
    Public Class Impuestos

        Private db As New DatosFE.Class.Impuestos

        Public Function Buscar() As List(Of DatosFE.Models.Impuesto)
            Return Me.db.ObtenerImpuestos()
        End Function

    End Class
End Namespace