using System;
using System.Threading;

namespace Revisao.Prova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, me diga é qual o seu nome?");
            string nome = Console.ReadLine();

            Thread.Sleep(2000);

            Console.WriteLine("Oi " + nome
                + ", qual processo você deseja acessar?");

            Console.WriteLine("1 - Calculadora");
            Console.WriteLine("0 - Sair");

            string menu = Console.ReadLine();

            if (menu == "1")
            {
                try
                {
                    Console.WriteLine("Qual operação deseja fazer: ");
                    Console.WriteLine("(+) adição");
                    Console.WriteLine("(-) subtração");
                    Console.WriteLine("(/) divisão");
                    Console.WriteLine("(*) multiplicação");

                    string menuCalculadora = Console.ReadLine();

                    Console.WriteLine("Informe o primeiro valor: ");
                    string valorUm = Console.ReadLine();
                    decimal valorUmConvertido = decimal.Parse(valorUm);

                    Console.WriteLine("Informe o segundo valor: ");
                    string valorDois = Console.ReadLine();
                    decimal valorDoisConvertido = decimal.Parse(valorDois);

                    if (menuCalculadora == "+")
                    {
                        Console
                            .WriteLine("Resultado: " + (valorUmConvertido + valorDoisConvertido));
                    }
                    else if (menuCalculadora == "-")
                    {
                        Console
                            .WriteLine("Resultado: " + (valorUmConvertido - valorDoisConvertido));
                    }
                    else if (menuCalculadora == "/")
                    {
                        Console
                            .WriteLine("Resultado: " + (valorUmConvertido / valorDoisConvertido));
                    }
                    else if (menuCalculadora == "*")
                    {
                        Console
                            .WriteLine("Resultado: " + (valorUmConvertido * valorDoisConvertido));
                    }
                    else
                    {
                        Console.WriteLine("Operação inválida");
                    }
                }
                catch
                {
                    Console.WriteLine("Ocorreu um erro! Verifique.");
                }
            }
            else if (menu == "0")
            {
                Console.WriteLine("Tchau " + nome);
            }
            else
            {
                Console.WriteLine("Menu inválido.");
            }
            
            Console.ReadKey();
        }
    }
}