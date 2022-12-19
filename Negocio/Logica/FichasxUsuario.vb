﻿Namespace Logica
    Public Class FichasxUsuario

        Private db As Datos.Class.FichasxUsuario

        Sub New()
            Me.db = New Datos.Class.FichasxUsuario
        End Sub

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.FichasxUsuario)
            Return Me.db.Buscar(porNombre, Filtro)
            'Datos.Models.FichasxUsuario
            'Datos.Models.FichasxUsuario

            'Private Sub CargarUsuario()
            '    Try
            '        Dim dt As New DataTable
            '        cFunciones.Llenar_Tabla_Generico("Select Id, IdUsuario, Usuario, Desde, Hasta, EnMostrador From FichasxUsuario", dt, CadenaConexionSeePOS)
            '        Me.viewDatos.Rows.Clear()
            '        Dim Index As Integer = 0
            '        For Each r As DataRow In dt.Rows
            '            Me.viewDatos.Rows.Add()
            '            Me.viewDatos.Item("cId", Index).Value = r.Item("Id")
            '            Me.viewDatos.Item("cIdUsuario", Index).Value = r.Item("IdUsuario")
            '            Me.viewDatos.Item("cUsuario", Index).Value = r.Item("Usuario")
            '            Me.viewDatos.Item("cDesde", Index).Value = r.Item("Desde")
            '            Me.viewDatos.Item("cHasta", Index).Value = r.Item("Hasta")
            '            Me.viewDatos.Item("cEnMostrador", Index).Value = r.Item("EnMostrador")
            '            Index += 1
            '        Next
            '    Catch ex As Exception
            '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Problemas al Obtener los Datos.")
            '    End Try
            'End Sub

        End Function

        Public Function Crear(fichasxusuario As Datos.Models.FichasxUsuario) As String
            Return Me.db.Crear(fichasxusuario)
            'Private Sub Registrar(_IdUsuario As String, _Nombre As String, _Desde As Decimal, _Hasta As Decimal, _EnMostrador As Integer)
            '    Try
            '        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '        db.AddParametro("@IdUsuario", _IdUsuario)
            '        db.AddParametro("@Nombre", _Nombre)
            '        db.AddParametro("@Desde", _Desde)
            '        db.AddParametro("@Hasta", _Hasta)
            '        db.AddParametro("@EnMostrador", _EnMostrador)
            '        db.Ejecutar("Insert into FichasxUsuario(IdUsuario, Usuario,Desde,Hasta, EnMostrador) Values(@IdUsuario, @Nombre, @Desde, @Hasta, @EnMostrador);", CommandType.Text)
            '        Me.CargarUsuario()
            '    Catch ex As Exception
            '        MsgBox(ex.Message, MsgBoxStyle.Critical, "No se puedo realizar la operacion.")
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
            'Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
            '    If Me.viewDatos.Rows.Count > 0 Then
            '        If MsgBox("Desea quitar los usuarios seleccionados.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion.") = MsgBoxResult.Yes Then
            '            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '            For Each r As DataGridViewRow In Me.viewDatos.SelectedRows
            '                db.Ejecutar("Delete from FichasxUsuario where Id = " & r.Cells("cId").Value, CommandType.Text)
            '            Next
            '            Me.CargarUsuario()
            '        End If
            '    End If
            'End Sub

        End Function


    End Class
End Namespace