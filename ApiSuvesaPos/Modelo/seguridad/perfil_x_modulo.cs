namespace Modelo
{
    public class perfil_x_modulo
    {
        public int Id_Modulo_Perfil { get; set; }
        public int Id_Perfil { get; set; }
        public int Id_Modulo { get; set; }
        public bool Accion_Ejecucion { get; set; }
        public bool Accion_Actualizacion { get; set; }
        public bool Accion_Eliminacion { get; set; }
        public bool Accion_Busqueda { get; set; }
        public bool Accion_Impresion { get; set; }
        public bool Accion_Opcion { get; set; }
        public string Menu { get; set; }
    }
}
