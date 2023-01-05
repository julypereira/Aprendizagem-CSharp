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
            int anoNascimento;
            int idade;

            //Entrada de dados
            Console.Write("Digite um nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite o ano de nascimento: ");
            anoNascimento = int.Parse(Console.ReadLine());


            //Processamento de dados - Conversão de tipos de dados diferentes usando o Convert
            
            idade = 2022 - anoNascimento;


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
