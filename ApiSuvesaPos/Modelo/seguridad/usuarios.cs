namespace Modelo
{
    public class usuarios
    {
        public string Id_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Clave_Entrada { get; set; }
        public string Clave_Interna { get; set; }
        public int Perfil { get; set; }
        public string Foto { get; set; } // image
        public string Iniciales { get; set; }
        public bool CambiarPrecio { get; set; }
        public decimal Porc_Precio { get; set; }
        public bool Aplicar_Desc { get; set; }
        public decimal Porc_Desc { get; set; }
        public bool Exist_Negativa { get; set; }
    }
}