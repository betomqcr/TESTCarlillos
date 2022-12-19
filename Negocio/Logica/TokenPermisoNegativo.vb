Namespace Logica
    Public Class TokenPermisoNegativo

        Private db As Datos.Class.TokenPermisoNegativo

        Sub New()
            Me.db = New Datos.Class.TokenPermisoNegativo
        End Sub

        Public Function ConsultarToken() As List(Of Datos.Models.ViewTokenSolicitado)
            Return Me.db.ListaTokenSolicitadosdelDia
        End Function


        Public Function SolicitarToken(idusuario As String, codigo As Decimal) As String
            Return Me.db.SolicitarTokenVentaNegativa(idusuario, codigo)
        End Function

        Public Function ValidarToken(idusuario As String, codigo As Decimal, token As String) As List(Of Datos.Models.ViewTokenSolicitado)
            Return Me.db.ConsultarToken(idusuario, codigo, token)
        End Function



    End Class
End Namespace