using System;
using System.Collections.Generic;
using Att___1.Calculadoras;
using Att___1.Concatenacao;
using Att___1.Ordenacao;

namespace Att___1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nomes = new List<string>();
            nomes.Add("Thainá Loureiro de Oliveira");
            nomes.Add("Wilian da Silva Morais");
            nomes.Add("Pedro Henrique Costa");
            nomes.Add("Fernanda Santos");
            nomes.Add("Maria Laura Loureiro");
            nomes.Add("William Pedroso Mombach");
            nomes.Add("Sabrina Chaves");
            nomes.Add("Amanda Cristina Ferreira");
            nomes.Add("Carlos Eduardo de Oliveira");
            nomes.Add("Yasmin Lopes");
            
            var ordenar = new Ordenar();
            var resultado = ordenar.Ordem(nomes);

            foreach(var nome in resultado)
            {
                Console.WriteLine(nome);
            }




            #region order
            /*INTEGRAÇÃO DOS DOIS METODOS
            var concatenar = new Concatenar();
            string nome;
            string sobrenome;
            Console.WriteLine("Digite o Nome :");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o Sobrenome :");
            sobrenome = Console.ReadLine();
            var nomeCompleto = concatenar.NomeCompleto(nome, sobrenome);
            Console.WriteLine("Resultado :" + nomeCompleto);
            int qtdCaracteres = concatenar.qtdCaracteres(nome, sobrenome);
            Console.WriteLine("Quantidade total de caracteres :" + qtdCaracteres);
            Console.ReadLine();
            */

            /* QUANTIDADE DE CARACTERES
            var concatenar = new Concatenar();
            string nome;
            string sobrenome;
            Console.WriteLine("Digite o Nome :");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o Sobrenome :");
            sobrenome = Console.ReadLine();
            int qtdCaracteres = concatenar.qtdCaracteres(nome, sobrenome);
            Console.WriteLine("Quantidade total de caracteres :" + qtdCaracteres);
            Console.ReadLine();
            */

            /* NOME COMPLETO
            var concatenar = new Concatenar();
            string nome;
            string sobrenome;
            Console.WriteLine("Digite o Nome :");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o Sobrenome :");
            sobrenome = Console.ReadLine();
            var nomeCompleto = concatenar.NomeCompleto(nome, sobrenome);
            Console.WriteLine("Resultado :" + nomeCompleto);
            Console.ReadLine();
            */

            /* CALCULADORA
             string valorA;
             string valorB;
             Console.WriteLine("Digite o valor A :");
             valorA = Console.ReadLine();
             Console.WriteLine("Digite o valor B :");
             valorB = Console.ReadLine();
             var calc = new Calculadora();
             var resultado = calc.Add(Convert.ToInt16(valorA), Convert.ToInt16(valorB));
             Console.WriteLine("Resultado :" + resultado);
             Console.ReadLine();
            */
            #endregion


        }
    }


}

