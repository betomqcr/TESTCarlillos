Imports Negocio.Utilidades
Namespace Logica
    Public Class Familia

        Private db As Datos.Class.Familia

        Sub New()
            Me.db = New Datos.Class.Familia
        End Sub

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.Familium)
            Dim datos As New List(Of Datos.Models.Familium)
            datos = Me.db.Buscar(porNombre, Filtro)

            Dim Resultado As New List(Of Datos.Models.Familium)
            For Each fam As Datos.Models.Familium In datos
                Dim Familia As New Datos.Models.Familium
                Familia.Codigo = fam.Codigo
                Familia.Descripcion = fam.Descripcion
                Familia.Observaciones = fam.Observaciones
                Familia.CuentaGra = fam.CuentaGra
                Familia.DescripcionGra = fam.DescripcionGra
                Familia.CuentaExe = fam.CuentaExe
                Familia.DescripcionExe = fam.DescripcionExe
                Familia.CuentaCosto = fam.CuentaCosto
                Familia.DescripcionCosto = fam.DescripcionCosto

                For Each subFam As Datos.Models.SubFamilia In Me.db.BuscarSubFamilia(fam.Codigo)
                    Dim SubFamilias As New Datos.Models.SubFamilia
                    SubFamilias.CodigoFamilia = subFam.CodigoFamilia
                    SubFamilias.SubCodigo = subFam.SubCodigo
                    SubFamilias.Codigo = subFam.Codigo
                    SubFamilias.Descripcion = subFam.Descripcion
                    SubFamilias.Observaciones = subFam.Observaciones
                    Familia.SubFamilia.Add(SubFamilias)
                Next

                Resultado.Add(Familia)
            Next

            Return Resultado
        End Function

        Public Function Crear(familia As Datos.Models.Familium) As String
            If estaVacio(familia.Descripcion) Or
                estaVacio(familia.CuentaGra) Or
                estaVacio(familia.CuentaExe) Or
                estaVacio(familia.CuentaCosto) Then
                'no pasa validacion datos vacios
            End If

            Return Me.db.Crear(familia)

            'Me.Adapter_Familias.Update(Me.DataSetFamilia1, "Familia")
            'Me.Adapter_Subfamilias.Update(Me.DataSetFamilia1, "SubFamilias")
            'Trans.Commit()
            'Me.DataSetFamilia1.AcceptChanges()
        End Function

        Public Function Editar(id As Long, familia As Datos.Models.Familium) As String
            If estaVacio(familia.Descripcion) Or
                estaVacio(familia.CuentaGra) Or
                estaVacio(familia.CuentaExe) Or
                estaVacio(familia.CuentaCosto) Then
                'no pasa validacion datos vacios

            End If

            Dim res As String = Me.db.Editar(id, familia)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
            'Me.Adapter_Familias.Update(Me.DataSetFamilia1, "Familia")
            'Me.Adapter_Subfamilias.Update(Me.DataSetFamilia1, "SubFamilias")
            'Trans.Commit()
            'Me.DataSetFamilia1.AcceptChanges()
        End Function

        Public Function Eliminar(id As Long) As String
            'valida que no exista productos relacionados

            Dim res As String = Me.db.Borrar(id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If

            'Cargo el codigo de la familia al que pertenecen las familias que se eliminaran
            'Dim strCodigoFamilia As String = Me.BindingContext(DataSetFamilia1, "Familia").Current("Codigo")
            'Dim strMensaje As String = conexion.DeleteRecords("SubFamilias", "CodigoFamilia =" & strCodigoFamilia, strModulo)

            'Me.BindingContext(Me.DataSetFamilia1, "Familia").RemoveAt(Me.BindingContext(Me.DataSetFamilia1, "Familia").Position)
            'Me.BindingContext(Me.DataSetFamilia1, "Familia").EndCurrentEdit()
            'Me.Adapter_Familias.Update(Me.DataSetFamilia1, "Familia")
        End Function

    End Class
End Namespace

