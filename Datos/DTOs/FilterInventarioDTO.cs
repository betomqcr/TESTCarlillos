using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DTOs
{
    public class FilterInventarioDTO
    {
        public int Codigo { get; set; }

        public string Cod_Articulo { get; set; }

        public string Barras { get; set; }

        public string Descripcion { get; set; }

        public string Marca { get; set; }

        public string Simbolo { get; set; }

        public float Precio_A { get; set; }

        public float ValorCompra { get; set; }

        public float PrecioFinal { get; set; }

        public float Existencia { get; set; }

        public float Bodega { get; set; }

        public string Ubicacion { get; set; }

        public bool Inhabilitado { get; set; }

        public bool receta { get; set; }

        public float prestamo { get; set; }

        public bool Consignacion { get; set; }

        public float Estado { get; set; }

    }
}
