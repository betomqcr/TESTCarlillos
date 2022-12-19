Namespace Logica
    Public Class MensajeReceptor


        Private db As New DatosFE.Class.MensajeRecepcionHacienda

        Public Function Buscar(entreFechas As Boolean,
                                              porEstado As Boolean,
                                              estados As String,
                                              desde As Date,
                                              hasta As Date) As List(Of DatosFE.Models.MensajeReceptor)
            Return db.ObtenerMensajeReceptor(porEstado, estados, entreFechas, desde, hasta)
        End Function

        Public Function Crear(mensajereceptor As List(Of DatosFE.Models.MensajeReceptor)) As String
            'Transacction ?????
            Try
                For Each msg As DatosFE.Models.MensajeReceptor In mensajereceptor
                    db.CrearMensajeReceptor(msg)
                Next
                Return "1"
            Catch ex As Exception
                Return ex.Message
            End Try
        End Function


    End Class
End Namespace