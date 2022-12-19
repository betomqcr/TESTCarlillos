Imports Negocio.Utilidades
Namespace Logica
    Public Class ValidaFirmadoContado

        Private db As Datos.Class.ValidaFirmadoContado

        Sub New()
            Me.db = New Datos.Class.ValidaFirmadoContado
        End Sub

        Public Function Buscar() As List(Of Datos.Models.ValidaFirmadocontado)
            Dim datos As New List(Of Datos.Models.ValidaFirmadocontado)
            datos = Me.db.Buscar()

            Dim Resultado As New List(Of Datos.Models.ValidaFirmadocontado)
            For Each valida As Datos.Models.ValidaFirmadocontado In datos
                Dim validaFirmadoContado As New Datos.Models.ValidaFirmadocontado
                validaFirmadoContado.IdValidaFirmadocontado = valida.IdValidaFirmadocontado
                validaFirmadoContado.Contado = valida.Contado
                validaFirmadoContado.Pve = valida.Pve
                validaFirmadoContado.MontoMaximo = valida.MontoMaximo
                validaFirmadoContado.ExigeNombre = valida.ExigeNombre
                validaFirmadoContado.MaximoCliente = valida.MaximoCliente
                validaFirmadoContado.MaximoAutoriza = valida.MaximoAutoriza
                validaFirmadoContado.MaximoRetira = valida.MaximoRetira

                For Each row As Datos.Models.ExepcionFirmadocontado In Me.db.Execion_FirmadoContado(valida.IdValidaFirmadocontado)
                    Dim exepcionFirmadoContado As New Datos.Models.ExepcionFirmadocontado
                    exepcionFirmadoContado.IdExepcionFirmadocontado = row.IdExepcionFirmadocontado
                    exepcionFirmadoContado.IdValidaFirmadocontado = row.IdValidaFirmadocontado
                    exepcionFirmadoContado.CEDULA = row.Cedula
                    exepcionFirmadoContado.NOMBRE = row.Nombre
                    validaFirmadoContado.ExepcionFirmadocontados.Add(exepcionFirmadoContado)
                Next

                Resultado.Add(validaFirmadoContado)
            Next

            Return Resultado
        End Function

        Public Function Crear(Valida As Datos.Models.ValidaFirmadocontado) As String
            Return Me.db.Crear(Valida)
        End Function

        Public Function Editar(id As Long, Valida As Datos.Models.ValidaFirmadocontado) As String
            Dim res As String = Me.db.Editar(id, Valida)
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

