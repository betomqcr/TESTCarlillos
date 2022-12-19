Namespace Modelo
    Public Class aperturacaja
        Public Property NApertura As Integer
        Public Property Fecha As Date
        Public Property Nombre As String
        Public Property Estado As String
        Public Property Observaciones As String
        Public Property Anulado As Boolean
        Public Property Cedula As String
        Public Property Num_Caja As Long
        Public Property Apertura_Total_Tope As New Modelo.apertura_total_tope
        Public Property apertura_denominaciones As New List(Of Modelo.apertura_denominaciones)
    End Class

    Public Class apertura_total_tope
        Public Property id_total_tope As Integer
        Public Property NApertura As Integer
        Public Property CodMoneda As Integer
        Public Property Monto_Tope As Decimal
        Public Property MonedaNombre As String
    End Class

    Public Class apertura_denominaciones
        Public Property Id As Long
        Public Property Id_Apertura As Integer
        Public Property Id_Denominacion As Integer
        Public Property Monto As Decimal
        Public Property Cantidad As Decimal
    End Class

End Namespace

