using System;

namespace ApiSuvesaPos.Models
{
    public class RespuestaAutenticacion
    {
        
        public string Token { get; set; }
        public DateTime Expiracion { get; set; }

        public string Usuario { get; set; }
    }
}
