Namespace Logica
    Public Class PreAbonocCobrar

        Private db As Datos.Class.PreAbonocCobrar

        Sub New()
            Me.db = New Datos.Class.PreAbonocCobrar
        End Sub

        Public Function Crear(abonoccobrar As Datos.Models.PreAbonocCobrar) As String

            Return Me.db.Crear(abonoccobrar)

            'Datos.Models.PreAbonocCobrar
            'Datos.Models.PreAbonocCobrar

            'BindingContext(DsRecibos1, "abonoccobrar").EndCurrentEdit()
            'BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").EndCurrentEdit()

            '''llamar al formulario de opciones de pago
            ''Dim Movimiento_Pago_Abonos As New frmMovimientoCajaPagoAbono(usua)
            ''Movimiento_Pago_Abonos.Factura = CDbl(txtNum_Recibo.Text)
            ''Movimiento_Pago_Abonos.fecha = "" & dtFecha.Text
            ''Movimiento_Pago_Abonos.Total = CDbl(txtAbonoGen.Text)
            ''Movimiento_Pago_Abonos.Tipo = "ABO"
            ''Movimiento_Pago_Abonos.codmod = ComboMoneda.SelectedValue
            ''Movimiento_Pago_Abonos.ShowDialog()

            ''If Movimiento_Pago_Abonos.Registra Then

            'For i = 0 To BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Count - 1
            '    BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Position = i
            '    If BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Saldo") = 0 Then
            '        FactTemp = BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Factura")
            '        If (Funciones.UpdateRecords("Ventas", "FacturaCancelado = 1", "Num_Factura =" & FactTemp & " and Tipo = '" & BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Tipo") & "'")) <> "" Then
            '            MsgBox("Problemas al Registrar las facturas como canceladas, reintente hacer el abono", MsgBoxStyle.Critical)
            '            Exit Sub
            '        End If
            '    End If
            'Next


            'Function registrar_Abono(Optional ByVal _ObligaCaja3 As Boolean = False) As Boolean

            '    If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
            '    Trans = SqlConnection1.BeginTransaction
            '    Try

            '        If Me.AplicaCambioenCaja = True Then
            '            If _ObligaCaja3 = True Then
            '                If adAbonos.InsertCommand.CommandText.IndexOf("PreAbonocCobrar") > 0 Then
            '                    adAbonos.InsertCommand.CommandText = adAbonos.InsertCommand.CommandText.Replace("PreAbonocCobrar", "abonoccobrar")
            '                    adAbonos.UpdateCommand.CommandText = adAbonos.InsertCommand.CommandText.Replace("PreAbonocCobrar", "abonoccobrar")
            '                    adAbonos.DeleteCommand.CommandText = adAbonos.InsertCommand.CommandText.Replace("PreAbonocCobrar", "abonoccobrar")

            '                    daDetalle_Abono.InsertCommand.CommandText = daDetalle_Abono.InsertCommand.CommandText.Replace("Detalle_PreAbonocCobrar", "detalle_abonoccobrar")
            '                    daDetalle_Abono.UpdateCommand.CommandText = daDetalle_Abono.InsertCommand.CommandText.Replace("Detalle_PreAbonocCobrar", "detalle_abonoccobrar")
            '                    daDetalle_Abono.DeleteCommand.CommandText = daDetalle_Abono.InsertCommand.CommandText.Replace("Detalle_PreAbonocCobrar", "detalle_abonoccobrar")
            '                End If
            '            Else
            '                If Not adAbonos.InsertCommand.CommandText.IndexOf("PreAbonocCobrar") > 0 Then
            '                    adAbonos.InsertCommand.CommandText = adAbonos.InsertCommand.CommandText.Replace("abonoccobrar", "PreAbonocCobrar")
            '                    adAbonos.UpdateCommand.CommandText = adAbonos.InsertCommand.CommandText.Replace("abonoccobrar", "PreAbonocCobrar")
            '                    adAbonos.DeleteCommand.CommandText = adAbonos.InsertCommand.CommandText.Replace("abonoccobrar", "PreAbonocCobrar")

            '                    daDetalle_Abono.InsertCommand.CommandText = daDetalle_Abono.InsertCommand.CommandText.Replace("detalle_abonoccobrar", "Detalle_PreAbonocCobrar")
            '                    daDetalle_Abono.UpdateCommand.CommandText = daDetalle_Abono.InsertCommand.CommandText.Replace("detalle_abonoccobrar", "Detalle_PreAbonocCobrar")
            '                    daDetalle_Abono.DeleteCommand.CommandText = daDetalle_Abono.InsertCommand.CommandText.Replace("detalle_abonoccobrar", "Detalle_PreAbonocCobrar")
            '                End If
            '            End If
            '        End If

            '        adAbonos.InsertCommand.Transaction = Trans
            '        adAbonos.DeleteCommand.Transaction = Trans
            '        adAbonos.UpdateCommand.Transaction = Trans

            '        daDetalle_Abono.InsertCommand.Transaction = Trans
            '        daDetalle_Abono.DeleteCommand.Transaction = Trans
            '        daDetalle_Abono.UpdateCommand.Transaction = Trans

            '        adAbonos.Update(DsRecibos1, "abonoccobrar")
            '        daDetalle_Abono.Update(DsRecibos1, "detalle_abonoccobrar")

            '        Trans.Commit()
            '        Return True
            '    Catch ex As Exception
            '        Trans.Rollback()
            '        MsgBox(ex.Message)
            '        ToolBar1.Buttons(2).Enabled = True
            '        Return False
            '    End Try
            'End Function



        End Function


    End Class
End Namespace