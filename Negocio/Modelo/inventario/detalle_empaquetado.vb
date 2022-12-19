Namespace Modelo
    Public Class detalle_empaquetado
        'modelo usado por sistema de entregas
        Public Property id_venta_detalle As Integer
        Public Property Codarticulo As String
        Public Property Descripcion As String
        Public Property Cantidad As Decimal
        Public Property minutos As String
        Public Property Selección As Boolean
        Public Property codmarca As String
        Public Property Id_Factura As Integer
        Public Property Num_Factura As Integer
        Public Property devoluciones As Decimal
        Public Property anulado As Boolean
        Public Property nota_pantalla As String
    End Class
End Namespace