Namespace Modelo
    Public Class articulos_ventas_devueltos
        Public Property Consecutivo As Long
        Public Property Devolucion As Long
        Public Property Codigo As Long
        Public Property Descripcion As String
        Public Property Cantidad As Decimal
        Public Property CantVet As Decimal
        Public Property CantBod As Decimal
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
        Public Property Id_Art_Venta As Integer
        Public Property id_articulo_V As String
        Public Property devuelto As Boolean
        Public Property empaquetado As Boolean
        Public Property recibido As Boolean
    End Class
End Namespace

