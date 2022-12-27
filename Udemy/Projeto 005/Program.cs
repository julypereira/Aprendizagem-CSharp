using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_005 //tamanho dos tipos de dados
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorInteiro;
            decimal valorDecimal;
            float valorFloat;
            double valorDouble;

            //Inteiro

            valorInteiro = int.MinValue;
            Console.WriteLine("Menor valor do inteiro........:" + valorInteiro);

            valorInteiro = int.MaxValue;
            Console.WriteLine("Maior valor do inteiro........:" + valorInteiro);

            //Decimal

            valorDecimal = int.MinValue;
            Console.WriteLine("Menor valor do decimal........:" + valorDecimal);

            valorDecimal = int.MaxValue;
            Console.WriteLine("Maior valor do decimal........:" + valorDecimal);

            //Float

            valorFloat = int.MinValue;
            Console.WriteLine("Menor valor do float........:" + valorFloat);

            valorFloat = int.MaxValue;
            Console.WriteLine("Maior valor do float........:" + valorFloat);

            //Double

            valorDouble = int.MinValue;
            Console.WriteLine("Menor valor do double........:" + valorDouble);

            valorDouble = int.MaxValue;
            Console.WriteLine("Maior valor do double........:" + valorDouble);


        }
    }
}
