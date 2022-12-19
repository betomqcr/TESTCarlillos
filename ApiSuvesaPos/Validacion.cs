using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ApiSuvesaPos
{
    public class Validacion
    {



        private bool validarNumero(string data)
        {
            try
            {
                data = data.Replace(" ", String.Empty);
                return data.All(char.IsDigit);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool validarCaracteresEspeciales(string data)
        {
            try
            {
                if (Regex.IsMatch(data, "^[a-zA-Z0-9\x20]+$"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool vacioTexto(string data)
        {
            try
            {
                return string.IsNullOrEmpty(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool validarTexto(string data)
        {
            try
            {
                data = data.Replace(" ", String.Empty);
                return data.All(char.IsLetter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool validarKeyWords(string data)
        {
            try
            {
                data = data.Replace(" ", String.Empty);
                data = data.ToUpper();
                if ((data.Contains("SELECT") || data.Equals("SELECT")) || (data.Contains("UPDATE") || data.Equals("UPDATE")) || (data.Contains("INSERT") || data.Equals("INSERT")) || (data.Contains("DELETE")) || data.Equals("DELETE"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
