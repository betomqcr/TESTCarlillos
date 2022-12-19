Namespace Logica
    Public Class Usuarios

        Private db As Datos.Class.Usuarios

        Sub New()
            Me.db = New Datos.Class.Usuarios
        End Sub

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.Usuario)
            Return Me.db.Buscar(porNombre, Filtro)
        End Function

        Public Function Crear(usuario As Datos.Models.Usuario) As Integer
            Return Me.db.Crear(usuario)
            '    Function Registra()
            '    Try

            '        Me.BindingContext(Me.DatasetUsuario1, "Usuarios").EndCurrentEdit()
            '        Me.AdapterUsuario.Update(Me.DatasetUsuario1.Usuarios)

            '        Me.BindingContext(Me.DatasetUsuario1, "Perfil_x_Usuario").EndCurrentEdit()
            '        Me.AdapterPerfilxUsuario.Update(Me.DatasetUsuario1.Perfil_x_Usuario)

            '        Me.BindingContext(Me.DatasetUsuario1, "Perfil").EndCurrentEdit()
            '        Me.AdapterPerfil.Update(Me.DatasetUsuario1.Perfil)

            '        Me.GridControl1.Refresh()
            '        Me.DatasetUsuario1.GetChanges()

            '        Activar_desactivar_Campos(False)

            '        DataNavigator1.Enabled = True

            '        'toolBar
            '        Me.ToolBarNuevo.Text = "Nuevo"
            '        Me.ToolBarNuevo.ImageIndex = 0
            '        Me.ToolBarBuscar.Text = "Editar"
            '        Me.ToolBarBuscar.ImageIndex = 9
            '        Me.ToolBarBuscar.Enabled = True
            '        Me.ToolBarNuevo.Enabled = True
            '        Me.ToolBarRegistrar.Enabled = False
            '        Me.ToolBarEliminar.Enabled = True

            '    Catch ex As SystemException
            '        Dim mesg As String = "Problemas al Registrar un Usuario." & vbCrLf &
            '                         "Intente Iniciar el formulario Otra vez, " & vbCrLf &
            '                         "si el problema persiste comuniquelo al 'Administrador del Sistema'" & vbCrLf &
            '                         "'" & ex.Message & "'"
            '        MsgBox(mesg, MsgBoxStyle.Critical, "Atención")
            '    End Try

            'End Function

        End Function

        Public Function Editar(id As Long, usuario As Datos.Models.Usuario) As String
            Dim res As String = Me.db.Editar(id, usuario)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
            '    Function Registra()
            '    Try

            '        Me.BindingContext(Me.DatasetUsuario1, "Usuarios").EndCurrentEdit()
            '        Me.AdapterUsuario.Update(Me.DatasetUsuario1.Usuarios)

            '        Me.BindingContext(Me.DatasetUsuario1, "Perfil_x_Usuario").EndCurrentEdit()
            '        Me.AdapterPerfilxUsuario.Update(Me.DatasetUsuario1.Perfil_x_Usuario)

            '        Me.BindingContext(Me.DatasetUsuario1, "Perfil").EndCurrentEdit()
            '        Me.AdapterPerfil.Update(Me.DatasetUsuario1.Perfil)

            '        Me.GridControl1.Refresh()
            '        Me.DatasetUsuario1.GetChanges()

            '        Activar_desactivar_Campos(False)

            '        DataNavigator1.Enabled = True

            '        'toolBar
            '        Me.ToolBarNuevo.Text = "Nuevo"
            '        Me.ToolBarNuevo.ImageIndex = 0
            '        Me.ToolBarBuscar.Text = "Editar"
            '        Me.ToolBarBuscar.ImageIndex = 9
            '        Me.ToolBarBuscar.Enabled = True
            '        Me.ToolBarNuevo.Enabled = True
            '        Me.ToolBarRegistrar.Enabled = False
            '        Me.ToolBarEliminar.Enabled = True

            '    Catch ex As SystemException
            '        Dim mesg As String = "Problemas al Registrar un Usuario." & vbCrLf &
            '                         "Intente Iniciar el formulario Otra vez, " & vbCrLf &
            '                         "si el problema persiste comuniquelo al 'Administrador del Sistema'" & vbCrLf &
            '                         "'" & ex.Message & "'"
            '        MsgBox(mesg, MsgBoxStyle.Critical, "Atención")
            '    End Try

            'End Function

        End Function

    End Class
End Namespace