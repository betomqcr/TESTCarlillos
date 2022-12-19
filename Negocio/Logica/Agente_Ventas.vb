Namespace Logica
    Public Class Agente_Ventas

        Private db As Datos.Class.AgentesVentas

        Sub New()
            Me.db = New Datos.Class.AgentesVentas
        End Sub

        Public Function Buscar(nombre As String) As List(Of Datos.Models.AgenteVenta)

            Return Me.db.ObtenerAgenteVentas(nombre)

            'Dim cFunciones As New cFunciones
            'Me.Cod_agente_Buscar = cFunciones.BuscarDatosClientes("select id as id,nombre as Nombre from agente_ventas", "Nombre")
            'If Cod_agente_Buscar = 0 Then Exit Sub

        End Function

        Public Function Crear(agente_ventas As Datos.Models.AgenteVenta) As String

            Return db.CrearAgenteVentas(agente_ventas)

            '     Function Registrar()
            '    Try
            '        Me.BindingContext(Me.DtsAgentes1.agente_ventas).EndCurrentEdit()
            '        Me.Adapter_agentes.Update(Me.DtsAgentes1.agente_ventas)
            '        MsgBox("Los datos fueron ingresados correctamente")
            '    Catch ex As Exception
            '        System.Windows.Forms.MessageBox.Show(ex.Message)
            '    End Try
            'End Function

            'Private Sub btnPD_Click(sender As Object, e As EventArgs) Handles btnPD.Click
            '    Dim frm As New frmPD
            '    frm.IdAgente = Me.BindingContext(Me.DtsAgentes1, "agente_ventas").Current("id")
            '    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            '        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '        db.Ejecutar("Delete from PrecioDiferenciado Where IdAgente = " & frm.IdAgente, CommandType.Text)
            '        For Each f As DataGridViewRow In frm.DataGridView1.Rows
            '            db.Ejecutar("insert into PrecioDiferenciado(IdAgente, CodProveedor, Proveedor, Tipo, Porcentaje) values(" & frm.IdAgente & ", " & f.Cells("cCodProveedor").Value & ", '" & f.Cells("cProveedor").Value & "', '" & f.Cells("cTipo").Value & "', " & f.Cells("cPorcentaje").Value & ")", CommandType.Text)
            '        Next
            '    End If
            'End Sub

        End Function

        Public Function Editar(id As Integer, agente_ventas As Datos.Models.AgenteVenta) As String
            Dim res As String = db.EditarAgenteVentas(id, agente_ventas)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If

            'Public Sub RegistrarDatos(ByRef Adaptador As System.Data.SqlClient.SqlDataAdapter, ByRef DataSet As DataSet, ByRef Tabla As String, Optional ByVal ActivarNuevo As Boolean = True, Optional ByVal VerMsg As Boolean = True, Optional ByVal RecargarAdatador As Boolean = True)
            '    Try
            '        BindingContext(DataSet, Tabla).EndCurrentEdit()
            '        Adaptador.Update(DataSet, Tabla)
            '        If RecargarAdatador Then Adaptador.Fill(DataSet, Tabla)
            '        If ActivarNuevo Then ToolBar1.Buttons(0).Text = "Nuevo" : ToolBar1.Buttons(0).ImageIndex = 0
            '        If VerMsg Then MsgBox("Los datos se actualizaron satisfactoriamente...", MsgBoxStyle.Information, "Atención...")
            '    Catch eEndEdit As System.Exception
            '        System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            '    End Try
            'End Sub

            'Private Sub btnPD_Click(sender As Object, e As EventArgs) Handles btnPD.Click
            '    Dim frm As New frmPD
            '    frm.IdAgente = Me.BindingContext(Me.DtsAgentes1, "agente_ventas").Current("id")
            '    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            '        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '        db.Ejecutar("Delete from PrecioDiferenciado Where IdAgente = " & frm.IdAgente, CommandType.Text)
            '        For Each f As DataGridViewRow In frm.DataGridView1.Rows
            '            db.Ejecutar("insert into PrecioDiferenciado(IdAgente, CodProveedor, Proveedor, Tipo, Porcentaje) values(" & frm.IdAgente & ", " & f.Cells("cCodProveedor").Value & ", '" & f.Cells("cProveedor").Value & "', '" & f.Cells("cTipo").Value & "', " & f.Cells("cPorcentaje").Value & ")", CommandType.Text)
            '        Next
            '    End If
            'End Sub
        End Function

        Public Function Eliminar(id As Integer) As String
            Dim res As String = Me.db.BorrarAgenteVenta(id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If

            'Public Sub EliminarDatos(ByRef Adaptador As System.Data.SqlClient.SqlDataAdapter, ByRef DataSet As DataSet, ByRef Tabla As String, Optional ByVal RecargarAdatador As Boolean = True)
            '    Dim resp As Integer

            '    If MsgBox("Desea eliminar el registro actual...", MsgBoxStyle.YesNo, "Atención...") = MsgBoxResult.Yes Then
            '        Try
            '            BindingContext(DataSet, Tabla).RemoveAt(BindingContext(DataSet, Tabla).Position)
            '            BindingContext(DataSet, Tabla).EndCurrentEdit()
            '            Adaptador.Update(DataSet, Tabla)
            '            If RecargarAdatador Then Adaptador.Update(DataSet, Tabla)
            '            Adaptador.Fill(DataSet, Tabla)

            '            MsgBox("Los datos se eliminaron satisfactoriamente", MsgBoxStyle.Information)

            '        Catch eEndEdit As System.Data.NoNullAllowedException
            '            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            '        End Try
            '    End If
            'End Sub

        End Function


        Public Function cargarPrecioDiferenciado(idAgente As Integer) As List(Of Modelo.preciodiferenciado)

            '      Private Sub CargarDatosAgente()
            '    Dim dt As New DataTable
            '    cFunciones.Llenar_Tabla_Generico("select Id, IdAgente, CodProveedor, Proveedor, Tipo, Porcentaje from PrecioDiferenciado Where IdAgente = " & Me.IdAgente, dt, CadenaConexionSeePOS)
            '    For Each r As DataRow In dt.Rows
            '        Me.AgregarLinea(r.Item("Id"), r.Item("CodProveedor"), r.Item("Proveedor"), r.Item("Tipo"), CDec(r.Item("Porcentaje")))
            '    Next
            'End Sub

            'Private Sub AgregarLinea(_Id As Integer, _CodProveedor As Integer, _Proveedor As String, _Tipo As String, _Porcentaje As Double)
            '    Me.DataGridView1.Rows.Add()
            '    Me.DataGridView1.Item("cId", Index).Value = _Id
            '    Me.DataGridView1.Item("cCodProveedor", Index).Value = _CodProveedor
            '    Me.DataGridView1.Item("cProveedor", Index).Value = _Proveedor
            '    Me.DataGridView1.Item("cTipo", Index).Value = _Tipo
            '    Me.DataGridView1.Item("cPorcentaje", Index).Value = _Porcentaje
            '    Me.Index += 1
            'End Sub

        End Function

    End Class
End Namespace