Namespace Modelo
    Public Class compras
        Public Property Id_Compra As Long
        Public Property Factura As Decimal
        Public Property CodigoProv As Integer
        Public Property SubTotalGravado As Decimal
        Public Property SubTotalExento As Decimal
        Public Property Descuento As Decimal
        Public Property Impuesto As Decimal
        Public Property TotalFactura As Decimal
        Public Property Fecha As DateTime
        Public Property Vence As DateTime
        Public Property FechaIngreso As DateTime
        Public Property MotivoGasto As String
        Public Property Compra As Boolean
        Public Property Contabilizado As Boolean
        Public Property Consignacion As Boolean
        Public Property Asiento As Decimal
        Public Property ContaInve As Boolean
        Public Property AsientoInve As Decimal
        Public Property TipoCompra As Char
        Public Property CedulaUsuario As String
        Public Property Cod_MonedaCompra As Integer
        Public Property FacturaCancelado As Boolean
        Public Property Gasto As Boolean
        Public Property TipoCambio As Decimal
        Public Property CambioImpuesto As Decimal
        Public Property Taller As Boolean
        Public Property Mascotas As Boolean
        Public Property num_orden As Decimal
        Public Property FEC As Boolean
        Public Property CodigoActividad As String
        Public Property EnviadoDGT As Boolean
        Public Property EstadoDGT As String
        Public Property ConsecutivoDGT As String
        Public Property ClaveDGT As String
        Public Property Trans As Boolean
        Public Property NumTrans As String
        Public Property Prepagada As Boolean
        Public Property Articulos_Comprados As New List(Of Modelo.articulos_comprados)
        Public Property Articulos_Gastos As New List(Of Modelo.articulos_gastos)
    End Class
End Namespace

