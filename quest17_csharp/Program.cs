/*Crie um programa para ler 2 números e imprimir qual o menor entre eles ou se eles 
são iguais.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest17_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
            {
                Console.WriteLine(" O maior número é: {0}", number1);
            }
            else if (number1 < number2) {
                Console.WriteLine("O maior número é: {0]", number2);
            }
            else
            {
                Console.WriteLine("Os números são iguais");
            }
            Console.ReadLine();
        }

    }
}
