using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Entrada de dados com leitura de string

namespace Projeto_006
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração das variáveis
            string nome;
            string anoNascimento;
            int anoDoNascimento;
            int idade;

            //Entrada de dados
            Console.Write("Digite um nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite o ano de nascimento: ");
            anoNascimento = Console.ReadLine();


            //Processamento de dados - Conversão de tipos de dados diferentes usando o Parse

            //anoDoNascimento = int.Parse(anoNascimento);
            //idade = 2022 - anoDoNascimento;

            //Processamento de dados - Conversão de tipos de dados diferentes usando o Convert
            anoDoNascimento = Convert.ToInt32(anoNascimento);         
            idade = 2022 - anoDoNascimento;





            //Saída de Dados
            Console.WriteLine("Nome lido:" + nome);
            Console.WriteLine("Ano de nascimento:" + anoNascimento);
            Console.WriteLine("Idade: " + idade);

            //explorando as possibilidades da variável
            Console.WriteLine("Tamanho do nome lido.........:" + nome.Length);
            Console.WriteLine(nome.ToUpper());
            Console.WriteLine(nome.ToLower());

            //Incluindo uam pausa no final do programa
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();
        }
    }
}
