using System;

namespace Modelo
{
    public class registro_permisoajuste
    {
        public string cedula_usuario { get; set; }
        public DateTime fecha { get; set; }
        public string descripcion { get; set; }
        public int id_Movimiento { get; set; }
        public string Administrador { get; set; }
    }
}
