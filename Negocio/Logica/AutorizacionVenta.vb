Namespace Logica
    Public Class AutorizacionVenta


        Public Function buscarFacturasPendinetes(porNombreRetira As Boolean,
                                                 porNombreCliente As Boolean,
                                                 porNombreCajaro As Boolean,
                                                 porNombreAdmin As Boolean,
                                                 nombre As String)

            'Private Sub Buscar(_texto As String)
            '    Dim dt As New DataTable
            '    cFunciones.Llenar_Tabla_Generico("select cast(0 as bit) as Usar, Basededatos, PuntoVenta, Id, Id_Factura, Num_Factura, Nombre_Cliente as Cliente, Nombre_Retira as Retiro, Fecha, Cajero, Administrador, Total from viewAutorizacionFacturasPendientes Where Total > 1 and Cancelada = 0 And (Nombre_Cliente like '%" & _texto & "%' or Nombre_Retira like '%" & _texto & "%' or Cajero like '%" & _texto & "%' or Administrador like '%" & _texto & "%') ", dt, CadenaConexionSeePOS)
            '    Me.viewDatos.DataSource = dt
            '    Me.viewDatos.Columns("Id").Visible = False
            '    Me.viewDatos.Columns("Id_Factura").Visible = False
            '    Me.viewDatos.Columns("Basededatos").Visible = False

            '    For Each col As DataGridViewColumn In Me.viewDatos.Columns
            '        col.ReadOnly = True
            '    Next
            '    Me.viewDatos.Columns("Usar").ReadOnly = False

            'End Sub

        End Function

        Public Sub creaAutorizacionVenta(puntodeVenta As String,
                               id_factrua As Integer,
                                id_cajero As Integer,
                                id_admin As Integer,
                                cedula_retira As String,
                                nombre_retira As String)

            'trans.Ejecutar("Insert Into " & Me.PuntodeVenta & ".dbo.AutorizacionVenta(Id_Factura, Id_Cajero, Id_Admin, Cedula_Retira, Nombre_Retira) Values(" & Id_Factura & ", '" & Me.Id_Usuario & "', '" & Me.Id_Administrador & "', '" & Me.CedulaCliente & "', '" & Me.NombreCliente & "')", CommandType.Text)

        End Sub

        Public Function reporte()

            'Dim rpt As New rptEstadoContadoFirmado
            'rpt.SetParameterValue(0, "0")
            'rpt.SetParameterValue(1, Me.FechaFinal.Value)
            'rpt.SetParameterValue(2, Me.ComboBox1.Text)
            'CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)

        End Function

    End Class
End Namespace