Namespace Modelo
    Public Class mensajereceptor
        Public Property Id As Integer
        Public Property Clave As String
        Public Property NumeroCedulaEmisor As String
        Public Property FechaEmisionDoc As Date
        Public Property Mensaje As String
        Public Property MontoTotalImpuesto As Decimal
        Public Property TotalFactura As Decimal
        Public Property Estado As String
        Public Property Consecutivo As String
        Public Property Proveedor As String
        Public Property Moneda As String
        Public Property FechaComprobante As Date
        Public Property PDF As String
        Public Property DetalleMensaje As String
        Public Property CodigoActividad As String
        Public Property CondicionImpuesto As String
        Public Property MontoTotalImpuestoAcreditar As Decimal
        Public Property MontoTotalDeGastoAplicable As Decimal
    End Class
End Namespace