Namespace Logica
    Public Class ArqueoCajas

        Private db As Datos.Class.ArqueosCajas

        Sub New()
            db = New Datos.Class.ArqueosCajas
        End Sub

        Public Function Buscar(porId As Boolean, Filtro As String) As List(Of Datos.Models.ArqueoCaja)
            Dim datos As New List(Of Datos.Models.ArqueoCaja)
            datos = Me.db.ObtenerArqueosCajas(porId, Filtro)

            Dim Resultado As New List(Of Datos.Models.ArqueoCaja)
            For Each arq As Datos.Models.ArqueoCaja In datos
                Dim Arqueo As New Datos.Models.ArqueoCaja
                Arqueo.Id = arq.Id
                Arqueo.EfectivoColones = arq.EfectivoColones
                Arqueo.EfectivoDolares = arq.EfectivoDolares
                Arqueo.TarjetaColones = arq.TarjetaColones
                Arqueo.TarjetaDolares = arq.TarjetaDolares
                Arqueo.Cheques = arq.Cheques
                Arqueo.ChequesDol = arq.ChequesDol
                Arqueo.DepositoCol = arq.DepositoCol
                Arqueo.DepositoDol = arq.DepositoDol
                Arqueo.Total = arq.Total
                Arqueo.IdApertura = arq.IdApertura
                Arqueo.Fecha = arq.Fecha
                Arqueo.Cajero = arq.Cajero
                Arqueo.Anulado = arq.Anulado
                Arqueo.TipoCambioD = arq.TipoCambioD
                Arqueo.Observaciones = arq.Observaciones
                Arqueo.TarjetaSistema = arq.TarjetaSistema
                Arqueo.OtrasTarjetas = arq.OtrasTarjetas


                For Each det As Datos.Models.ArqueoEfectivo In Me.db.ObtenerArqueosEfectivo(Arqueo.Id)
                    Dim Detalle As New Datos.Models.ArqueoEfectivo
                    Detalle.Id = det.Id
                    Detalle.IdArqueo = det.IdArqueo
                    Detalle.IdDenominacion = det.IdDenominacion
                    Detalle.Monto = det.Monto
                    Detalle.Cantidad = det.Cantidad

                    Arqueo.ArqueoEfectivos.Add(Detalle)
                Next

                For Each det As Datos.Models.ArqueoDeposito In Me.db.ObtenerArqueosDeposito(Arqueo.Id)
                    Dim Detalle As New Datos.Models.ArqueoDeposito
                    Detalle.Id = det.Id
                    Detalle.IdArqueo = det.IdArqueo
                    Detalle.Banco = det.Banco
                    Detalle.Cuenta = det.Cuenta
                    Detalle.Moneda = det.Moneda
                    Detalle.Numero = det.Numero
                    Detalle.Monto = det.Monto
                    Detalle.IdApertura = det.IdApertura
                    Detalle.Tipo = det.Tipo

                    Arqueo.ArqueoDepositos.Add(Detalle)
                Next

                For Each det As Datos.Models.ArqueoTarjetum In Me.db.ObtenerArqueosTarjeta(Arqueo.Id)
                    Dim Detalle As New Datos.Models.ArqueoTarjetum
                    Detalle.Id = det.Id
                    Detalle.IdArqueo = det.IdArqueo
                    Detalle.IdTarjeta = det.IdTarjeta
                    Detalle.Monto = det.Monto

                    Arqueo.ArqueoTarjeta.Add(Detalle)
                Next

                Resultado.Add(Arqueo)
            Next

            Return Resultado
        End Function
        Public Function Crear(arqueocajas As Datos.Models.ArqueoCaja) As String
            Return Me.db.CrearArqueosCajas(arqueocajas)
        End Function
        Public Function Editar(id As Integer, arqueocajas As Datos.Models.ArqueoCaja) As String
            Return Me.db.EditarArqueosCajas(id, arqueocajas)
        End Function
        Public Function Anular(idarqueo As Integer) As String
            Return Me.db.AnuarArqueosCajas(idarqueo)
        End Function

    End Class
End Namespace