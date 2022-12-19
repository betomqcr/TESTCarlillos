Namespace Modelo
    Public Class inventario

        Public Property Codigo As Integer
        Public Property Cod_Articulo As String
        Public Property Barras As String
        Public Property Descripcion As String
        Public Property PresentaCant As Decimal
        Public Property CodPresentacion As Integer
        Public Property CodMarca As Integer
        Public Property SubFamilia As String
        Public Property Minima As Decimal
        Public Property PuntoMedio As Decimal
        Public Property Maxima As Decimal
        Public Property Existencia As Decimal
        Public Property SubUbicacion As String
        Public Property Observaciones As String
        Public Property MonedaCosto As Integer
        Public Property PrecioBase As Decimal
        Public Property Fletes As Decimal
        Public Property OtrosCargos As Decimal
        Public Property Costo As Decimal
        Public Property MonedaVenta As Integer
        Public Property IVenta As Decimal
        Public Property Precio_A As Decimal
        Public Property Precio_B As Decimal
        Public Property Precio_C As Decimal
        Public Property Precio_D As Decimal
        Public Property Precio_Promo As Decimal
        Public Property Promo_Activa As Boolean
        Public Property Promo_Inicio As Date
        Public Property Promo_Finaliza As Date
        Public Property Max_Comision As Decimal
        Public Property Max_Descuento As Decimal
        'Public Property Imagen As image
        Public Property FechaIngreso As DateTime
        Public Property Servicio As Boolean
        Public Property Inhabilitado As Boolean
        Public Property Proveedor As Integer
        Public Property Precio_Sugerido As Decimal
        Public Property SugeridoIV As Decimal
        Public Property PreguntaPrecio As Boolean
        Public Property Lote As Boolean
        Public Property Consignacion As Boolean
        Public Property Id_Bodega As Integer
        Public Property ExistenciaBodega As Decimal
        Public Property MAX_Inventario As Decimal
        Public Property MAX_Bodega As Decimal
        Public Property CantidadDescarga As Decimal
        Public Property CodigoDescarga As String
        Public Property DescargaOtro As Boolean
        Public Property Cod_PresentOtro As Integer
        Public Property CantidadPresentOtro As Decimal
        Public Property ExistenciaForzada As Decimal
        Public Property bloqueado As Boolean
        Public Property pantalla As Boolean
        Public Property clinica As Boolean
        Public Property mascotas As Boolean
        Public Property receta As Boolean
        Public Property peces As Boolean
        Public Property taller As Boolean
        Public Property barras2 As String
        Public Property barras3 As String
        Public Property Apartado As Decimal
        Public Property promo3x1 As Boolean
        Public Property orden As Boolean
        Public Property bonificado As Boolean
        Public Property encargado As String
        'Public Property serie As Integer
        Public Property armamento As Boolean
        Public Property tienda As Boolean
        Public Property prestamo As Decimal
        Public Property maquinaria As Boolean
        Public Property productos_organicos As Boolean
        Public Property rifa As Integer
        Public Property PromoCON As Boolean
        Public Property PromoCRE As Boolean
        Public Property CostoReal As Decimal
        Public Property ValidaExistencia As Boolean
        Public Property Actualizado As Boolean
        Public Property FechaActualizacion As Date
        Public Property Id_Impuesto As Integer
        Public Property ActivarBodega2 As Boolean
        Public Property ExistenciaBodega2 As Decimal
        Public Property EnToma As Boolean
        Public Property UsaGalon As Boolean
        Public Property ApicarDescuentoTarjeta As Boolean
        Public Property SoloContado As Boolean
        Public Property SoloConExistencia As Boolean
        Public Property MAG As Boolean
        Public Property SinDecimal As Boolean
        Public Property CODCABYS As String
        Public Property CodigoPrestamo As Integer
        Public Property Muestra As Boolean
        Public Property SoloUsoInterno As Boolean

        Public Property Serie As New List(Of serie)
        Public Property ArticulosRelacionados As New List(Of articulosrelacionados)

    End Class

End Namespace
