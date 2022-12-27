using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*FUP que crie as seguintes variáveis:
 * Uma variável para armazenar o nome de uma pessoa;
 * Uma variável para armazenar a idade de uma pessoa;
 * Uma variável para armazenar a temperatura de uma pessoa;
 */

namespace Exercicio_002
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declaração das variáveis:
            string nome;
            int idade;
            float temperatura;

            //Atribuição de valores para as variáveis:
            nome = "Julyane Pereira da Silva";
            idade = 35;
            temperatura = 37.5F;

            //Mostrar os valores das variáveis:
            Console.WriteLine("Nome...............: " + nome);
            Console.WriteLine("Idade..............: " + idade);
            Console.WriteLine("Temperatura........: " + temperatura);

        }
    }
}