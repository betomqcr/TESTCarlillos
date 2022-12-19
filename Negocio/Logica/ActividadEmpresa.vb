Namespace Logica
    Public Class ActividadEmpresa

        Public Function Buscar() As List(Of Modelo.actividadempresa)

            'Private Sub CargarActividades()
            '    Dim dt As New DataTable
            '    cFunciones.Llenar_Tabla_Generico("select Actividad from actividadEmpresa", dt, CadenaConexionSeePOS)
            '    For Each r As DataRow In dt.Rows
            '        If Me.PrimeraActividad = "" Then
            '            Me.PrimeraActividad = r.Item("Actividad")
            '        End If
            '        Me.cCodigoActividad.Items.Add(r.Item("Actividad"))
            '    Next
            'End Sub

        End Function

    End Class
End Namespace