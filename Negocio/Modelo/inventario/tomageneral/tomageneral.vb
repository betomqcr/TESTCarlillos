Namespace Modelo
    Public Class tomageneral
        Public Property IdToma As Integer
        Public Property Fecha As Date
        Public Property Anulado As Boolean
        Public Property Ajustado As Boolean
        Public Property NumeroAjuste As Integer
        Public Property TomaGeneralDetalle As New List(Of Modelo.tomageneraldetalle)
    End Class
End Namespace