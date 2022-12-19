Namespace Logica
    Public Class CondicionImpuesto

        Private db As New DatosFE.Class.CondicionImpuestos

        Public Function Buscar() As List(Of DatosFE.Models.CondicionImpuesto)
            Return db.ObtenerCondicionImpuestos()
        End Function

    End Class
End Namespace