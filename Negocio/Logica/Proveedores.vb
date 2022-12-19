Namespace Logica
    Public Class Proveedores

        Private db As Datos.Class.Proveedores

        Sub New()
            Me.db = New Datos.Class.Proveedores
        End Sub

        Public Function Buscar(porNombre As Boolean, filtro As String) As List(Of Datos.Models.Proveedore)
            Return Me.db.Buscar(porNombre, filtro)
        End Function

        Public Function Crear(proveedor As Datos.Models.Proveedore) As String
            Return Me.db.Crear(proveedor)
        End Function

        Public Function Editar(id As Integer, proveedor As Datos.Models.Proveedore) As String
            Dim res As String = Me.db.Editar(id, proveedor)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

        Public Function Eliminar(id As Integer) As String
            Dim res As String = Me.db.Borrar(id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

        'Public Function ComprasPendientes(codigoProv As String) As List(Of Datos.Models.compras)

        '    '    Public Shared Function BuscarFacturas_Proveedor(ByVal CodigoProv As Integer, Optional ByVal Conexion As String = "") As DataTable
        '    '    Dim cnn As SqlConnection = Nothing
        '    '    Dim dt As New DataTable
        '    '    ' Dentro de un Try/Catch por si se produce un error
        '    '    Try
        '    '        ' Obtenemos la cadena de conexión adecuada
        '    '        Dim sConn As String = IIf(Conexion = "", CadenaConexionSeePOS, Conexion)
        '    '        cnn = New SqlConnection(sConn)
        '    '        cnn.Open()
        '    '        ' Creamos el comando para la consulta
        '    '        Dim cmd As SqlCommand = New SqlCommand
        '    '        Dim sel As String =
        '    '    "SELECT Factura, Fecha, TotalFactura, Cod_MonedaCompra FROM compras WHERE (FacturaCancelado = 0) AND (TipoCompra = 'CRE') AND (CodigoProv = " & CodigoProv & ")" ' AND (dbo.SaldoFacturaCompra(GETDATE(), Factura, CodigoProv) <> 0)"
        '    '        cmd.CommandText = sel
        '    '        cmd.Connection = cnn
        '    '        cmd.CommandType = CommandType.Text
        '    '        cmd.CommandTimeout = 90
        '    '        ' Los parámetros usados en la cadena de la consulta 
        '    '        cmd.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.Int))
        '    '        cmd.Parameters("@Codigo").Value = CodigoProv
        '    '        ' Creamos el dataAdapter y asignamos el comando de selección
        '    '        Dim da As New SqlDataAdapter
        '    '        da.SelectCommand = cmd
        '    '        ' Llenamos la tabla

        '    '        da.Fill(dt)

        '    '    Catch ex As System.Exception
        '    '        ' Si hay error, devolvemos un valor nulo.
        '    '        MsgBox(ex.ToString)
        '    '        Return Nothing
        '    '    Finally
        '    '        ' Por si se produce un error,
        '    '        ' comprobamos si en realidad el objeto Connection está iniciado,
        '    '        ' de ser así, lo cerramos.
        '    '        If Not cnn Is Nothing Then
        '    '            cnn.Close()
        '    '        End If
        '    '    End Try

        '    '    Return dt ' Devolvemos el objeto DataTable con los datos de la consulta
        '    'End Function

        'End Function

    End Class

End Namespace
