Namespace Logica
    Public Class Ventas
        Private vista As New DatosFE.Class.Vistas
        Private db As New DatosFE.Class.Ventas

        Public Function ObtenerEncabezadoXML(Id_Factura As Long) As DatosFE.Models.ObtenerFacturas43
            Return Me.vista.ObtenerFacturas43(Id_Factura).FirstOrDefault()
        End Function

        Public Function ObtenerDetalleXML(Id_Factura As Long) As List(Of DatosFE.Models.ObtenerDetalleFactura43)
            Return Me.vista.ObtenerDetalleFacturas43(Id_Factura)
        End Function

        Public Function CambiarEstado(Id_Factura As Long, Estado As String) As String
            Return Me.db.EditarEstadoFactura(Id_Factura, Estado)
        End Function

        Public Function ObtenerClave(Id_Factura As Long) As String
            Return Me.db.ObtenerClaveFactura(Id_Factura)
        End Function

        Public Function ObtenerConsecutivo(Id_Factura As Long) As String
            Return Me.db.ObtenerNumeroConsecutivoFactura(Id_Factura)
        End Function

    End Class
End Namespace
