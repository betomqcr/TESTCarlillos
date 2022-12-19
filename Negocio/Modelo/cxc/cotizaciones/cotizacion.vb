Namespace Modelo
    Public Class cotizacion
        Public Property Cotizacion As Long
        Public Property Fecha As DateTime
        Public Property Cod_Cliente As String
        Public Property Nombre_Cliente As String
        Public Property Contacto As String
        Public Property Validez As Integer
        Public Property TiempoEntrega As Integer
        Public Property Contado As Boolean
        Public Property Credito As Boolean
        Public Property Anulado As Boolean
        Public Property Dias As Integer
        Public Property Observaciones As String
        Public Property SubTotalGravada As Decimal
        Public Property SubTotalExento As Decimal
        Public Property Descuento As Decimal
        Public Property PagoImpuesto As Decimal
        Public Property Total As Decimal
        Public Property Cedula As String
        Public Property CodMoneda As Integer
        Public Property MonedaNombre As String
        Public Property SubTotal As Decimal
        Public Property Tipo_Cambio As Decimal
        Public Property Imp_Venta As Decimal
        Public Property Transporte As Decimal
        Public Property Venta As Boolean
        Public Property Exonerar As Boolean
        Public Property confirmada As Boolean
        Public Property confirmada_por As String
        Public Property EstadoActual As String
        Public Property ObservacionEstado As String
        Public Property Id_Factura As Integer
        Public Property Telefono As String
        Public Property TipoCedula As String
        Public Property CedulaCliente As String
        Public Property Cotizacion_Detalle As New Modelo.cotizacion_detalle

    End Class
End Namespace

