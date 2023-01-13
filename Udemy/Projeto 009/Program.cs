using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_009
{
    class Program
    {
        static void Main(string[] args)
        {

            //Sequência de scape \
            Console.WriteLine("Olá mundo!");
            Console.WriteLine("Olá \tmundo");
            Console.WriteLine("Olá \nmundo");
            Console.WriteLine("Olá \"mundo\"");
            Console.WriteLine("c:\\fonte\\teste");

            //Diretiva arroba
            Console.Write("\n\n");
            Console.Write("A pasta do arquivo é: ");
            Console.WriteLine(@"c:\fonte\teste");

            //Concatenação de caracteres
            Console.Write("\n\n");
            string nomeFuncionario = "Julyane", mensagemInicial = "Olá, ", mensagemFinal = " como você está?";
            Console.WriteLine(mensagemInicial + nomeFuncionario + mensagemFinal);

            //Interpolação de caracteres
            Console.Write("\n\n");
            string mensagem = $"{mensagemInicial}{nomeFuncionario}{mensagemFinal}";
            Console.WriteLine(mensagem);

            Console.WriteLine("Pressione uma tecla");
            Console.ReadKey();



        }
    }
}
