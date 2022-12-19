Namespace Logica
    Public Class Ubicacion
        Private db As New DatosFE.Class.Ubicaciones

        Public Function Obtener_Provincia() As List(Of DatosFE.Models.Provincia)
            Return db.ObtenerProvincia
        End Function

        Public Function Obtener_Canton(provincia As Decimal) As List(Of DatosFE.Models.Canton)
            Return db.ObtenerCanton(provincia)
        End Function

        Public Function Obtener_Distrito(provincia As Decimal, canton As Decimal) As List(Of DatosFE.Models.Distrito)
            Return db.ObtenerDistrito(canton, provincia)
        End Function

    End Class
End Namespace