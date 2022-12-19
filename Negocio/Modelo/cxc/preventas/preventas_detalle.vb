Namespace Modelo
    Public Class preventas_detalle
        Public Property id_venta_detalle As Integer
        Public Property Id_Factura As Integer
        Public Property Codigo As Integer
        Public Property CodArticulo As String
        Public Property Descripcion As String
        Public Property Cantidad As Decimal
        Public Property Precio_Costo As Decimal
        Public Property Precio_Base As Decimal
        Public Property Precio_Flete As Decimal
        Public Property Precio_Otros As Decimal
        Public Property Precio_Unit As Decimal
        Public Property Descuento As Decimal
        Public Property Monto_Descuento As Decimal
        Public Property Impuesto As Decimal
        Public Property Monto_Impuesto As Decimal
        Public Property SubtotalGravado As Decimal
        Public Property SubTotalExcento As Decimal
        Public Property SubTotal As Decimal
        Public Property Devoluciones As Decimal
        Public Property Numero_Entrega As Decimal
        Public Property Max_Descuento As Decimal
        Public Property Tipo_Cambio_ValorCompra As Decimal
        Public Property Cod_MonedaVenta As Integer
        Public Property Lote As String
        Public Property CantVet As Decimal
        Public Property CantBod As Decimal
        Public Property Disminuye As Decimal
        Public Property empaquetado As Boolean
        Public Property nota_pantalla As String
        Public Property id_bodega As Integer
        Public Property regalias As Decimal
        Public Property CostoReal As Decimal
        Public Property IdTipoExoneracion As Integer
        Public Property NumeroDocumento As String
        Public Property FechaEmision As Date
        Public Property PorcentajeCompra As Integer
        Public Property Entregado As Boolean
        Public Property Entregados As Integer
        Public Property IdSerie As Integer

    End Class
End Namespace

