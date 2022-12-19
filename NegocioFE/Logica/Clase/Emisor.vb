Namespace Logica
    Public Class Emisor
        Private db As New DatosFE.Class.Emisores

        Public Function Crear(Emisor As DatosFE.Models.Emisor) As String
            Return db.CrearEmisores(Emisor)
        End Function

        Public Function Modificar(Id As Integer, Emisor As DatosFE.Models.Emisor) As String
            Return db.EditarEmisores(Id, Emisor)
        End Function

        Public Function Obtener(Id As Integer) As DatosFE.Models.Emisor
            Return Me.db.ObtenerEmisores(Id)
        End Function

    End Class
End Namespace

