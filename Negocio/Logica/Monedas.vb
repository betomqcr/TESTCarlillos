Namespace Logica
    Public Class Monedas

        Private db As Datos.Class.Monedas

        Sub New()
            Me.db = New Datos.Class.Monedas
        End Sub

        Public Function Buscar(porDescripcion As Boolean, filtro As String) As List(Of Datos.Models.Moneda)
            Return Me.db.Buscar(porDescripcion, filtro)
        End Function

        Public Function Crear(moneda As Datos.Models.Moneda) As String
            Return Me.db.Crear(moneda)
            'Try
            '    BindingContext(DataSet, Tabla).EndCurrentEdit()
            '    Adaptador.Update(DataSet, Tabla)
            '    If RecargarAdatador Then Adaptador.Fill(DataSet, Tabla)
            '    If ActivarNuevo Then ToolBar1.Buttons(0).Text = "Nuevo" : ToolBar1.Buttons(0).ImageIndex = 0
            '    If VerMsg Then MsgBox("Los datos se actualizaron satisfactoriamente...", MsgBoxStyle.Information, "Atención...")
            'Catch eEndEdit As System.Exception
            '    System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            'End Try
        End Function

        Public Function Editar(id As Long, moneda As Datos.Models.Moneda) As String
            Dim res As String = Me.db.Editar(id, moneda)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
            'Try
            '    BindingContext(DataSet, Tabla).EndCurrentEdit()
            '    Adaptador.Update(DataSet, Tabla)
            '    If RecargarAdatador Then Adaptador.Fill(DataSet, Tabla)
            '    If ActivarNuevo Then ToolBar1.Buttons(0).Text = "Nuevo" : ToolBar1.Buttons(0).ImageIndex = 0
            '    If VerMsg Then MsgBox("Los datos se actualizaron satisfactoriamente...", MsgBoxStyle.Information, "Atención...")
            'Catch eEndEdit As System.Exception
            '    System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            'End Try
        End Function

        Public Function Eliminar(id As Long) As String
            Dim res As String = Me.db.Borrar(id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
            'BindingContext(DataSet, Tabla).RemoveAt(BindingContext(DataSet, Tabla).Position)
            'BindingContext(DataSet, Tabla).EndCurrentEdit()
            'Adaptador.Update(DataSet, Tabla)
            'If RecargarAdatador Then Adaptador.Update(DataSet, Tabla)
            'Adaptador.Fill(DataSet, Tabla)
        End Function



    End Class

End Namespace
