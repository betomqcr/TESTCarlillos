Namespace Logica
    Public Class CambioInventario

        Private db As Datos.Class.CambioInventario

        Public Sub New()
            Me.db = New Datos.Class.CambioInventario
        End Sub

        Public Function Buscar() As List(Of Datos.Models.CambioInventario)
            Return Me.Buscar()
            'Dim strSQL As String = "select * from viewCambiosInventario Where aplicado = 0"
            'Dim dt As New DataTable
            'cFunciones.Llenar_Tabla_Generico(strSQL, dt, CadenaConexionSeePOS)
            'Me.viewCambios.DataSource = dt
        End Function

        Public Function Crear(cambioinventario As Datos.Models.CambioInventario) As String
            Return Me.db.CrearCambioInventario(cambioinventario)
            'Public Sub GuardarCambio()
            '    'guarda el cambio
            '    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '    db.AddParametro("@IdUsuario", Me.IdUsuario)
            '    db.AddParametro("@Fecha", Date.Now)
            '    db.AddParametro("@CodigoFacturado", Me.CodigoFacturo)
            '    db.AddParametro("@CantidadFacturado", Me.txtCantidadFacturado.Text)
            '    db.AddParametro("@CodigoEntregado", Me.CodigoEntrego)
            '    db.AddParametro("@CantidadEntregado", Me.txtCantidadEntegado.Text)
            '    db.AddParametro("@Diferencia", CDec(Me.txtDiferencia.Text))
            '    db.AddParametro("@Aplicado", False)
            '    db.Ejecutar("insert into CAmbioInventario(IdUsuario,Fecha,CodigoFacturado,CantidadFacturado,CodigoEntregado,CantidadEntregado,Diferencia,Aplicado) Values(@IdUsuario,@Fecha,@CodigoFacturado,@CantidadFacturado,@CodigoEntregado,@CantidadEntregado,@Diferencia,@Aplicado)", CommandType.Text)
            '    Me.Close()
            'End Sub

        End Function

        Public Sub Aplicar(cambios As List(Of Modelo.cambioinventario))

            'Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
            '    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '    For Each row As DataGridViewRow In Me.viewCambios.Rows
            '        If row.Cells("Aplicado").Value = True Then
            '            db.AddParametro("@Id", row.Cells("Id").Value)
            '            db.Ejecutar("AplicarCambioInventario")
            '        End If
            '    Next
            '    Me.Close()
            'End Sub

        End Sub

        Public Function BorrarCambioInventario(id As Integer) As String
            Dim res As String = Me.db.BorrarCambioInventario(id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

    End Class
End Namespace