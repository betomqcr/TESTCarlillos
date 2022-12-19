Namespace Modelo
    Public Class pretomageneral
        Public Property IdPreToma As Integer
        Public Property Fecha As Date
        Public Property Anulado As Boolean
        Public Property Aplicado As Boolean
        Public Property Encargado As String
        Public Property PreTomaGeneralDetalle As New List(Of Modelo.pretomageneraldetalle)
    End Class
End Namespace