Namespace Logica
    Public Class Movimiento_Caja

        Private db As Datos.Class.Movimiento_Caja

        Sub New()
            Me.db = New Datos.Class.Movimiento_Caja
        End Sub

        Public Function Crear(movimiento_caja As Datos.Models.MovimientoCaja) As String

            Return Me.db.Crear(movimiento_caja)

            'Datos.Models.MovimientoCaja
            'Datos.Models.MovimientoCaja

            'Sub Registrar()
            '    Try
            '        If MsgBox("¿Desea Registrar el Movimiento de Caja?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            '            Me.BindingContext(Me.DataSet_MovimientoCaja1, "Movimiento_Caja").EndCurrentEdit()
            '            Me.Adapter_MovimientoCaja.Update(Me.DataSet_MovimientoCaja1, "Movimiento_Caja")
            '            MsgBox("Datos Ingresados Satisfactoriamente", MsgBoxStyle.Information)

            '            LabelId.Text = IdMovimiento()
            '            'open_cashdrawer()
            '            If MsgBox("¿Desea imprimir el Movimiento de Caja?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            '                Me.imprimir()
            '            End If
            '            Me.DataSet_MovimientoCaja1.Movimiento_Caja.Clear()
            '            Me.ToolBar1.Buttons(0).Text = "Nuevo"
            '            Me.ToolBar1.Buttons(0).ImageIndex = 0

            '            GroupBox1.Enabled = False
            '            ComboBo_Moneda.Enabled = False
            '            Calc_Monto.Enabled = False
            '            Text_Observaciones.Enabled = False
            '        End If

            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        MsgBox("Error al Ingresar Los datos, intentelo de nuevo", MsgBoxStyle.Critical)
            '    End Try
            'End Sub

        End Function

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.MovimientoCaja)
            Return Me.db.Buscar(porNombre, Filtro)
        End Function

        Public Function Anular(id As Integer) As String
            Dim res As String = Me.db.Anular(id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
            'Sub Anular()
            '    Try
            '        If MsgBox("Desea Anular este Movimiento de Caja", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            '            Me.Check_Anulado.Checked = True
            '            Me.BindingContext(Me.DataSet_MovimientoCaja1, "Movimiento_Caja").EndCurrentEdit()
            '            Me.Adapter_MovimientoCaja.Update(Me.DataSet_MovimientoCaja1, "Movimiento_Caja")
            '            MsgBox("Factura Anulada Satisfactoriamente", MsgBoxStyle.Information)
            '        End If

            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        MsgBox("Problemas al Anular la Factura, intentelo de nuevo", MsgBoxStyle.Critical)
            '    End Try
            'End Sub

        End Function

    End Class
End Namespace