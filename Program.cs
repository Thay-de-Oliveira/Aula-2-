using System;
using System.Collections.Generic;
using Att___1.Calculadoras;
using Att___1.Concatenacao;
using Att___1.Ordenacao;
using Att___1.Filmes;
using Att___1.Cortinas;


namespace Att___1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o modelo de cortina desejada: ");
            Console.WriteLine("0 - Voal");
            Console.WriteLine("1 - Persiana");
            Console.WriteLine("2 - Rolo");
            Console.WriteLine("3 - Romana");
            var tipoCortina = Console.ReadLine();
            Console.WriteLine("Digite a metragem desejada:");
            var metros = Console.ReadLine();

            var custo = new CustoCortina();
            switch (tipoCortina)
            {
                case "0":
                Console.WriteLine("O valor do orçamento é de: " + custo.CalculoCusto(TipoCortina.Voal, Convert.ToInt16(metros)));
                    break;

                case "1":
                    Console.WriteLine("O valor do orçamento é de: " + custo.CalculoCusto(TipoCortina.Persiana, Convert.ToInt16(metros)));
                    break;

                case "2":
                    Console.WriteLine("O valor do orçamento é de: " + custo.CalculoCusto(TipoCortina.Rolo, Convert.ToInt16(metros)));
                    break;

                case "3":
                    Console.WriteLine("O valor do orçamento é de: " + custo.CalculoCusto(TipoCortina.Romana, Convert.ToInt16(metros)));
                    break;

                default:
                    Console.WriteLine("Por gentileza, verifique o numero digitado");
                    break;

                    /*  Ou
                     *  var custo = new CustoCortina();
                     *  var meuTipo = (TipoCortina)(Convert.ToInt16(tipoCortina));
                     *  var total = custo.calcularCusto(meuTipo
                     */
            }

            #region Filmes
            /*
            var usuario = new Usuario() { nomeUser = "Thaina", idadeUser = 18};
            //Ou usuario.nomeUser = "Thaina";

            var filme = new Filme() { NomeFilme = "Doctor Strange", IdadeIndicativa = 12, GeneroFilme = GeneroFilme.Acao };

            var validacao = new ValidarpermissaoUser();
            var possoVerFilme = validacao.Validar(usuario, filme);
            */
            #endregion

            #region lista
            /*LISTA
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
            */

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
            #endregion

            #region Calculadora
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

