using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioSuvesa.Interfaces
{
    public interface IValidaciones
    {
        public bool hasSpecialCharacters(string texto);

        public bool isEmpty(string texto);

        public bool isOnlyNumeric(string texto);

        public bool isOnlyLetter(string texto);

        public bool isEmail(string texto);
    }
}
