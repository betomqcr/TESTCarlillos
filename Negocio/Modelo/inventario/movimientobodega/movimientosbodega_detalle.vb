Namespace Modelo
    Public Class movimientosbodega_detalle
        Public Property Id_Detalle As Integer
        Public Property Boleta_Movimiento As Long
        Public Property Codigo As String
        Public Property CodArticulo As String
        Public Property Descripcion As String
        Public Property Cantidad As Decimal
        Public Property Tipo_Entrada As Boolean
        Public Property Tipo_Salida As Boolean
        Public Property Numero As String
        Public Property ExistenciaForzada As Decimal
        Public Property ExistVeteForzada As Decimal
        Public Property Serie As New List(Of serie) 'las series que salen o que entran
    End Class
End Namespace

