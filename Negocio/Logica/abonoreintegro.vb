﻿Namespace Logica
    Public Class abonoreintegro


        Public Function numeroRecibo() As Integer

            'Private Function GetNumRecibo() As Integer
            '    Dim dt As New DataTable
            '    cFunciones.Llenar_Tabla_Generico("select isnull(max(Recibo),0) + 1 as NumRecibo from ConsecutivoReciboReintegro", dt, CadenaConexionSeePOS)
            '    If dt.Rows.Count > 0 Then
            '        Return CInt(dt.Rows(0).Item("NumRecibo"))
            '    Else
            '        Return 1
            '    End If
            'End Function

        End Function

        Public Sub Crear(ByRef Id As Integer,
                                       idFactura As Integer,
                                       fecha As Date,
                                       monto As Decimal,
                                       numRecibo As Integer,
                                       numApertrua As Integer)

            'trans = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
            'Try

            '    For Each pago As DataGridViewRow In frm.viewDatos.Rows
            '        trans.Ejecutar("INSERT INTO [dbo].[OpcionesDePago] ([Documento],[TipoDocumento],[MontoPago],[FormaPago],[Denominacion],[Usuario],[Nombre],[CodMoneda],[Nombremoneda],[TipoCambio],[Fecha],[Numapertura],[Vuelto],[NumeroDocumento])VALUES(" & Documento & ", '" & pago.Cells("cTipoDocumento").Value & "'," & CDec(pago.Cells("cMontoPago").Value) & ", '" & pago.Cells("cFormaPago").Value & "'," & pago.Cells("cDenominacion").Value & ", '" & pago.Cells("cUsuario").Value & "','" & pago.Cells("cNombre").Value & "'," & pago.Cells("cCodMoneda").Value & ", '" & pago.Cells("cNombremoneda").Value & "', " & pago.Cells("cTipoCambio").Value & ", getdate()," & pago.Cells("cNumapertura").Value & ", 0, '" & pago.Cells("cNumeroDocumento").Value & "')", CommandType.Text)
            '    Next

            '    For Each t As PagoTranferencia In frm.ListaPagosTransferencia
            '        trans.Ejecutar("insert into ArqueoDeposito(IdArqueo, IdApertura, Banco, Cuenta, Moneda, Numero, Monto, Tipo) values(" & 0 & ", " & NApertura & ", '" & t.Banco & "', '" & t.Cuenta & "', '" & t.Moneda & "', '" & t.NumeroDocumento & "', " & CDec(t.Monto) & ", 'Transferencia')", CommandType.Text)
            '    Next

            '    For Each f As DataGridViewRow In Me.viewDatos.Rows
            '        PuntodeVenta = f.Cells("cBasededatos").Value
            '        Id_Factura = f.Cells("cId").Value

            '        trans.AddParametroSalida("@Id", NumeroAbono)
            '        trans.SetParametro("@IdFactura", Id_Factura)
            '        trans.SetParametro("@Fecha", Date.Now)
            '        trans.SetParametro("@Monto", CDec(f.Cells("cAbono").Value))
            '        trans.SetParametro("@NumRecibo", Documento)
            '        trans.SetParametro("@NumApertura", NApertura)
            '        trans.Ejecutar("InsertAbonoReintegro", NumeroAbono, 0)

            '        If CDec(f.Cells("cAbono").Value) >= CDec(f.Cells("cTotal").Value) Then
            '            trans.Ejecutar("Update " & PuntodeVenta & ".dbo.AutorizacionVenta set Cancelada = 1, FechaCancelacion = GETDATE(), IdApertura = " & NApertura & ", NumRecibo = " & Documento & " where Id_Factura = " & Id_Factura, CommandType.Text)
            '        End If
            '    Next
            '    trans.Ejecutar("Update ConsecutivoReciboReintegro Set Recibo = Recibo + 1", CommandType.Text)
            '    trans.Commit()
            'Catch ex As Exception
            '    trans.Rollback()
            '    MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text & " - ")
            '    Exit Sub
            'End Try

        End Sub

        Public Function Buscar(recibo As Integer) As List(Of Modelo.autorizacionventa)

            'reporte tiquete de caja

            'Dim rpt As New rptReciboContadoFirmado
            'CrystalReportsConexion.LoadReportViewer(Nothing, rpt, True)
            'If Caja = 1 Then
            '    Dim PrinterSettings1 As New Printing.PrinterSettings
            '    Dim PageSettings1 As New Printing.PageSettings
            '    'PrinterSettings1.PrinterName = Automatic_Printer_Dialog(5)
            '    PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

            '    rpt.SetParameterValue(0, Documento)
            '    rpt.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            '    rpt.PrintToPrinter(PrinterSettings1, PageSettings1, False)
            'End If

        End Function

    End Class
End Namespace