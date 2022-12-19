Namespace Logica
    Public Class Configuraciones


        Public Function Buscar() As List(Of Modelo.configuraciones)
            'DaConfiguracion.Fill(Me.DsConfiguracion.configuraciones)
        End Function

        Public Sub Editar(configuraciones As Modelo.configuraciones)

            'Private Sub registrar()

            '    'SaveSetting("SeeSOFT", "SeePOs", "clave", Me.txtclave.Text)

            '    If Me.SqlConnection.State <> Me.SqlConnection.State.Open Then Me.SqlConnection.Open()
            '    Dim Trans As SqlTransaction = Me.SqlConnection.BeginTransaction
            '    Try
            '        Me.BindingContext(Me.DsConfiguracion, "Configuraciones").EndCurrentEdit()
            '        'Me.BindingContext(Me.DsConfiguracion, "correo").EndCurrentEdit()
            '        Me.BindingContext(Me.DsConfiguracion, "permisos").EndCurrentEdit()

            '        Me.SqlInsertCommand1.Transaction = Trans
            '        Me.SqlUpdateCommand1.Transaction = Trans
            '        'Me.SqlInsertCommand3.Transaction = Trans
            '        'Me.SqlUpdateCommand3.Transaction = Trans

            '        Me.adpermiso.Update(Me.DsConfiguracion.permisos)
            '        Me.DaConfiguracion.Update(Me.DsConfiguracion.configuraciones)

            '        Trans.Commit()

            '        MsgBox("Los datos fueron ingresados correctamente")

            '    Catch ex As Exception
            '        'SqlConnection.BeginTransaction.Rollback()
            '        Trans.Rollback()
            '        System.Windows.Forms.MessageBox.Show(ex.Message)
            '    End Try
            'End Sub

        End Sub

    End Class
End Namespace