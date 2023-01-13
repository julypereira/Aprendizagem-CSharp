using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 
 * FUP que leia dois valores do tipo ponto flutuante
 * Calculara soma entre eles
 * Apresentar o resultado do cálculo
 */

namespace Projeto_008
{
    class Program
    {
        static void Main(string[] args)
        {

            // declaração de variáveis
            float valorA, valorB, soma;

            // entrada de dados
            Console.Write("Digite um valor:");
            valorA = float.Parse(Console.ReadLine());

            Console.Write("Digite um valor:");
            valorB = float.Parse(Console.ReadLine());

            // processamento de dados
            soma = valorA + valorB;

            // saída de dados
            Console.WriteLine("O resultado é: " + soma);
            Console.WriteLine("Pressione uma tecla");
            Console.ReadKey();



        

        }
    }
}
