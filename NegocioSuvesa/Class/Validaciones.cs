using NegocioSuvesa.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NegocioSuvesa.Class
{
    public class Validaciones : IValidaciones
    {
        public bool isEmail(string texto)
        {
            return Regex.IsMatch(texto, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        public bool isEmpty(string texto)
        {
            return string.IsNullOrEmpty(texto);
        }

        public bool isOnlyLetter(string texto)
        {
            texto = texto.Replace(" ", String.Empty);
            return texto.All(char.IsLetter);
        }

        public bool isOnlyNumeric(string texto)
        {
            texto = texto.Replace(" ", String.Empty);
            return texto.All(char.IsDigit);
        }

        public bool hasSpecialCharacters(string texto)
        {
            return !Regex.IsMatch(texto, "^[a-zA-Z0-9\x20]+$");
        }
    }
}
