Namespace Logica
    Public Class Rifa

        Private db As Datos.Class.Rifa

        Sub New()
            Me.db = New Datos.Class.Rifa
        End Sub

        Public Function Crear(rifa As Datos.Models.Rifa) As String
            Return Me.db.Crear(rifa)
            'Datos.Models.Rifa
            'Datos.Models.Rifa

            '    Function Registrar()
            '    Try
            '        Me.BindingContext(Me.Dsrifa1.rifa).EndCurrentEdit()
            '        Me.adapte_rifa.Update(Me.Dsrifa1.rifa)
            '        MsgBox("Los datos fueron ingresados correctamente")
            '    Catch ex As Exception
            '        System.Windows.Forms.MessageBox.Show(ex.Message)
            '    End Try
            'End Function

            'Private Sub Guardar_Proveedores(ByVal _IdRifa As String)
            '    Dim db As New GestioDatos()
            '    db.Ejecuta("delete from Rifa_Detalle where IdRifa = " & _IdRifa)

            '    For Each r As DataGridViewRow In Me.viewProveedores.Rows
            '        db.Ejecuta("Insert into Rifa_Detalle(IdRifa,IdProveedor,Nombre) values(" & _IdRifa & ", " & r.Cells(0).Value & ", '" & r.Cells(1).Value & "')")
            '    Next
            'End Sub

        End Function

        Public Function Editar(id As Long, rifa As Datos.Models.Rifa) As String
            Dim res As String = Me.db.Editar(id, rifa)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
            '    Function Registrar()
            '    Try
            '        Me.BindingContext(Me.Dsrifa1.rifa).EndCurrentEdit()
            '        Me.adapte_rifa.Update(Me.Dsrifa1.rifa)
            '        MsgBox("Los datos fueron ingresados correctamente")
            '    Catch ex As Exception
            '        System.Windows.Forms.MessageBox.Show(ex.Message)
            '    End Try
            'End Function

            'Private Sub Guardar_Proveedores(ByVal _IdRifa As String)
            '    Dim db As New GestioDatos()
            '    db.Ejecuta("delete from Rifa_Detalle where IdRifa = " & _IdRifa)

            '    For Each r As DataGridViewRow In Me.viewProveedores.Rows
            '        db.Ejecuta("Insert into Rifa_Detalle(IdRifa,IdProveedor,Nombre) values(" & _IdRifa & ", " & r.Cells(0).Value & ", '" & r.Cells(1).Value & "')")
            '    Next
            'End Sub

        End Function

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.Rifa)
            Return Me.db.Buscar(porNombre, Filtro)
            'Sub Buscar_rifa()
            '    Try
            '        Dim Fx As New cFunciones
            '        Dim valor As String
            '        Dim pos As Integer
            '        Dim vista As DataView

            '        valor = Fx.BuscarDatos("Select id,descripcion from rifa", "Rifas", "Buscar rifa...", Me.SqlConnection1.ConnectionString)

            '        If valor = "" Then
            '            Exit Sub
            '        Else
            '            vista = Me.Dsrifa1.rifa.DefaultView
            '            vista.Sort = "id"
            '            pos = vista.Find(CDbl(valor))
            '            Me.BindingContext(Me.Dsrifa1, "rifa").Position = pos
            '            Me.Cargar_Proveedores(Me.BindingContext(Me.Dsrifa1, "rifa").Current("Id"))
            '        End If
            '        Me.gp.Enabled = True
            '    Catch ex As SystemException
            '        MsgBox(ex.Message)
            '    End Try

            'End Sub

        End Function

        Public Function Eliminar(id As Long) As String
            Dim res As String = Me.db.Borrar(id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
            'Private Sub Eliminar()
            '    Try
            '        Dim rs As SqlDataReader
            '        If Me.BindingContext(Me.Dsrifa1.rifa).Count > 0 Then

            '            'Evaluo si las subfamilias estan asociadas a un articulo 
            '            Dim strCodigoMarca As String = Me.BindingContext(Me.Dsrifa1, "rifa").Current("CodMarca")
            '            'Habro la conexion 
            '            sqlConexion = CConexion.Conectar(strModulo)
            '            'Realizo la busqueda en la base de datos
            '            rs = CConexion.GetRecorset(sqlConexion, "SELECT id FROM Inventario WHERE CodMarca = '" & strCodigoMarca & "'")
            '            'Evaluo si encontro registros dentro de la tabla inventario
            '            If rs.Read Then
            '                MsgBox("No se puede eliminar esta Marca por que existe articulos en el inventario que pertenecen a esta")
            '                rs.Close()
            '                CConexion.DesConectar(sqlConexion)
            '                Exit Sub
            '            End If
            '            'Si no encontro registros eliminara el registro actual
            '            Me.EliminarDatos(Me.adapte_rifa, Me.Dsrifa1, Me.Dsrifa1.rifa.ToString)
            '        End If
            '        rs.Close()
            '        CConexion.DesConectar(sqlConexion)
            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '    End Try

            'End Sub

        End Function

    End Class
End Namespace