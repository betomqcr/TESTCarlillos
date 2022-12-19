Namespace Logica
    Public Class TipoExoneracion
        Private db As New DatosFE.Class.TiposExoneracion

        Public Function Obtener_TipoExoneracion() As List(Of DatosFE.Models.TipoExoneracion)
            Return db.ObtenerTiposExoneracion()
        End Function

    End Class
End Namespace