Namespace Logica
    Public Class MensajeReceptor


        Public Function Buscar(entreFechas As Boolean,
                                              porEstado As Boolean,
                                              estados As String,
                                              desde As Date,
                                              hasta As Date) As List(Of Modelo.mensajereceptor)

            'Dim SQL As String = "select Id, Proveedor, FechaEmisionDoc as FechaEmision, Moneda, MontoTotalImpuesto, TotalFactura, Mensaje, Estado from MensajeReceptor "
            'Dim Filtro As String = ""

            'If Me.ckFiltrarxFecha.Checked = True And Me.ckFiltrarxEstado.Checked = True Then
            '    Filtro = " Where Mensaje In(" & Me.getEstados & ") And dbo.dateonly(FechaEmisionDoc) >= dbo.dateonly('" & Me.dtpDesde.Value.ToShortDateString & "') and dbo.dateonly(FechaEmisionDoc) <= dbo.dateonly('" & Me.dtpHasta.Value.ToShortDateString & "')"
            'End If

            'If Me.ckFiltrarxFecha.Checked = True And Me.ckFiltrarxEstado.Checked = False Then
            '    Filtro = " Where dbo.dateonly(FechaEmisionDoc) >= dbo.dateonly('" & Me.dtpDesde.Value.ToShortDateString & "') and dbo.dateonly(FechaEmisionDoc) <= dbo.dateonly('" & Me.dtpHasta.Value.ToShortDateString & "')"
            'End If

            'If Me.ckFiltrarxFecha.Checked = False And Me.ckFiltrarxEstado.Checked = True Then
            '    Filtro = " Where Mensaje In(" & Me.getEstados & ")"
            'End If

            'If Me.ckFiltrarxFecha.Checked = False And Me.ckFiltrarxEstado.Checked = False Then
            '    Filtro = ""
            'End If

            'Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            'Dim dt As New DataTable
            'dt = db.Ejecutar(SQL & Filtro & " Order by FechaEmisionDoc", CommandType.Text)

        End Function

        Public Sub Crear(mensajereceptor As List(Of Modelo.mensajereceptor))

            'Private Sub Guardar_Datos()
            '    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '    Dim FechaEmisionDoc As DateTime = Date.Now
            '    For Each fila As System.Windows.Forms.DataGridViewRow In Me.viewDatosXML.Rows
            '        If fila.Visible = True Then
            '            If Me.ClaveExiste(fila.Cells("cClave").Value) = False Then
            '                db.Ejecutar("Insert into MensajeReceptor(Clave,NumeroCedulaEmisor, Proveedor,FechaEmisionDoc,Mensaje,MontoTotalImpuesto,TotalFactura,Estado,DetalleMensaje,CodigoActividad,CondicionImpuesto,MontoTotalImpuestoAcreditar,MontoTotalDeGastoAplicable) Values ('" & fila.Cells("cClave").Value & "','" & fila.Cells("cNumeroCedulaEmisor").Value & "', '" & fila.Cells("cNombre").Value & "', Getdate(),'" & fila.Cells("cMensaje").Value & "', " & fila.Cells("cMontoTotalImpuesto").Value & ", " & fila.Cells("cTotalFactura").Value & ",'pendiente', '" & fila.Cells("cDetalleMensaje").Value & "', '" & fila.Cells("cCodigoActividad").Value & "', '" & fila.Cells("cCondicionImpuesto").Value & "', " & fila.Cells("cMontoTotalImpuestoAcreditar").Value & "," & fila.Cells("cMontoTotaldeGastoAplicable").Value & ")", Data.CommandType.Text)
            '            Else
            '                fila.DefaultCellStyle.BackColor = Drawing.Color.Red
            '            End If
            '        End If
            '    Next
            '    Me.Close()
            'End Sub

        End Sub




    End Class
End Namespace