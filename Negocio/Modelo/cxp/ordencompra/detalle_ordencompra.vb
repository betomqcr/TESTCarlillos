Namespace Modelo
    Public Class detalle_ordencompra
        Public Property Id As Integer
        Public Property Orden As Integer
        Public Property Codigo As Integer
        Public Property Descripcion As String
        Public Property CostoUnitario As Decimal
        Public Property Cantidad As Decimal
        Public Property TotalCompra As Decimal
        Public Property Porc_Descuento As Decimal
        Public Property Descuento As Decimal
        Public Property Porc_Impuesto As Decimal
        Public Property impuesto As Decimal
        Public Property OtrosCargos As Decimal
        Public Property Monto_Flete As Decimal
        Public Property Costo As Decimal
        Public Property Gravado As Decimal
        Public Property Exento As Decimal
        Public Property Vendidos As Decimal
        Public Property Exist_Actual As Decimal
    End Class
End Namespace
