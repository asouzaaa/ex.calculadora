using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio1
{
    class Program //Calculadora Console
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a opração: ");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            int resultado = 0;
            switch(operacao)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "x":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    resultado = numero1 / numero2;
                    break;
                case "%":
                    resultado = numero1 % numero2;
                    break;
            }
            Console.WriteLine("{0} {1} {2} = {3}", numero1, operacao, numero2, resultado);

            Console.ReadKey();


        }
    }
}