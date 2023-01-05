using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





/* FUP que leia dois valores inteiros quaisquer
 * Calcular a soma entre eles
 * Apresentar o resultado do calculo 
 */


 namespace Projeto_007
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            int valorA, valorB, soma;

            //Entrada
            Console.Write("Digite um valor.............:");
            valorA = int.Parse(Console.ReadLine());

            Console.Write("Digite um valor.............:");
            valorB = int.Parse(Console.ReadLine());

            //Processamento
            soma = valorA + valorB;

            //Saída
            Console.WriteLine("O resultado da soma:" + soma);
            Console.WriteLine("{0}+{1}+{2}",valorA,valorB,soma);




            //Console.WriteLine("Digite uma tecla....");
            //Console.ReadKey();

            Console.WriteLine("Digite uma tecla....");
            Console.ReadKey();




        }
    }
}
