Namespace Logica
    Public Class CierraCaja

        Private db As Datos.Class.CierreCaja

        Public Sub New()
            Me.db = New Datos.Class.CierreCaja
        End Sub

        Public Function Buscar(porId As Boolean, Filtro As String) As List(Of Datos.Models.Cierrecaja)
            Dim datos As New List(Of Datos.Models.Cierrecaja)
            datos = Me.db.ObtenerCierreCajas(porId, Filtro)

            Dim Resultado As New List(Of Datos.Models.Cierrecaja)
            For Each cierre As Datos.Models.Cierrecaja In datos
                Dim CierreCaja As New Datos.Models.Cierrecaja
                CierreCaja.NumeroCierre = cierre.NumeroCierre
                CierreCaja.Cajera = cierre.Cajera
                CierreCaja.Nombre = cierre.Nombre
                CierreCaja.Apertura = cierre.Apertura
                CierreCaja.Usuario = cierre.Usuario
                CierreCaja.Fecha = cierre.Fecha
                CierreCaja.NombreUsuario = cierre.NombreUsuario
                CierreCaja.Anulado = cierre.Anulado
                CierreCaja.Devoluciones = cierre.Devoluciones
                CierreCaja.Subtotal = cierre.Subtotal
                CierreCaja.TotalSistema = cierre.TotalSistema
                CierreCaja.Equivalencia = cierre.Equivalencia
                CierreCaja.EfectivoColones = cierre.EfectivoColones
                CierreCaja.EfectivoDolares = cierre.EfectivoDolares
                CierreCaja.TarjetaColones = cierre.TarjetaColones
                CierreCaja.TarjetaDolares = cierre.TarjetaDolares
                CierreCaja.Cheques = cierre.Cheques
                CierreCaja.ChequeDol = cierre.ChequeDol
                CierreCaja.DepositosCol = cierre.DepositosCol
                CierreCaja.DepositosDol = cierre.DepositosDol

                For Each det As Datos.Models.CierreCajaDetMon In Me.db.ObtenerCierreCajaDetalleMonto(CierreCaja.NumeroCierre)
                    Dim Detalle As New Datos.Models.CierreCajaDetMon
                    Detalle.IdDetaMoneda = det.IdDetaMoneda
                    Detalle.IdCierreCaja = det.IdCierreCaja
                    Detalle.IdMoneda = det.IdMoneda
                    Detalle.MontoSistema = det.MontoSistema
                    Detalle.MontoCajero = det.MontoCajero

                    CierreCaja.CierreCajaDetMons.Add(Detalle)
                Next

                For Each det As Datos.Models.CierreCajaDetTarj In Me.db.ObtenerCierreCajaDetalleTarjeta(CierreCaja.NumeroCierre)
                    Dim Detalle As New Datos.Models.CierreCajaDetTarj
                    Detalle.IdDetalleTarjeta = det.IdDetalleTarjeta
                    Detalle.IdCierreCaja = det.IdCierreCaja
                    Detalle.IdTipoTarjeta = det.IdTipoTarjeta
                    Detalle.MontoSistema = det.MontoSistema
                    Detalle.MontoCajero = det.MontoCajero

                    CierreCaja.CierreCajaDetTarjs.Add(Detalle)
                Next

                Resultado.Add(CierreCaja)
            Next

            Return Resultado
        End Function

        Public Function Anular(Id As Integer) As String
            Dim res As String = Me.db.AnularCierreCaja(Id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
            'Private Sub Anular()
            '    Dim resp As Integer
            '    If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = SqlConnection1.BeginTransaction
            '    Dim myCommand1 As SqlCommand = SqlConnection1.CreateCommand()
            '    Dim myCommand2 As SqlCommand = SqlConnection1.CreateCommand()

            '    resp = MessageBox.Show("¿Deseas Anular este Cierre?", "SeeSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            '    If resp = 6 Then
            '        myCommand1.CommandText = "UPDATE CierreCaja SET Anulado =  1 WHERE NumeroCierre = " & BindingContext(Me.DataSetCierreCaja1, "CierreCaja").Current("NumeroCierre")
            '        myCommand2.CommandText = "UPDATE aperturacaja SET Estado = '" & "M" & "' WHERE NApertura = " & BindingContext(Me.DataSetCierreCaja1, "CierreCaja").Current("Apertura")
            '        myCommand1.Transaction = Trans
            '        myCommand2.Transaction = Trans
            '        myCommand1.ExecuteNonQuery()
            '        myCommand2.ExecuteNonQuery()
            '        Trans.Commit()
            '        MsgBox("Datos Anulados Correctamente....", MsgBoxStyle.Information, "Atención...")
            '        lblanulado.Visible = True
            '    End If
            'End Sub

        End Function

        Public Function Crear(cierrecaja As Datos.Models.Cierrecaja) As String
            Return Me.db.CrearAreas(cierrecaja)
            'Private Function Registar() As Boolean
            '    If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = SqlConnection1.BeginTransaction
            '    Try
            '        SqlInsertCommand1.Transaction = Trans
            '        SqlUpdateCommand1.Transaction = Trans
            '        SqlInsertCommand2.Transaction = Trans
            '        SqlUpdateCommand2.Transaction = Trans
            '        SqlInsertCommand3.Transaction = Trans
            '        SqlUpdateCommand3.Transaction = Trans
            '        AdapterCierre.Update(Me.DataSetCierreCaja1.cierrecaja)
            '        Apertura = Me.DataSetCierreCaja1.cierrecaja.Rows(0).Item("Apertura")
            '        AdapterCierreTarjeta.Update(Me.DataSetCierreCaja1.CierreCaja_DetTarj)
            '        AdapterCierreMonto.Update(Me.DataSetCierreCaja1.CierreCaja_DetMon)
            '        Trans.Commit()
            '        Return True

            '    Catch eEndEdit As System.Exception
            '        Trans.Rollback()
            '        System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            '        Return False
            '    End Try
            'End Function

            'Private Function CambiarEstadoApertura() As Boolean
            '    If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = SqlConnection1.BeginTransaction

            '    Try
            '        Dim myCommand2 As SqlCommand = SqlConnection1.CreateCommand()
            '        myCommand2.CommandText = "UPDATE aperturacaja SET Estado = '" & "C" & "' WHERE NApertura = " & BindingContext(Me.DataSetCierreCaja1, "cierrecaja").Current("Apertura")
            '        myCommand2.Transaction = Trans
            '        myCommand2.ExecuteNonQuery()
            '        Trans.Commit()
            '        Return True

            '    Catch eEndEdit As System.Exception
            '        Trans.Rollback()
            '        System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            '        Return False
            '    End Try
            'End Function

        End Function

    End Class
End Namespace