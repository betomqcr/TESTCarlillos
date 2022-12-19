Namespace Logica
    Public Class CondicionImpuesto

        'solo para consultas, no crea ni edita ni elimina

        Public Function Buscar() As List(Of Modelo.condicionimpuesto)

            'Private Sub CargarCondiciones()
            '    Dim dt As New DataTable
            '    cFunciones.Llenar_Tabla_Generico("select Condicion from CondicionImpuesto", dt, CadenaConexionSeePOS)
            '    For Each r As DataRow In dt.Rows
            '        If Me.PrimeraCondicion = "" Then
            '            Me.PrimeraCondicion = r.Item("Condicion")
            '        End If
            '        Me.cCondicionImpuesto.Items.Add(r.Item("Condicion"))
            '    Next
            'End Sub

        End Function

    End Class
End Namespace