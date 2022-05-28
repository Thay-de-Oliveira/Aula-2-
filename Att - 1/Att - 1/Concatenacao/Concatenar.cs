using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Att___1.Concatenacao

{
    public class Concatenar
    {
        public string NomeCompleto(string firstName, string lastName)
        {
            return firstName + " " + lastName;
            /*ou
             * var temp = $"(firstName) {lastName};"
             */
        }
        public int qtdCaracteres(string nome, string sobrenome)
        {
            return nome.Length + sobrenome.Length;
        }
    }
}
