Namespace Logica
    Public Class Denominacion_Moneda

        Private db As Datos.Class.DenominacionMoneda

        Sub New()
            Me.db = New Datos.Class.DenominacionMoneda
        End Sub

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.DenominacionMonedum)
            Return Me.db.Buscar(porNombre, Filtro)
        End Function

        Public Function Crear(denominacion_moneda As Datos.Models.DenominacionMonedum) As String
            Return Me.db.Crear(denominacion_moneda)
            'Function Registrar()
            '    Dim resp As Integer

            '    If Validar() Then
            '        resp = MessageBox.Show("¿Deseas Guardar los cambios?", "SeeSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            '        If resp = 6 Then
            '            Try
            '                Me.BindingContext(Me.DataSetConfiguracionMoneda1, "Denominacion_Moneda").Current("Tipo") = ComboBox2.Text
            '                Me.BindingContext(Me.DataSetConfiguracionMoneda1, "Denominacion_Moneda").EndCurrentEdit()
            '                Me.AdapterDenominacion.Update(Me.DataSetConfiguracionMoneda1, "Denominacion_Moneda")
            '                'Para boton Nuevo
            '                Me.ToolBar1.Buttons(0).Text = "Nuevo"
            '                Me.ToolBar1.Buttons(0).ImageIndex = 0
            '                'Para boton Acualizar
            '                Me.ToolBar1.Buttons(3).Enabled = False
            '                'Para boton Editar
            '                Me.ToolBarExcel.Text = "Editar"
            '                Me.ToolBarExcel.ImageIndex = 5
            '                Me.Inabilitar()

            '            Catch eEndEdit As System.Data.NoNullAllowedException
            '                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            '            End Try
            '        End If

            '    Else
            '        MsgBox("Debes Ingresar Campos....", MsgBoxStyle.Information, "Atención...")
            '    End If
            'End Function

        End Function

        Public Function Editar(id As Long, denominacion_moneda As Datos.Models.DenominacionMonedum) As String
            Dim res As String = Me.db.Editar(id, denominacion_moneda)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
            'Function Registrar()
            '    Dim resp As Integer

            '    If Validar() Then
            '        resp = MessageBox.Show("¿Deseas Guardar los cambios?", "SeeSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            '        If resp = 6 Then
            '            Try
            '                Me.BindingContext(Me.DataSetConfiguracionMoneda1, "Denominacion_Moneda").Current("Tipo") = ComboBox2.Text
            '                Me.BindingContext(Me.DataSetConfiguracionMoneda1, "Denominacion_Moneda").EndCurrentEdit()
            '                Me.AdapterDenominacion.Update(Me.DataSetConfiguracionMoneda1, "Denominacion_Moneda")
            '                'Para boton Nuevo
            '                Me.ToolBar1.Buttons(0).Text = "Nuevo"
            '                Me.ToolBar1.Buttons(0).ImageIndex = 0
            '                'Para boton Acualizar
            '                Me.ToolBar1.Buttons(3).Enabled = False
            '                'Para boton Editar
            '                Me.ToolBarExcel.Text = "Editar"
            '                Me.ToolBarExcel.ImageIndex = 5
            '                Me.Inabilitar()

            '            Catch eEndEdit As System.Data.NoNullAllowedException
            '                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            '            End Try
            '        End If

            '    Else
            '        MsgBox("Debes Ingresar Campos....", MsgBoxStyle.Information, "Atención...")
            '    End If
            'End Function

        End Function

        Public Function Eliminar(id As Long) As String
            'igual que crear y editar
            Dim res As String = Me.db.Borrar(id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

    End Class
End Namespace