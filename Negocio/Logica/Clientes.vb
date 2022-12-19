Namespace Logica
    Public Class Clientes

        Private db As Datos.Class.Cliente

        Sub New()
            Me.db = New Datos.Class.Cliente
        End Sub

        Public Function Buscar(porNombre As Boolean,
                                      filtro As String) As List(Of Datos.Models.Cliente)
            Return Me.db.Buscar(porNombre, filtro)
        End Function

        Public Function Crear(cliente As Datos.Models.Cliente) As String

            Return Me.db.Crear(cliente)

            'Dim Pasa As Boolean = True

            'If Len(Me.Txtnombre.Text) = 0 Then
            '    ErrorProvider1.SetError(Txtnombre, "Debe de Digitar el nombre del Cliente")
            '    Pasa = False
            'Else
            '    ErrorProvider1.SetError(Txtnombre, "")
            'End If

            'If Len(Me.Txtcedula.Text) = 0 Then
            '    ErrorProvider1.SetError(Txtcedula, "Debe de Digitar el nombre del Cliente")
            '    Pasa = False
            'Else
            '    ErrorProvider1.SetError(Txtcedula, "")
            'End If

            'If Len(Me.Txttel1.Text) = 0 Then
            '    ErrorProvider1.SetError(Txttel1, "Debe de Digitar un número de teléfono del Cliente")
            '    Pasa = False
            'Else
            '    ErrorProvider1.SetError(Txttel1, "")
            'End If

            'If Len(Me.Txdireccion.Text) = 0 Then
            '    ErrorProvider1.SetError(Txdireccion, "Debe de Digitar la dirección del Cliente")
            '    Pasa = False
            'Else
            '    ErrorProvider1.SetError(Txdireccion, "")
            'End If

            'If Pasa = False Then
            '    MsgBox("No se puede realizar la operacion.", MsgBoxStyle.Exclamation, "Faltan datos por Ingresar!!!")
            '    Exit Sub
            'End If

            'If MessageBox.Show("¿Desea Registrar este Cliente?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then 'si no desea guardar la facturacion
            '    Exit Sub
            'End If

            'Function RegistrarCliente() As Boolean

            '    If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
            '    Try
            '        Me.SqlInsertCommand1.Transaction = Trans
            '        Me.SqlUpdateCommand1.Transaction = Trans
            '        Me.SqlDeleteCommand1.Transaction = Trans

            '        Me.SqlInsertCommand2.Transaction = Trans
            '        Me.SqlUpdateCommand2.Transaction = Trans
            '        Me.SqlDeleteCommand2.Transaction = Trans

            '        Me.SqlInsertCommand3.Transaction = Trans
            '        Me.SqlUpdateCommand3.Transaction = Trans
            '        Me.SqlDeleteCommand3.Transaction = Trans

            '        Me.SqlInsertCommand4.Transaction = Trans
            '        Me.SqlUpdateCommand4.Transaction = Trans
            '        Me.SqlDeleteCommand4.Transaction = Trans

            '        Me.Adapter_Bitacora.SelectCommand.Transaction = Trans
            '        Me.Adapter_Bitacora.InsertCommand.Transaction = Trans
            '        Me.Adapter_Bitacora.DeleteCommand.Transaction = Trans
            '        Me.Adapter_Bitacora.UpdateCommand.Transaction = Trans

            '        Me.Adapter_Clientes.Update(Me.DataSetClientes1, "Clientes")
            '        Me.Adapter_EncargadosCompras.Update(Me.DataSetClientes1, "encargadocompras")
            '        Me.Adapter_Referencia_Bancaria.Update(Me.DataSetClientes1, "referenciabancaria")
            '        Me.Adapter_Referencia_Comercial.Update(Me.DataSetClientes1, "referenciacomercial")

            '        Me.Adapter_Bitacora.Update(Me.DataSetClientes1, "Bitacora")

            '        Me.Eliminando = False
            '        Me.nuevo = False
            '        usuario_autorizado = ""

            '        Trans.Commit()
            '        Return True
            '    Catch ex As Exception
            '        Trans.Rollback()
            '        MsgBox(ex.Message)
            '        Me.ToolBar1.Buttons(2).Enabled = True
            '        Return False
            '    End Try

            'End Function
        End Function

        Public Function Editar(id As Long, cliente As Datos.Models.Cliente) As String
            Dim res As String = Me.db.Editar(id, cliente)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
            'igual que crear
        End Function

        Public Function Eliminar(id As Long) As String
            Dim res As String = Me.db.Borrar(id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
            '    Private Sub Eliminar()
            '    Dim Resultado As String
            '    Dim rs As SqlDataReader
            '    Dim cant As Integer
            '    Try
            '        If Me.Txtidentificacion.Text <> "" Then

            '            If Me.SqlConnection1.State = ConnectionState.Closed Then Me.SqlConnection1.Open()

            '            cant = CConexion.SlqExecuteScalar(Me.SqlConnection1, "SELECT COUNT(Id) AS Pendientes FROM Ventas  WHERE  (Cod_Cliente = " & Txtidentificacion.Text & ") AND (FacturaCancelado = 0) AND (Anulado = 0)")
            '            Me.SqlConnection1.Close()

            '            If cant > 0 Then
            '                MsgBox("Este Cliente tiene " & cant.ToString & " Facturas pendientes de Pago, no puede eliminarse", MsgBoxStyle.Exclamation)
            '                Exit Sub
            '            End If


            '            If MessageBox.Show("Desea Eliminar el Cliente", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then Exit Sub


            '            ''ingreso a la bitacora
            '            Me.DataSetClientes1.Bitacora.FechaColumn.DefaultValue = Date.Now
            '            Me.DataSetClientes1.Bitacora.UsuarioColumn.DefaultValue = ""

            '            Me.BindingContext(Me.DataSetClientes1, "Bitacora").CancelCurrentEdit()
            '            Me.BindingContext(Me.DataSetClientes1, "Bitacora").EndCurrentEdit()
            '            Me.BindingContext(Me.DataSetClientes1, "Bitacora").AddNew()
            '            Me.BindingContext(Me.DataSetClientes1, "Bitacora").Current("Usuario") = Me.usua.Nombre
            '            Me.BindingContext(Me.DataSetClientes1, "Bitacora").Current("DescripcionCampo") = Me.Txtnombre.Text & " / " & Me.Txtidentificacion.Text
            '            Me.Tex_Accion.Text = "CLIENTE ELIMINADO"
            '            Me.BindingContext(Me.DataSetClientes1, "Bitacora").EndCurrentEdit()

            '            Me.BindingContext(Me.DataSetClientes1, "Clientes").RemoveAt(Me.BindingContext(Me.DataSetClientes1, "Clientes").Position)
            '            Me.BindingContext(Me.DataSetClientes1, "Clientes").EndCurrentEdit()

            '            Eliminando = True


            '            If Me.RegistrarCliente Then
            '                MessageBox.Show("El cliente fue Eliminado Satisfactoriamente", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '                Me.DataSetClientes1.encargadocompras.Clear()
            '                Me.DataSetClientes1.referenciabancaria.Clear()
            '                Me.DataSetClientes1.referenciacomercial.Clear()
            '                Me.DataSetClientes1.Clientes.Clear()
            '            End If



            '        Else
            '            MessageBox.Show("No hay cliente a eliminar ", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '        End If
            '        'Nuevo_cliente()

            '    Catch ex As SystemException
            '        MsgBox(ex.Message)
            '    End Try

            'End Sub
        End Function

    End Class
End Namespace

