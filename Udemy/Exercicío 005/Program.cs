using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * FUP que leia os valores citados abaixo:
 * -- 1º: 120m
 * -- 2º: 195.46m
 * -- 3º: 47,49m
 * -- 4º: 289.34m
 * -- 5º: 38.3m
 * Calcular e apresentar a distância percorrida para medir a área cultida
 */

namespace Exercicío_005
{
    class Program
    {
        static void Main(string[] args)
        {
            double area1, area2, area3, area4, area5, distancia;

            Console.Write("Digite o valor da área 1: ");
            area1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da área 2: ");
            area2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da área 3: ");
            area3 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da área 4: ");
            area4 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da área 5: ");
            area5 = double.Parse(Console.ReadLine());


            distancia = area1 + area2 + area3 + area4 + area5;

            Console.Clear();
            Console.WriteLine("A distância percorrifa foi de "+distancia);
            Console.WriteLine("Pressione uma tecla");
            Console.ReadKey();
        }
    }
}
