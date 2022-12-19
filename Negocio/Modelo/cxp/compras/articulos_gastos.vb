Namespace Modelo
    Public Class articulos_gastos
        Public Property Id_ArticuloComprados As Integer
        Public Property IdCompra As Integer
        Public Property Descripcion As String
        Public Property Base As Decimal
        Public Property Monto_Flete As Decimal
        Public Property OtrosCargos As Decimal
        Public Property Costo As Decimal
        Public Property Cantidad As Decimal
        Public Property Gravado As Decimal
        Public Property Exento As Decimal
        Public Property Descuento_P As Decimal
        Public Property Descuento As Decimal
        Public Property Impuesto_P As Decimal
        Public Property Impuesto As Decimal
        Public Property Total As Decimal
        Public Property Devoluciones As Decimal
        Public Property NuevoCostoBase As Decimal
        Public Property CuentaContable As String
        Public Property CodTipoCompra As Integer
        Public Property DescTipoCompra As String
    End Class
End Namespace