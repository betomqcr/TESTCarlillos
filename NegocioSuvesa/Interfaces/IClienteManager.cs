using Datos.Helpers;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioSuvesa.Interfaces
{
    public interface IClienteManagerBL
    {
        Task<ResponseGeneric<Datos.DTOs.ClienteDTO>> addClientEntry(Datos.DTOs.ClienteDTO request);

        Task<ResponseGeneric<Datos.DTOs.ClienteDTO>> editClient(Datos.DTOs.ClienteDTO request);

        Task<ResponseGeneric<Datos.DTOs.ClienteDTO>> editClientFacturacion(Datos.DTOs.ClienteDTO request);

        Task<ResponseGeneric<int>> getIDClient(string cedula);

        Task<ResponseGeneric<int>> getIDClient(string cedula, string nombre);

        Task<ResponseGeneric<Datos.Models.CorreosComprobantes>> getEmailsClient(long id);

        Task<ResponseGeneric<Datos.Models.CorreosComprobantes>> putClientEmails(CorreosComprobantes lista);

        Task<ResponseGeneric<Datos.DTOs.BuscarClienteFacturacionDTO>> existClientFacturacion(Datos.DTOs.BuscarClienteDTO request);

        Task<ResponseGeneric<IEnumerable<Datos.DTOs.FiltranClienteDTO>>> getClientByCedula(Datos.DTOs.BuscarClienteDTO request);

        Task<ResponseGeneric<IEnumerable<Datos.DTOs.FiltranClienteDTO>>> getClientByNombre(Datos.DTOs.BuscarClienteDTO request);

        Task<ResponseGeneric<IEnumerable<Datos.DTOs.FiltranClienteDTO>>> getClientByFiltro(Datos.DTOs.BuscarClienteDTO request);

        Task<ResponseGeneric<Datos.DTOs.FiltranClienteDTO>> disableClient(Datos.DTOs.EliminarClienteDTO request);

        Task<ResponseGeneric<Datos.DTOs.FiltranClienteDTO>> enableClient(Datos.DTOs.EliminarClienteDTO request);
    }
}
