Namespace Logica
    Public Class Valida_FirmadoContado

        Public Function Obtener() As Modelo.valida_firmadocontado

            'Public Function GET_VALIDACION(_ID_VALIDA_FIRMADOCONTADO As Integer) As DataTable
            '    Try
            '        db.AddParametro("@pID_VALIDA_FIRMADOCONTADO", _ID_VALIDA_FIRMADOCONTADO)
            '        Return db.Ejecutar("GET_VALIDACION")
            '    Catch ex As Exception
            '        RaiseEvent AlertaError(ex.Message)
            '    End Try
            'End Function

        End Function

        Public Sub Crear(valida_firmadocontado As Modelo.valida_firmadocontado)

            'Public Sub SAVE_VALIDA_FIRMADOCONTADO(viewEXEPCION_FIRMADOCONTADO As DataGridView)
            '    Try
            '        Dim strSQL As String = ""
            '        Me.CAPTURAR_VALOR(Me.ID_VALIDA_FIRMADOCONTADO, Me.ANTES_DTS)
            '        Me.Inicia()
            '        Me.TRANS.AddParametroSalida("@pID_VALIDA_FIRMADOCONTADO", Me.ID_VALIDA_FIRMADOCONTADO)
            '        Me.TRANS.SetParametro("@pCONTADO", Me.CONTADO)
            '        Me.TRANS.SetParametro("@pPVE", Me.PVE)
            '        Me.TRANS.SetParametro("@pMONTO_MAXIMO", Me.MONTO_MAXIMO)
            '        Me.TRANS.SetParametro("@pEXIGE_NOMBRE", Me.EXIGE_NOMBRE)
            '        Me.TRANS.SetParametro("@pMAXIMO_CLIENTE", Me.MAXIMO_CLIENTE)
            '        Me.TRANS.SetParametro("@pMAXIMO_AUTORIZA", Me.MAXIMO_AUTORIZA)
            '        Me.TRANS.SetParametro("@pMAXIMO_RETIRA", Me.MAXIMO_RETIRA)
            '        Me.TRANS.Ejecutar("SAVE_VALIDA_FIRMADOCONTADO", Me.ID_VALIDA_FIRMADOCONTADO, 0)

            '        For Each X As DataGridViewRow In viewEXEPCION_FIRMADOCONTADO.Rows
            '            Me.TRANS.SetParametro("@pID_EXEPCION_FIRMADOCONTADO", X.Cells("cEFID_EXEPCION_FIRMADOCONTADO").Value)
            '            Me.TRANS.SetParametro("@pID_VALIDA_FIRMADOCONTADO", Me.ID_VALIDA_FIRMADOCONTADO)
            '            Me.TRANS.SetParametro("@pCEDULA", X.Cells("cEFCEDULA").Value)
            '            Me.TRANS.SetParametro("@pNOMBRE", X.Cells("cEFNOMBRE").Value)
            '            Me.TRANS.Ejecutar("SAVE_EXEPCION_FIRMADOCONTADO", CommandType.StoredProcedure)
            '        Next

            '        Me.Termina()
            '        Me.CAPTURAR_VALOR(Me.ID_VALIDA_FIRMADOCONTADO, Me.DESPUES_DTS)
            '        If Me.COMPARAR_ANTESvsDESPUES(strSQL, Me.ID_VALIDA_FIRMADOCONTADO) = True Then db.Ejecutar(strSQL, CommandType.Text)
            '        RaiseEvent AlertaGuardado()
            '    Catch ex As Exception
            '        Me.Cancelar()
            '        RaiseEvent AlertaError(ex.Message)
            '    End Try
            'End Sub

        End Sub

        Public Sub Editar(valida_firmadocontado As Modelo.valida_firmadocontado)

            'Public Sub SAVE_VALIDA_FIRMADOCONTADO(viewEXEPCION_FIRMADOCONTADO As DataGridView)
            '    Try
            '        Dim strSQL As String = ""
            '        Me.CAPTURAR_VALOR(Me.ID_VALIDA_FIRMADOCONTADO, Me.ANTES_DTS)
            '        Me.Inicia()
            '        Me.TRANS.AddParametroSalida("@pID_VALIDA_FIRMADOCONTADO", Me.ID_VALIDA_FIRMADOCONTADO)
            '        Me.TRANS.SetParametro("@pCONTADO", Me.CONTADO)
            '        Me.TRANS.SetParametro("@pPVE", Me.PVE)
            '        Me.TRANS.SetParametro("@pMONTO_MAXIMO", Me.MONTO_MAXIMO)
            '        Me.TRANS.SetParametro("@pEXIGE_NOMBRE", Me.EXIGE_NOMBRE)
            '        Me.TRANS.SetParametro("@pMAXIMO_CLIENTE", Me.MAXIMO_CLIENTE)
            '        Me.TRANS.SetParametro("@pMAXIMO_AUTORIZA", Me.MAXIMO_AUTORIZA)
            '        Me.TRANS.SetParametro("@pMAXIMO_RETIRA", Me.MAXIMO_RETIRA)
            '        Me.TRANS.Ejecutar("SAVE_VALIDA_FIRMADOCONTADO", Me.ID_VALIDA_FIRMADOCONTADO, 0)

            '        For Each X As DataGridViewRow In viewEXEPCION_FIRMADOCONTADO.Rows
            '            Me.TRANS.SetParametro("@pID_EXEPCION_FIRMADOCONTADO", X.Cells("cEFID_EXEPCION_FIRMADOCONTADO").Value)
            '            Me.TRANS.SetParametro("@pID_VALIDA_FIRMADOCONTADO", Me.ID_VALIDA_FIRMADOCONTADO)
            '            Me.TRANS.SetParametro("@pCEDULA", X.Cells("cEFCEDULA").Value)
            '            Me.TRANS.SetParametro("@pNOMBRE", X.Cells("cEFNOMBRE").Value)
            '            Me.TRANS.Ejecutar("SAVE_EXEPCION_FIRMADOCONTADO", CommandType.StoredProcedure)
            '        Next

            '        Me.Termina()
            '        Me.CAPTURAR_VALOR(Me.ID_VALIDA_FIRMADOCONTADO, Me.DESPUES_DTS)
            '        If Me.COMPARAR_ANTESvsDESPUES(strSQL, Me.ID_VALIDA_FIRMADOCONTADO) = True Then db.Ejecutar(strSQL, CommandType.Text)
            '        RaiseEvent AlertaGuardado()
            '    Catch ex As Exception
            '        Me.Cancelar()
            '        RaiseEvent AlertaError(ex.Message)
            '    End Try
            'End Sub



        End Sub

        Public Function CargarExepcion() As List(Of Modelo.exepcion_firmadocontado)

            'Public Function CARGAR_EXEPCION_FIRMADOCONTADO(_ID_VALIDA_FIRMADOCONTADO As Integer) As DataTable
            '    Try
            '        db.AddParametro("@pID_VALIDA_FIRMADOCONTADO", _ID_VALIDA_FIRMADOCONTADO)
            '        Return db.Ejecutar("CARGAR_EXEPCION_FIRMADOCONTADO")
            '    Catch ex As Exception
            '        RaiseEvent AlertaError(ex.Message)
            '    End Try
            'End Function

        End Function

    End Class
End Namespace