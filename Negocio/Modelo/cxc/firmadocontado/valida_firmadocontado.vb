Namespace Modelo
    Public Class valida_firmadocontado
        Public Property ID_VALIDA_FIRMADOCONTADO As Integer
        Public Property CONTADO As Boolean
        Public Property PVE As Boolean
        Public Property MONTO_MAXIMO As Integer
        Public Property EXIGE_NOMBRE As Boolean
        Public Property MAXIMO_CLIENTE As Integer
        Public Property MAXIMO_AUTORIZA As Integer
        Public Property MAXIMO_RETIRA As Integer
        Public Property Exepcion_FirmadoContado As New List(Of Modelo.exepcion_firmadocontado)
    End Class
End Namespace