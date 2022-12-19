Namespace Logica
    Public Class Modulos

        Public Function obtenerModulos() As List(Of Modelo.modulos)

            'Metodo que llena GridControlModulos con los datos necesarios estos son los modulo que pertenecen a Hotel o Pymes y que no estan 
            'asignados al perfil y que esta siendo seleccionado
            'Private Sub CambioPosicion(ByVal sender As System.Object, ByVal e As System.EventArgs)
            '    Try

            '        Dim Fx As cFunciones
            '        Dim X As Integer

            '        X = Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Current("Id_Perfil")
            '        If CON = 0 Then
            '            Me.SqlConnection1.ConnectionString = CadenaConexionSeguridad
            '            CON = 1
            '        End If
            '        Fx.Llenar_Tabla_Generico("SELECT Id_modulo, Modulo_Nombre_Interno, Modulo_Nombre,Software,Grupo FROM Modulos WHERE (NOT (Id_modulo IN  (SELECT Id_Modulo  FROM Perfil_x_Modulo  WHERE (Id_Perfil = " & X & ")  GROUP BY Id_Modulo)))AND (Software =" & strModulos & " OR software = 0 ) GROUP BY Grupo,Id_modulo,Modulo_Nombre_Interno,Modulo_Nombre,Software", Me.DataSetPerfilUsuario1.Modulos1, Me.SqlConnection1.ConnectionString)
            '    Catch ex As Exception
            '        MsgBox(ex.ToString)
            '    End Try
            'End Sub

        End Function




    End Class
End Namespace