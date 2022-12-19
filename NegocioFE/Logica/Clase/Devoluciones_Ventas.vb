Namespace Logica
    Public Class Devoluciones_Ventas
        Private vista As New DatosFE.Class.Vistas
        Private db As New DatosFE.Class.DevolucionesVentas

        Public Function ObtenerEncabezadoXML(Devolucion As Long) As DatosFE.Models.ObtenerDevolucion43
            Return Me.vista.ObtenerDevolucionVenta43(Devolucion).FirstOrDefault()
        End Function

        Public Function ObtenerDetalleXML(Devolucion As Long) As List(Of DatosFE.Models.ObtenerDetallesDevolucion43)
            Return Me.vista.ObtenerDetalleDevolucionVenta43(Devolucion)
        End Function

        Public Function CambiarEstado(Devolucion As Long, Estado As String) As String
            Return Me.db.EditarEstadoDevolucionVenta(Devolucion, Estado)
        End Function

        Public Function ObtenerClave(Devolucion As Long) As String
            Return Me.db.ObtenerClaveDevolucion(Devolucion)
        End Function

        Public Function ObtenerConsecutivo(Devolucion As Long) As String
            Return Me.db.ObtenerNumeroConsecutivoDevolucion(Devolucion)
        End Function
    End Class
End Namespace

