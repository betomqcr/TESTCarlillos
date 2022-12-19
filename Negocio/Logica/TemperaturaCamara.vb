Namespace Logica
    Public Class TemperaturaCamara


        Private db As Datos.Class.TemperaturaCamara

        Sub New()
            Me.db = New Datos.Class.TemperaturaCamara
        End Sub

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.TemperaturaCamara)
            Return Me.db.Buscar(porNombre, Filtro)

            'Datos.Models.TemperaturaCamara
            'Datos.Models.TemperaturaCamara

            'Private Sub CargarRegistrosTemperatura()
            '    Dim dt As New DataTable
            '    cFunciones.Llenar_Tabla_Generico("Select * from viewTemperaturaCamara order by fecha desc", dt, CadenaConexionSeePOS)
            '    Me.viewDatos.DataSource = dt
            '    Me.viewDatos.Columns("Id").Visible = False
            '    Me.viewDatos.Columns("Id_Usuario").Visible = False
            '    Me.viewDatos.Columns("Fecha").DefaultCellStyle.Format = "dd/MM/yyyy"
            '    Me.viewDatos.Columns("Fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '    Me.viewDatos.Columns("Temperatura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            'End Sub

        End Function

        Public Function Crear(temperaturacamara As Datos.Models.TemperaturaCamara) As String
            Return Me.db.Crear(temperaturacamara)
            'Private Sub AgregarNuevoRegistro()
            '    Dim Fecha As Date
            '    Dim Id_Usuario As String
            '    Dim Temperatura As String

            '    Fecha = Me.dtpFecha.Value
            '    Id_Usuario = Me.Id_UsuarioCreo
            '    Temperatura = Me.txtTemperatura.Text

            '    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '    If Me.Id_RegistroTemperaturaCamara = 0 Then
            '        If Me.PasaValidaRegistro = True Then
            '            db.Ejecutar("Insert into temperaturacamara(Fecha,Id_Usuario,Temperatura, Horario) Values('" & Fecha & "','" & Id_Usuario & "','" & Temperatura & "', '" & Me.cboHorario.Text & "')", CommandType.Text)
            '        End If
            '    Else
            '        db.Ejecutar("Update temperaturacamara set fecha = '" & Fecha & "', Temperatura = '" & Temperatura & "' Where Id = " & Me.Id_RegistroTemperaturaCamara, CommandType.Text)
            '    End If
            '    Me.CargarRegistrosTemperatura()
            'End Sub

        End Function

        Public Function Eliminar(id As Decimal) As String
            Dim res As String = Me.db.Borrar(id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

        Public Function Editar(id As Decimal, temperaturacamara As Datos.Models.TemperaturaCamara) As String
            Dim res As String = Me.db.Editar(id, temperaturacamara)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
            'Private Sub AgregarNuevoRegistro()
            '    Dim Fecha As Date
            '    Dim Id_Usuario As String
            '    Dim Temperatura As String

            '    Fecha = Me.dtpFecha.Value
            '    Id_Usuario = Me.Id_UsuarioCreo
            '    Temperatura = Me.txtTemperatura.Text

            '    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '    If Me.Id_RegistroTemperaturaCamara = 0 Then
            '        If Me.PasaValidaRegistro = True Then
            '            db.Ejecutar("Insert into temperaturacamara(Fecha,Id_Usuario,Temperatura, Horario) Values('" & Fecha & "','" & Id_Usuario & "','" & Temperatura & "', '" & Me.cboHorario.Text & "')", CommandType.Text)
            '        End If
            '    Else
            '        db.Ejecutar("Update temperaturacamara set fecha = '" & Fecha & "', Temperatura = '" & Temperatura & "' Where Id = " & Me.Id_RegistroTemperaturaCamara, CommandType.Text)
            '    End If
            '    Me.CargarRegistrosTemperatura()
            'End Sub

        End Function

    End Class
End Namespace