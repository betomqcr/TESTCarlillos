Namespace Logica
    Public Class Descuentos

        Private db As Datos.Class.Descuentos

        Sub New()
            Me.db = New Datos.Class.Descuentos
        End Sub


        Public Function Buscar(Id As Decimal) As List(Of Datos.Models.Descuento)
            Return Me.db.ObtenerporId(Id)
            'Private Sub Cargar_Descuntos()
            '    Dim dt As New DataTable
            '    cFunciones.Llenar_Tabla_Generico("Select * from viewDescuentos", dt, CadenaConexionSeePOS)
            '    Me.viewDatos.DataSource = dt
            '    Me.viewDatos.Columns("IdDescuento").Visible = False
            '    Me.viewDatos.Columns("IdProveedor").Visible = False
            '    Me.viewDatos.Columns("ContactoConfirmo").Visible = False
            'End Sub

        End Function

        Public Function Crear(descuento As Datos.Models.Descuento) As String
            Return Me.db.Crear(descuento)
            'Private Sub Guardar_Descuento()
            '    If Me.IdProveedor <> "0" And Me.txtProveedor.Text <> "" Then
            '        If IsNumeric(Me.txtDescuento.Text) Then
            '            If CDec(Me.txtDescuento.Text) > 0 Then
            '                If CDate(Me.dtpHasta.Value.ToShortDateString) >= CDate(Me.dtpDesde.Value.ToShortDateString) Then
            '                    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)

            '                    If Me.IdDescuento = "0" Then
            '                        db.Ejecutar("Insert into Descuentos(IdProveedor, Desde, Hasta, Descuento, Confirmado, ContactoConfirmo) Values(" & Me.IdProveedor & ", dbo.dateonly('" & Me.dtpDesde.Value.ToShortDateString & "'), dbo.dateonly('" & Me.dtpHasta.Value.ToShortDateString & "')," & CDec(Me.txtDescuento.Text) & ", " & IIf(Me.ckEstado.Checked = True, 1, 0) & ", '" & Me.txtContactoConfirmo.Text & "')", Data.CommandType.Text)
            '                    Else
            '                        db.Ejecutar("Update Descuentos set IdProveedor = " & Me.IdProveedor & ", Desde = dbo.dateonly('" & Me.dtpDesde.Value.ToShortDateString & "') , Hasta = dbo.dateonly('" & Me.dtpHasta.Value.ToShortDateString & "') , Descuento = " & CDec(Me.txtDescuento.Text) & ", Confirmado = " & IIf(Me.ckEstado.Checked = True, 1, 0) & ", ContactoConfirmo = '" & Me.txtContactoConfirmo.Text & "' Where IdDescuento = " & Me.IdDescuento, CommandType.Text)
            '                    End If
            '                    Me.LimpiarDescuento()
            '                    Me.Cargar_Descuntos()
            '                End If
            '            End If
            '        End If
            '    End If
            'End Sub

        End Function

        Public Function Editar(id As Decimal, descuento As Datos.Models.Descuento) As String
            Dim res As String = Me.db.Editar(id, descuento)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

        Public Function Eliminar(id As Decimal) As String
            Dim res As String = Me.db.Borrar(id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
            'Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
            '    If MsgBox("Desea Eliminar El Descuento", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") Then
            '        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '        db.Ejecutar("Delete from Descuentos Where IdDescuento = " & Me.IdDescuento, CommandType.Text)
            '        Me.LimpiarDescuento()
            '        Me.Cargar_Descuntos()
            '    End If
            'End Sub

        End Function

    End Class
End Namespace

