Namespace Logica
    Public Class Areas

        Private db As Datos.Class.Areas

        Sub New()
            Me.db = New Datos.Class.Areas
        End Sub

        Public Function Crear(area As Datos.Models.Area) As String
            Return Me.db.CrearAreas(area)

            'Private Function Valida() As Boolean
            '    Try
            '        'Catidad Ingresada
            '        Dim tot As Decimal = 0
            '        'Total Detalle\Tope
            '        Dim dtt As Decimal = 0
            '        'Recorrera el DenominacionesApertura
            '        Dim a As DataRow
            '        'Recorrera el Adapter TotalTope
            '        Dim b As DataRow

            '        Dim s As String = Me.BindingContext(DataSetAperturaCaja1.aperturacaja).Current("NApertura")
            '        Dim id As String = ""

            '        'Recorrera los datos en la tabla moneda del adaptador que contiene los datos de moneda
            '        Dim m As DataRow

            '        For Each b In Me.DataSetAperturaCaja1.Tables("Apertura_Total_Tope").Rows
            '            If s = b("NApertura") Then
            '                Dim codm As String = b("CodMoneda")
            '                '==============================================================
            '                For Each m In Me.DataSetAperturaCaja1.Tables("moneda").Rows
            '                    If m("CodMoneda") = codm Then
            '                        dtt += b("Monto_Tope") * m("ValorVenta")
            '                        Exit For
            '                    End If
            '                Next
            '                '==============================================================
            '            End If
            '        Next

            '        For Each a In Me.DataSetAperturaCaja1.Tables("Denominacion_Moneda").Rows ' "aperturacaja.aperturacajaDenominacionesAperturas")
            '            Dim codm As String = a("CodMoneda")
            '            '================================================================
            '            For Each m In Me.DataSetAperturaCaja1.Tables("moneda").Rows
            '                If m("CodMoneda") = codm Then
            '                    tot += a("Total") * m("ValorVenta")
            '                    Exit For
            '                End If
            '            Next
            '            '================================================================
            '        Next

            '        'Evaluo si los datos que hay en detalle total\Tope coinciden con  los de detalle de denominacion
            '        If tot <> dtt Then
            '            MsgBox("Ingrese el detalle de las denominaciones correctamente", MsgBoxStyle.Exclamation, "Mensaje")
            '            Return False
            '        End If
            '        Return True

            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        Return False
            '    End Try
            'End Function



            'Function RegistarApertura() As Boolean
            '    If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
            '    Try
            '        'Apertura
            '        Me.AdapterAperturaCaja.InsertCommand.Transaction = Trans
            '        Me.AdapterAperturaCaja.UpdateCommand.Transaction = Trans
            '        Me.AdapterAperturaCaja.DeleteCommand.Transaction = Trans
            '        Me.AdapterAperturaCaja.SelectCommand.Transaction = Trans
            '        'Denominaciones
            '        Me.AdapterDenominacionesApertura.InsertCommand.Transaction = Trans
            '        Me.AdapterDenominacionesApertura.UpdateCommand.Transaction = Trans
            '        Me.AdapterDenominacionesApertura.DeleteCommand.Transaction = Trans
            '        Me.AdapterDenominacionesApertura.SelectCommand.Transaction = Trans
            '        'Tope
            '        Me.AdapterAperturaTotalTope.InsertCommand.Transaction = Trans
            '        Me.AdapterAperturaTotalTope.UpdateCommand.Transaction = Trans
            '        Me.AdapterAperturaTotalTope.DeleteCommand.Transaction = Trans
            '        Me.AdapterAperturaTotalTope.SelectCommand.Transaction = Trans

            '        Me.AdapterAperturaCaja.Update(Me.DataSetAperturaCaja1.aperturacaja)
            '        Me.AdapterDenominacionesApertura.Update(Me.DataSetAperturaCaja1.Apertura_Denominaciones)
            '        Me.AdapterAperturaTotalTope.Update(Me.DataSetAperturaCaja1.Apertura_Total_Tope)
            '        Me.DataSetAperturaCaja1.AcceptChanges()

            '        Trans.Commit()
            '        Return True
            '    Catch ex As Exception
            '        Trans.Rollback()
            '        MsgBox(ex.Message, MsgBoxStyle.Critical)
            '    End Try
            'End Function
        End Function

        Public Function Editar(id As Integer, area As Datos.Models.Area) As String
            Dim res As String = Me.db.EditarAreas(id, area)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If

            'Private Function Valida() As Boolean
            '    Try
            '        'Catidad Ingresada
            '        Dim tot As Decimal = 0
            '        'Total Detalle\Tope
            '        Dim dtt As Decimal = 0
            '        'Recorrera el DenominacionesApertura
            '        Dim a As DataRow
            '        'Recorrera el Adapter TotalTope
            '        Dim b As DataRow

            '        Dim s As String = Me.BindingContext(DataSetAperturaCaja1.aperturacaja).Current("NApertura")
            '        Dim id As String = ""

            '        'Recorrera los datos en la tabla moneda del adaptador que contiene los datos de moneda
            '        Dim m As DataRow

            '        For Each b In Me.DataSetAperturaCaja1.Tables("Apertura_Total_Tope").Rows
            '            If s = b("NApertura") Then
            '                Dim codm As String = b("CodMoneda")
            '                '==============================================================
            '                For Each m In Me.DataSetAperturaCaja1.Tables("moneda").Rows
            '                    If m("CodMoneda") = codm Then
            '                        dtt += b("Monto_Tope") * m("ValorVenta")
            '                        Exit For
            '                    End If
            '                Next
            '                '==============================================================
            '            End If
            '        Next

            '        For Each a In Me.DataSetAperturaCaja1.Tables("Denominacion_Moneda").Rows ' "aperturacaja.aperturacajaDenominacionesAperturas")
            '            Dim codm As String = a("CodMoneda")
            '            '================================================================
            '            For Each m In Me.DataSetAperturaCaja1.Tables("moneda").Rows
            '                If m("CodMoneda") = codm Then
            '                    tot += a("Total") * m("ValorVenta")
            '                    Exit For
            '                End If
            '            Next
            '            '================================================================
            '        Next

            '        'Evaluo si los datos que hay en detalle total\Tope coinciden con  los de detalle de denominacion
            '        If tot <> dtt Then
            '            MsgBox("Ingrese el detalle de las denominaciones correctamente", MsgBoxStyle.Exclamation, "Mensaje")
            '            Return False
            '        End If
            '        Return True

            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        Return False
            '    End Try
            'End Function



            'Function RegistarApertura() As Boolean
            '    If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
            '    Try
            '        'Apertura
            '        Me.AdapterAperturaCaja.InsertCommand.Transaction = Trans
            '        Me.AdapterAperturaCaja.UpdateCommand.Transaction = Trans
            '        Me.AdapterAperturaCaja.DeleteCommand.Transaction = Trans
            '        Me.AdapterAperturaCaja.SelectCommand.Transaction = Trans
            '        'Denominaciones
            '        Me.AdapterDenominacionesApertura.InsertCommand.Transaction = Trans
            '        Me.AdapterDenominacionesApertura.UpdateCommand.Transaction = Trans
            '        Me.AdapterDenominacionesApertura.DeleteCommand.Transaction = Trans
            '        Me.AdapterDenominacionesApertura.SelectCommand.Transaction = Trans
            '        'Tope
            '        Me.AdapterAperturaTotalTope.InsertCommand.Transaction = Trans
            '        Me.AdapterAperturaTotalTope.UpdateCommand.Transaction = Trans
            '        Me.AdapterAperturaTotalTope.DeleteCommand.Transaction = Trans
            '        Me.AdapterAperturaTotalTope.SelectCommand.Transaction = Trans

            '        Me.AdapterAperturaCaja.Update(Me.DataSetAperturaCaja1.aperturacaja)
            '        Me.AdapterDenominacionesApertura.Update(Me.DataSetAperturaCaja1.Apertura_Denominaciones)
            '        Me.AdapterAperturaTotalTope.Update(Me.DataSetAperturaCaja1.Apertura_Total_Tope)
            '        Me.DataSetAperturaCaja1.AcceptChanges()

            '        Trans.Commit()
            '        Return True
            '    Catch ex As Exception
            '        Trans.Rollback()
            '        MsgBox(ex.Message, MsgBoxStyle.Critical)
            '    End Try
            'End Function
        End Function

        Public Function Borrar(id As Long) As String
            Return Me.db.BorrarAreas(id)

            'Function Anular_Apertura()
            '    If MessageBox.Show("¿Desea anular la Apertura de caja?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            '        Me.RadioButton1.Checked = True
            '        Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja").Current("Estado") = "C"
            '        Me.BindingContext(Me.DataSetAperturaCaja1, "aperturacaja").EndCurrentEdit()
            '        RegistarApertura()
            '        MsgBox("Apertura Anulada", MsgBoxStyle.Information)
            '        Me.Limpiar()
            '    End If
            'End Function

        End Function

        Public Function Buscar(porId As Boolean, Filtro As String) As List(Of Datos.Models.Area)
            Dim datos As New List(Of Datos.Models.Area)
            datos = Me.db.ObtenerAreas(porId, Filtro)

            Dim Resultado As New List(Of Datos.Models.Area)
            For Each ar As Datos.Models.Area In datos
                Dim Area As New Datos.Models.Area
                Area.IdArea = ar.IdArea
                Area.Descripcion = ar.Descripcion
                Area.Observaciones = ar.Observaciones
                Area.IdSucursal = ar.IdSucursal

                For Each det As Datos.Models.AreaArticulo In Me.db.ObtenerAreasArticulo(Area.IdArea)
                    Dim Detalle As New Datos.Models.AreaArticulo
                    Detalle.IdAreaArticulo = det.IdAreaArticulo
                    Detalle.IdArea = det.IdArea
                    Detalle.Codigo = det.Codigo

                    Area.AreaArticulos.Add(Detalle)
                Next

                For Each det As Datos.Models.AreaEncargado In Me.db.ObtenerAreasEncargado(Area.IdArea)
                    Dim Detalle As New Datos.Models.AreaEncargado
                    Detalle.IdAreaEncargado = det.IdAreaEncargado
                    Detalle.IdArea = det.IdArea
                    Detalle.IdUsuario = det.IdUsuario

                    Area.AreaEncargados.Add(Detalle)
                Next

                Resultado.Add(Area)
            Next

            Return Resultado
        End Function


    End Class
End Namespace