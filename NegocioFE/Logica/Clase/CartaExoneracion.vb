Namespace Logica

    Public Class CartaExoneracion

        Public db As New DatosFE.Class.CartasExoneraciones
        'Public tipo As New DatosFE.Class.IdentificacionTipos

        Public Function Crear(cartaexoneracion As DatosFE.Models.CartaExoneracion) As String
            Return Me.db.CrearCartaExoneracion(cartaexoneracion).ToString
        End Function

        Public Function Editar(id As Decimal, cartaexoneracion As DatosFE.Models.CartaExoneracion) As String 'te modifique el metodo de editar
            If Me.db.EditarCarta(id, cartaexoneracion) = 1 Then
                Return "1"
            Else
                Return "No existe el valor"
            End If
        End Function

        Public Function Eliminar(ByRef id As Integer) As String
            Return db.BorrarCartaExoneracion(id).ToString
        End Function

        Public Function ObtenerCartaExoneracion(Identificacion As Long) As List(Of DatosFE.Models.CartaExoneracion)
            Return db.ObtenerCartaExoneracion(Identificacion)
        End Function

        'Public Function ConsultarIdTipoIdentificacion(des As String) As Integer
        '    Return tipo.ObtenerIdTipoIdentificacion(des)
        'End Function

    End Class
End Namespace