using System;

namespace Datos.DTOs
{
    public class ArticulosRelacionadosDTO
    {
        public int Id { get; set; }
        public int CodigoPrincipal { get; set; }
        public int Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public float Cantidad { get; set; }
        public bool Estado { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public string IdUsuarioModificacion { get; set; }
    }
}
