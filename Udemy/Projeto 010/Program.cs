using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_010
{
    class Program
    {
        static void Main(string[] args)
        {

            int valorA, valorB, resultado;

            valorA = 10;
            valorB = 20;
            resultado = valorA + valorB;

            Console.WriteLine("somando o valor: "+valorA+" com o valor: "+valorB+" temos como resultado: "+resultado);
            Console.WriteLine("Pressione uma tecla");
            Console.ReadKey();

        }
    }
}
