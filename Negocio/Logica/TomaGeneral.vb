Imports Negocio.Utilidades
Namespace Logica
    Public Class TomaGeneral

        Private db As Datos.Class.TomaGeneral

        Sub New()
            Me.db = New Datos.Class.TomaGeneral
        End Sub

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.TomaGeneral)
            Dim datos As New List(Of Datos.Models.TomaGeneral)
            datos = Me.db.Buscar(porNombre, Filtro)

            Dim Resultado As New List(Of Datos.Models.TomaGeneral)
            For Each toma As Datos.Models.TomaGeneral In datos
                Dim TomaGeneral As New Datos.Models.TomaGeneral
                TomaGeneral.IdToma = toma.IdToma
                TomaGeneral.Fecha = toma.Fecha
                TomaGeneral.Anulado = toma.Anulado
                TomaGeneral.Ajustado = toma.Ajustado
                TomaGeneral.NumeroAjuste = toma.NumeroAjuste

                For Each det As Datos.Models.TomaGeneralDetalle In Me.db.BuscarDetalle(TomaGeneral.IdToma)
                    Dim Detalle As New Datos.Models.TomaGeneralDetalle
                    Detalle.IdTomaDetalle = det.IdTomaDetalle
                    Detalle.IdToma = det.IdToma
                    Detalle.Codigo = det.Codigo
                    Detalle.CodArticulo = det.CodArticulo
                    Detalle.Barras = det.Barras
                    Detalle.Descripcion = det.Descripcion
                    Detalle.Costo = det.Costo
                    Detalle.Existencia = det.Existencia
                    Detalle.Toma = det.Toma
                    Detalle.Diferencia = det.Diferencia
                    Detalle.Contado = det.Contado

                    TomaGeneral.TomaGeneralDetalles.Add(Detalle)
                Next

                Resultado.Add(TomaGeneral)
            Next

            Return Resultado
        End Function

        Public Function Crear(Toma As Datos.Models.TomaGeneral) As String
            Return Me.db.Crear(Toma)
        End Function

        Public Function Editar(id As Long, Toma As Datos.Models.TomaGeneral) As String
            Dim res As String = Me.db.Editar(id, Toma)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

        Public Function Eliminar(id As Long) As String
            Dim res As String = Me.db.Borrar(id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

    End Class
End Namespace

