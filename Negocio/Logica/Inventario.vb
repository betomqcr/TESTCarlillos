Namespace Logica
    Public Class Inventario

        Private db As Datos.Class.Inventario

        Sub New()
            Me.db = New Datos.Class.Inventario
        End Sub

        Public Function Buscar(verInhabilitados As Boolean,
                                         soloConBarras As Boolean,
                                        inicioCampo As Boolean,
                                         cualQuierParte As Boolean,
                                         campoFiltro As String,
                                         descripcion As String) As List(Of Datos.Models.Inventario)
            'buscador de inventario

            'If Me.Filtro_Inicio_del_Campo.Checked = True Then
            '    If CampoFiltro = "Barras" Then
            '        CadenaWhere = " WHERE " & CampoFiltro & " lIKE '" & Descripcion & "%' or barras2 LIKE '" & Descripcion & "%' or barras3 LIKE '" & Descripcion & "%'" & IIf(Me.CheckBoxInHabilitados.Checked = True, "", " and Inhabilitado = 0")
            '    Else
            '        CadenaWhere = " WHERE " & CampoFiltro & " lIKE '" & Descripcion & "%'" & IIf(Me.CheckBoxInHabilitados.Checked = True, "", " and Inhabilitado = 0")
            '    End If

            'ElseIf Me.Filtro_Cualquier_Parte_del_Campo.Checked = True Then
            '    If CampoFiltro = "Barras" Then
            '        CadenaWhere = " WHERE " & CampoFiltro & " lIKE '%" & Descripcion & "%' or barras2 LIKE '%" & Descripcion & "%' or barras3 LIKE '%" & Descripcion & "%'" & IIf(Me.CheckBoxInHabilitados.Checked = True, "", " and Inhabilitado = 0")
            '    Else
            '        CadenaWhere = " WHERE " & CampoFiltro & " lIKE '%" & Descripcion & "%'" & IIf(Me.CheckBoxInHabilitados.Checked = True, "", " and Inhabilitado = 0")
            '    End If
            'Else
            '    CadenaWhere = "" & IIf(Me.CheckBoxInHabilitados.Checked = True, "", " Inhabilitado = 0")
            'End If

            'If Me.SoloSinBarras = True Then
            '    If CadenaWhere = "" Then
            '        CadenaWhere = "Where (Muestra = 1)"
            '    Else
            '        CadenaWhere += " And (Muestra = 1)"
            '    End If
            'End If

            'Try

            '    If Me.IdPuntoVenta > 0 Then
            '        Dim dt As New DataTable
            '        cFunciones.Llenar_Tabla_Generico("select * from PuntodeVenta where IdPuntoVenta = " & Me.IdPuntoVenta, dt, CadenaConexionSeguridad)
            '        Me.SqlConnection.ConnectionString = "Data Source=" & Me.Servidor & "; Initial Catalog=" & dt.Rows(0).Item("BasedeDatos") & "; Integrated Security=true;"
            '        Me.SqlDataAdapter.SelectCommand.Connection.ConnectionString = Me.SqlConnection.ConnectionString
            '    End If

            '    Me.DataSetCatalogoInventario.Clear()
            '    If Me.CheckBox1.Checked = True Then
            '        Me.SqlDataAdapter.SelectCommand.CommandText = "SELECT Codigo, Cod_Articulo, Barras, Descripcion, Marca, Simbolo, Precio_A, ValorCompra, PrecioFinalMAG As PrecioFinal, Existencia, Bodega, Ubicacion, Inhabilitado, receta,prestamo, Consignacion FROM CatalogoInventario" & CadenaWhere
            '    Else
            '        Me.SqlDataAdapter.SelectCommand.CommandText = "SELECT Codigo, Cod_Articulo, Barras, Descripcion, Marca, Simbolo, Precio_A, ValorCompra, PrecioFinal, Existencia, Bodega, Ubicacion, Inhabilitado, receta,prestamo, Consignacion FROM CatalogoInventario" & CadenaWhere
            '    End If
            '    Me.SqlDataAdapter.Fill(Me.DataSetCatalogoInventario, "CatalogoInventario")
            '    Me.pone_color()
            '    'Me.GridControl.DataSource = Me.DataSetCatalogoInventario.CatalogoInventario.DefaultView
            'Catch ex As SystemException
            '    MsgBox(ex.Message)
            'End Try
        End Function

        Public Function ObtenerInventario(codigo As String) As Datos.Models.Inventario
            Return Me.db.Buscar(True, codigo).FirstOrDefault()
        End Function

        Public Function Eliminar(id As Long) As String
            Return Me.db.Borrar(id)
            'Dim Items(1) As Integer
            'Dim Cx As New Conexion
            'Items(0) = Cx.SlqExecuteScalar(Cx.Conectar, "SELECT COUNT(Ventas_Detalle.Cantidad) FROM Ventas_Detalle INNER JOIN  Ventas ON Ventas_Detalle.Id_Factura = Ventas.Id WHERE (Ventas.Anulado = 0) and codigo = " & Me.TxtCodigo.Text & "GROUP BY Ventas_Detalle.Codigo")
            'Items(1) = Cx.SlqExecuteScalar(Cx.Conectar, "SELECT COUNT(Cantidad) FROM articulos_comprados GROUP BY Codigo HAVING Codigo = " & Me.TxtCodigo.Text)

            'If Items(0) = 0 And Items(1) = 0 Then
            '    If MsgBox("Esta seguro que desea proceder con la ELIMINACION del artículo seleccionado...", MsgBoxStyle.YesNo, "Atención...") = MsgBoxResult.Yes Then
            '        Me.BindingContext(Me.DataSetInventario, "Inventario").RemoveAt(Me.BindingContext(Me.DataSetInventario, "Inventario").Position)
            '        Me.BindingContext(Me.DataSetInventario, "Inventario").EndCurrentEdit()
            '        Me.AdapterInventario.Update(Me.DataSetInventario, "Inventario")

            '        Me.DataSetInventario.Inventario2.Clear()
            '        Me.Adaptador_Inventraio_AUX.Fill(Me.DataSetInventario, "Inventario2")

            '        MsgBox("Se ha eliminado el registro del inventario.", MsgBoxStyle.Information, "Atención...")
            '        Me.NuevoRegistros()
            '    End If
            'Else
            '    MsgBox("Existen movimientos registrados para para el artículo " & Me.TxtDescripcion.Text & vbCrLf & "Cantidad de items Vendidos.. " & Items(0) & vbCrLf & "Cantidad de Items Comprados.. " & Items(1), MsgBoxStyle.Critical, "Atención...")
            'End If
            'Cx.DesConectar(Cx.sQlconexion)

        End Function

        Public Function Crear(inventario As Datos.Models.Inventario) As String
            Return Me.db.Crear(inventario)
            '**********************************
            'hay que validar que el codigo y las barras no se dupliquen

            'If txtCod_Articulo.Text = "" Then
            '    MsgBox("Debe de ingresar el código del artículo!", MsgBoxStyle.Information)
            '    Exit Sub
            'End If
            'If Me.TxtCantidad.Text = "" And Me.ChkOtro.Checked = True Then
            '    Dim cnat As Integer
            '    cnat = CInt(Me.TxtCantidad.Text)
            '    If cnat = 0 Then
            '        MsgBox("Debe de ingresar la Cantidad por presentación en Kilogramos!", MsgBoxStyle.Information)
            '    End If
            '    Exit Sub
            'End If

            'If Me.TxtCodOtro.Text = "" And Me.ChkOtro.Checked = True Then
            '    MsgBox("Debe de ingresar el producto a descargar!", MsgBoxStyle.Information)
            '    Exit Sub
            'End If

            'If CDbl(Me.TxtCosto.Text) = 0 Or CDbl(Me.TxtCosto.Text) < 0 Then
            '    MsgBox("El costo del artículo no puede ser 0, corrigalo", MsgBoxStyle.Information)
            '    Exit Sub
            'End If

            'Dim strExiste As String = buscarCodigoArticulo()
            'If strExiste <> "" Then
            '    MsgBox("El Codigo del artículo asignado pertenece a :[" & strExiste & "] introduzca otro codigo!!")
            '    Exit Sub
            'End If

            'If ckVerCodBarraInv.Checked = True Then
            '    '-------------------------------------------------------------------------------------------------
            '    'Variable que indica si se ha presionado el boton de nuevo
            '    If strNuevo <> "" Then
            '        Dim strExistencia As String = buscarCodigoBarra()
            '        If strExistencia <> "" Then
            '            MsgBox("El Codigo asignado pertenece a :[" & strExistencia & "] introduzca otro codigo!!")
            '            Exit Sub
            '        End If
            '    End If

            '    '-Si se realiza una actualizacion la aplicacion realiza una busqueda del Codigo de Barras--------------------

            '    strActualiza = buscarCodigoBarra2()

            '    If strActualiza <> "" Then
            '        If strActualiza <> "Igual" Then
            '            MsgBox("El Codigo de Barras asignado pertenece a :[" & strActualiza & "] introduzca otro codigo!!")
            '            Exit Sub
            '        End If
            '    End If

            '    '------------------------------------------------------------------------------------------------------------
            'End If
            ''********************************************************************************************
            ''LFCHG 07122006 
            ''DESCRIPCION DEL CAMBIO:
            ''ELIMINACION DE LA VARIABLE NUEVO
            ''VALIDACION EN CASO DE HABER UN CAMBIO EN LA TABLA INVENTARIO
            ''INCLUIR EN UNA TRASSACCION EL PROCEDIMIENTO DE REGISTAR

            ''If Me.ToolBarNuevo.Text = "Cancelar" Then
            'Me.BindingContext(Me.DataSetInventario, "Bitacora").AddNew()
            'Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Tabla") = "INVENTARIO"
            'Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Campo_Clave") = Me.TxtCodigo.Text
            'Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("DescripcionCampo") = Me.TxtDescripcion.Text
            ''Se especifica que tipo de accion es si es un nuevo articulo o una actualizacion'
            'If Me.ToolBarNuevo.Text = "Cancelar" Then
            '    Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Accion") = "ARTICULO AGREGADO"
            'Else
            '    Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Accion") = "ARTICULO ACTUALIZADO"
            'End If
            'Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Usuario") = Me.txtNombreUsuario.Text
            'Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Fecha") = Now
            'Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Costo") = CDbl(Me.TxtCosto.Text)
            'Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("VentaA") = CDbl(Me.TxtPrecioVenta_A.Text)
            'Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("VentaB") = CDbl(Me.TxtPrecioVenta_B.Text)
            'Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("VentaC") = CDbl(Me.TxtPrecioVenta_C.Text)
            'Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("VentaD") = CDbl(Me.TxtPrecioVenta_D.Text)
            'Me.BindingContext(Me.DataSetInventario, "Bitacora").EndCurrentEdit()
            ''Else

            'If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            'Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
            'Try
            '    Me.AdapterInventario.InsertCommand.Transaction = Trans
            '    Me.AdapterInventario.SelectCommand.Transaction = Trans
            '    Me.AdapterInventario.DeleteCommand.Transaction = Trans
            '    Me.AdapterInventario.UpdateCommand.Transaction = Trans
            '    Me.AdapterBitacora.SelectCommand.Transaction = Trans
            '    Me.AdapterBitacora.InsertCommand.Transaction = Trans
            '    Me.AdapterBitacora.DeleteCommand.Transaction = Trans
            '    Me.AdapterBitacora.UpdateCommand.Transaction = Trans
            '    '**************************************************************************
            '    Try
            '        Me.BindingContext(Me.DataSetInventario, "Inventario").Current("Subfamilia") = ComboBoxFamilia.SelectedValue.ToString
            '        Me.BindingContext(Me.DataSetInventario, "Inventario").Current("serie") = CheckBox2.Checked
            '    Catch ex As Exception
            '        MsgBox("Problemas al asignar SubFamilia, Favor revisar", MsgBoxStyle.Information, Text)
            '        Me.ComboBoxFamilia.Focus()
            '        Exit Sub
            '    End Try

            '    Try
            '        Me.BindingContext(Me.DataSetInventario, "Inventario").Current("CodMarca") = ComboBoxMarca.SelectedValue.ToString
            '    Catch ex As Exception
            '        MsgBox("Problemas al asignar Marca, Favor revisar", MsgBoxStyle.Information, Text)
            '        Me.ComboBoxMarca.Focus()
            '        Exit Sub
            '    End Try

            '    Me.BindingContext(Me.DataSetInventario, "Inventario").Current("Proveedor") = CInt(cmboxProveedor.SelectedValue)
            '    If Me.Ck_Consignacion.Checked = False Then
            '        Me.BindingContext(Me.DataSetInventario, "Inventario").Current("id_bodega") = 0
            '    End If

            '    Me.BindingContext(Me.DataSetInventario, "Inventario").Position -= 1
            '    Me.BindingContext(Me.DataSetInventario, "Inventario").Position += 1
            '    Me.BindingContext(Me.DataSetInventario, "Inventario").Current("Precio_Sugerido") = 0
            '    Me.BindingContext(Me.DataSetInventario, "Inventario").Current("SugeridoIV") = 0

            '    '**************************************************************************

            '    Me.AdapterInventario.Update(Me.DataSetInventario, "Inventario")
            '    Me.AdapterBitacora.Update(Me.DataSetInventario.Bitacora)
            '    Trans.Commit()
            '    Me.GuardarValidaExistencia(Me.TxtCodigo.Text)
            '    Me.RegistrarProductoRelacionados(Me.TxtCodigo.Text)
            '    Me.DataSetInventario.AcceptChanges()
            'Catch ex As Exception
            '    Trans.Rollback()
            '    If Me.ToolBarNuevo.Text = "Cancelar" Then
            '        MsgBox("Error al intentar Guardar el articulo en inventario" & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            '    Else
            '        MsgBox("Error al intentar Actualizar el articulo en inventario" & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            '    End If

            'End Try


            '****************************
            'crear tambien las series y articulosrelacionados

        End Function

        Public Function Editar(id As Long, inventario As Datos.Models.Inventario) As String
            Dim res As String = Me.db.Editar(id, inventario)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
            '**********************************
            'hay que validar que el codigo y las barras no se dupliquen


            'If txtCod_Articulo.Text = "" Then
            '    MsgBox("Debe de ingresar el código del artículo!", MsgBoxStyle.Information)
            '    Exit Sub
            'End If
            'If Me.TxtCantidad.Text = "" And Me.ChkOtro.Checked = True Then
            '    Dim cnat As Integer
            '    cnat = CInt(Me.TxtCantidad.Text)
            '    If cnat = 0 Then
            '        MsgBox("Debe de ingresar la Cantidad por presentación en Kilogramos!", MsgBoxStyle.Information)
            '    End If
            '    Exit Sub
            'End If

            'If Me.TxtCodOtro.Text = "" And Me.ChkOtro.Checked = True Then
            '    MsgBox("Debe de ingresar el producto a descargar!", MsgBoxStyle.Information)
            '    Exit Sub
            'End If

            'If CDbl(Me.TxtCosto.Text) = 0 Or CDbl(Me.TxtCosto.Text) < 0 Then
            '    MsgBox("El costo del artículo no puede ser 0, corrigalo", MsgBoxStyle.Information)
            '    Exit Sub
            'End If

            'Dim strExiste As String = buscarCodigoArticulo()
            'If strExiste <> "" Then
            '    MsgBox("El Codigo del artículo asignado pertenece a :[" & strExiste & "] introduzca otro codigo!!")
            '    Exit Sub
            'End If

            'If ckVerCodBarraInv.Checked = True Then
            '    '-------------------------------------------------------------------------------------------------
            '    'Variable que indica si se ha presionado el boton de nuevo
            '    If strNuevo <> "" Then
            '        Dim strExistencia As String = buscarCodigoBarra()
            '        If strExistencia <> "" Then
            '            MsgBox("El Codigo asignado pertenece a :[" & strExistencia & "] introduzca otro codigo!!")
            '            Exit Sub
            '        End If
            '    End If

            '    '-Si se realiza una actualizacion la aplicacion realiza una busqueda del Codigo de Barras--------------------

            '    strActualiza = buscarCodigoBarra2()

            '    If strActualiza <> "" Then
            '        If strActualiza <> "Igual" Then
            '            MsgBox("El Codigo de Barras asignado pertenece a :[" & strActualiza & "] introduzca otro codigo!!")
            '            Exit Sub
            '        End If
            '    End If

            '    '------------------------------------------------------------------------------------------------------------
            'End If
            ''********************************************************************************************
            ''LFCHG 07122006 
            ''DESCRIPCION DEL CAMBIO:
            ''ELIMINACION DE LA VARIABLE NUEVO
            ''VALIDACION EN CASO DE HABER UN CAMBIO EN LA TABLA INVENTARIO
            ''INCLUIR EN UNA TRASSACCION EL PROCEDIMIENTO DE REGISTAR

            ''If Me.ToolBarNuevo.Text = "Cancelar" Then
            'Me.BindingContext(Me.DataSetInventario, "Bitacora").AddNew()
            'Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Tabla") = "INVENTARIO"
            'Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Campo_Clave") = Me.TxtCodigo.Text
            'Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("DescripcionCampo") = Me.TxtDescripcion.Text
            ''Se especifica que tipo de accion es si es un nuevo articulo o una actualizacion'
            'If Me.ToolBarNuevo.Text = "Cancelar" Then
            '    Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Accion") = "ARTICULO AGREGADO"
            'Else
            '    Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Accion") = "ARTICULO ACTUALIZADO"
            'End If
            'Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Usuario") = Me.txtNombreUsuario.Text
            'Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Fecha") = Now
            'Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("Costo") = CDbl(Me.TxtCosto.Text)
            'Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("VentaA") = CDbl(Me.TxtPrecioVenta_A.Text)
            'Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("VentaB") = CDbl(Me.TxtPrecioVenta_B.Text)
            'Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("VentaC") = CDbl(Me.TxtPrecioVenta_C.Text)
            'Me.BindingContext(Me.DataSetInventario, "Bitacora").Current("VentaD") = CDbl(Me.TxtPrecioVenta_D.Text)
            'Me.BindingContext(Me.DataSetInventario, "Bitacora").EndCurrentEdit()
            ''Else

            'If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            'Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
            'Try
            '    Me.AdapterInventario.InsertCommand.Transaction = Trans
            '    Me.AdapterInventario.SelectCommand.Transaction = Trans
            '    Me.AdapterInventario.DeleteCommand.Transaction = Trans
            '    Me.AdapterInventario.UpdateCommand.Transaction = Trans
            '    Me.AdapterBitacora.SelectCommand.Transaction = Trans
            '    Me.AdapterBitacora.InsertCommand.Transaction = Trans
            '    Me.AdapterBitacora.DeleteCommand.Transaction = Trans
            '    Me.AdapterBitacora.UpdateCommand.Transaction = Trans
            '    '**************************************************************************
            '    Try
            '        Me.BindingContext(Me.DataSetInventario, "Inventario").Current("Subfamilia") = ComboBoxFamilia.SelectedValue.ToString
            '        Me.BindingContext(Me.DataSetInventario, "Inventario").Current("serie") = CheckBox2.Checked
            '    Catch ex As Exception
            '        MsgBox("Problemas al asignar SubFamilia, Favor revisar", MsgBoxStyle.Information, Text)
            '        Me.ComboBoxFamilia.Focus()
            '        Exit Sub
            '    End Try

            '    Try
            '        Me.BindingContext(Me.DataSetInventario, "Inventario").Current("CodMarca") = ComboBoxMarca.SelectedValue.ToString
            '    Catch ex As Exception
            '        MsgBox("Problemas al asignar Marca, Favor revisar", MsgBoxStyle.Information, Text)
            '        Me.ComboBoxMarca.Focus()
            '        Exit Sub
            '    End Try

            '    Me.BindingContext(Me.DataSetInventario, "Inventario").Current("Proveedor") = CInt(cmboxProveedor.SelectedValue)
            '    If Me.Ck_Consignacion.Checked = False Then
            '        Me.BindingContext(Me.DataSetInventario, "Inventario").Current("id_bodega") = 0
            '    End If

            '    Me.BindingContext(Me.DataSetInventario, "Inventario").Position -= 1
            '    Me.BindingContext(Me.DataSetInventario, "Inventario").Position += 1
            '    Me.BindingContext(Me.DataSetInventario, "Inventario").Current("Precio_Sugerido") = 0
            '    Me.BindingContext(Me.DataSetInventario, "Inventario").Current("SugeridoIV") = 0

            '    '**************************************************************************

            '    Me.AdapterInventario.Update(Me.DataSetInventario, "Inventario")
            '    Me.AdapterBitacora.Update(Me.DataSetInventario.Bitacora)
            '    Trans.Commit()
            '    Me.GuardarValidaExistencia(Me.TxtCodigo.Text)
            '    Me.RegistrarProductoRelacionados(Me.TxtCodigo.Text)
            '    Me.DataSetInventario.AcceptChanges()
            'Catch ex As Exception
            '    Trans.Rollback()
            '    If Me.ToolBarNuevo.Text = "Cancelar" Then
            '        MsgBox("Error al intentar Guardar el articulo en inventario" & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            '    Else
            '        MsgBox("Error al intentar Actualizar el articulo en inventario" & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            '    End If

            'End Try


            '*******************************************************************************
            'articulos relacionados
            '**************************** elimina todo y luego lo vuelve a registrar

            'Private Sub RegistrarProductoRelacionados(_Id As String)
            '    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '    Dim Id As String = _Id

            '    db.Ejecutar("Delete from ArticulosRelacionados where CodigoPrincipal = " & Id, CommandType.Text)
            '    Dim Codigo, CodArticulo, Descripcion, Cantidad As String
            '    For Each f As DataGridViewRow In Me.viewRelacionados.Rows
            '        Codigo = f.Cells("cCodigo").Value
            '        CodArticulo = f.Cells("cCodArticulo").Value
            '        Descripcion = f.Cells("cDescripcion").Value
            '        Cantidad = f.Cells("cCantidad").Value
            '        db.Ejecutar("Insert into ArticulosRelacionados(CodigoPrincipal, Codigo, CodArticulo, Descripcion, Cantidad) Values(" & Id & ", " & Codigo & ", '" & CodArticulo & "', '" & Descripcion & "', " & Cantidad & ")", CommandType.Text)
            '    Next

            'End Sub

            '****************************************
            'las series pocas veces se registran desde inventario
            'series:
            '           -la mayoria de las veces se registran en la entrada de inventario (se puede crear una funcion aparte)
            '           -se actualizan desde el triger de la venta


        End Function

        Public Sub CrearSerie(serie As Datos.Models.Serie)
            'este metodo se usaria en las entradas de bodega

            'Try
            '    Me.BindingContext(Me.DataSetInventario, "serie").AddNew()
            '    Me.BindingContext(Me.DataSetInventario, "serie").Current("codigo") = Me.TxtCodigo.Text
            '    Me.BindingContext(Me.DataSetInventario, "serie").Current("vendido") = False
            '    Me.BindingContext(Me.DataSetInventario, "serie").Current("factura") = 0
            '    Me.BindingContext(Me.DataSetInventario, "serie").Current("serie") = Me.txtserie.Text

            '    Me.BindingContext(Me.DataSetInventario, "serie").EndCurrentEdit()
            '    Me.BindingContext(Me.DataSetInventario, "serie").AddNew()
            '    Me.BindingContext(Me.DataSetInventario, "serie").CancelCurrentEdit()
            '    Me.txtserie.Text = ""

            'Catch ex As SystemException
            '    MsgBox(ex.Message)
            'End Try


            'Me.adserie.Update(Me.DataSetInventario.serie)
        End Sub

        Public Sub EliminaSerie(serie As Datos.Models.Serie)
            'este metodo se usaria en las salidas de bodega

            'Me.adserie.Update(Me.DataSetInventario.serie)
        End Sub



    End Class

End Namespace
