using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * FUP que calcule e apresente o valor do volume de uma caixa retangular, através da fórmula:
 *              volume = comprimento * largura * altura
 * O programa deve:
 *  -- Ler o comprimento, a largura e a altura
 *  -- Calcular o volume
 *  -- Apresentar o resultado do volume
 */


namespace Exercício_004
{
    class Program
    {
        static void Main(string[] args)
        {
            float comprimento, largura, altura, volume;

            Console.Write("Digite o comprimento da caixa: ");
            comprimento = float.Parse(Console.ReadLine());

            Console.Write("Digite a largura da caixa: ");
            largura = float.Parse(Console.ReadLine());

            Console.Write("Digite a altura da caixa: ");
            altura = float.Parse(Console.ReadLine());

            volume = comprimento * largura * altura;

            Console.WriteLine("O volume da caixa é: " + volume);
            Console.WriteLine("Pressione uma tecla.");
            Console.ReadKey();

        }
    }
}
