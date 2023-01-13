using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *FUP que calclule o valor da mesada recebida pelo Joãozinho
 *o programa deve ler a mesada da avó, da mãe e do pai
 *Calcular o total recebido por ele
 *Apresentar o resultado da mesada total
 */

namespace Exercício_003
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração das variáveis
            decimal mesadaMae,mesadaPai, mesadaAvo, totalMesada;

            // entrada de dados
            Console.Write("Digite o valor da mesada dado pela mãe: ");
            mesadaMae = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o valor da mesada dado pela pai: ");
            mesadaPai = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o valor da mesada dado pela avó: ");
            mesadaAvo = decimal.Parse(Console.ReadLine());

            // processamento de dados
            totalMesada = mesadaMae + mesadaPai + mesadaAvo;

            // saída de dados
            Console.WriteLine("A mesada total recebida foi de: R$" + totalMesada);
            Console.WriteLine("Pressione uma tecla");
            Console.ReadKey();

        }
    }
}
