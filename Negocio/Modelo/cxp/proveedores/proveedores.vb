Namespace Modelo
    Public Class proveedores
        Public Property CodigoProv As Integer
        Public Property Cedula As String
        Public Property Nombre As String
        Public Property Contacto As String
        Public Property Telefono_Cont As String
        Public Property Observaciones As String
        Public Property Telefono1 As String
        Public Property Telefono2 As String
        Public Property Fax1 As String
        Public Property Fax2 As String
        Public Property Email As String
        Public Property Direccion As String
        Public Property MontoCredito As Decimal
        Public Property Plazo As Integer
        Public Property CostoTotal As Boolean
        Public Property ImpIncluido As Boolean
        Public Property PedidosMes As Integer
        Public Property Utilidad_Inventario As Decimal
        Public Property Utilidad_Fija As Boolean
        Public Property CuentaContable As String
        Public Property DescripcionCuentaContable As String
        Public Property Actualizado As Boolean
        Public Property Inhabilitado As Boolean
        Public Property FEC As Boolean
        Public Property TipoProveedor As String
        Public Property Id_Provincia As Integer
        Public Property Id_Canton As Integer
        Public Property Id_Distrito As Integer
        Public Property OtrasSenas As String
        Public Property CodigoActividad As String
        Public Property CorreoElectronico As String
        Public Property Serie As Boolean
        Public Property Bloqueado As Boolean
        Public Property Cuentas_Bancarias_Proveedor As cuentas_bancarias_proveedor
    End Class
End Namespace

