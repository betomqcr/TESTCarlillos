Namespace Logica
    Public Class PreTomaGeneral

        Private db As Datos.Class.PreTomaGeneral

        Sub New()
            Me.db = New Datos.Class.PreTomaGeneral
        End Sub

        Public Function Crear(pretoma As Datos.Models.PreTomaGeneral) As String
            Return Me.db.Crear(pretoma)
        End Function

        Public Function Editar(id As Decimal, pretoma As Datos.Models.PreTomaGeneral) As String
            Dim res As String = Me.db.Editar(id, pretoma)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.PreTomaGeneral)
            Dim datos As New List(Of Datos.Models.PreTomaGeneral)
            datos = db.Buscar(porNombre, Filtro)

            Dim Resultado As New List(Of Datos.Models.PreTomaGeneral)
            For Each toma As Datos.Models.PreTomaGeneral In datos
                Dim preToma As New Datos.Models.PreTomaGeneral
                preToma.IdPreToma = toma.IdPreToma
                preToma.Fecha = toma.Fecha
                preToma.Anulado = toma.Anulado
                preToma.Aplicado = toma.Aplicado
                preToma.Encargado = toma.Encargado

                For Each detalle As Datos.Models.PreTomaGeneralDetalle In Me.db.BuscarDetalle(preToma.IdPreToma)
                    Dim preTomaDetalle As New Datos.Models.PreTomaGeneralDetalle
                    preTomaDetalle.IdPreTomaDetalle = detalle.IdPreTomaDetalle
                    preTomaDetalle.IdPreToma = detalle.IdPreToma
                    preTomaDetalle.Codigo = detalle.Codigo
                    preTomaDetalle.CodArticulo = detalle.CodArticulo
                    preTomaDetalle.Barras = detalle.Barras
                    preTomaDetalle.Descripcion = detalle.Descripcion
                    preTomaDetalle.Costo = detalle.Costo
                    preTomaDetalle.Existencia = detalle.Existencia
                    preTomaDetalle.Toma = detalle.Toma
                    preTomaDetalle.Diferencia = detalle.Diferencia
                    preTomaDetalle.Contado = detalle.Contado

                    preToma.PreTomaGeneralDetalles.Add(preTomaDetalle)
                Next

                Resultado.Add(preToma)
            Next

            Return Resultado
        End Function

    End Class
End Namespace

