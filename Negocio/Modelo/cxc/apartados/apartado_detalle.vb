Namespace Modelo
    Public Class apartado_detalle
        Public Property Id_detalle As Long
        Public Property Id_Apartado As Long
        Public Property Codigo As String
        Public Property Descripcion As String
        Public Property Cantidad As Integer
        Public Property Precio_Costo As Decimal
        Public Property Precio_Base As Decimal
        Public Property Precio_Flete As Decimal
        Public Property Precio_Otros As Decimal
        Public Property Precio_Unit As Decimal
        Public Property Impuesto As Decimal
        Public Property Monto_Impuesto As Decimal
        Public Property SubtotalGravado As Decimal
        Public Property SubTotalExcento As Decimal
        Public Property SubTotal As Decimal
        Public Property Monto_descuento As Decimal
        Public Property Descuento As Decimal
        Public Property Max_Descuento As Decimal
        Public Property Tipo_Cambio_ValorCompra As Decimal
        Public Property Cod_MonedaVenta As Integer
        Public Property IdBodega As Long
        Public Property cod_articulo As String

    End Class
End Namespace

