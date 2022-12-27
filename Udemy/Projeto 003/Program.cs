using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_003
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração das variáveis:
            string nomeFuncionario;
            char opcaoUsuario;
            int diaNascimento;
            int mesNascimento;
            int anoNascimento;
            int idadeFuncionario;
            decimal salarioBruto;
            decimal valorDesconto;
            bool maiorIdade;

            // atribuir valores as variáveis:
            nomeFuncionario = "Julyane Pereira da Silva";
            Console.WriteLine("Nome do funcionário: " + nomeFuncionario);

            opcaoUsuario = 's';
            diaNascimento = 03;
            mesNascimento = 08;
            anoNascimento = 1987;
            idadeFuncionario = 35;
            salarioBruto = 50000.45M;
            valorDesconto = 100.45M;
            maiorIdade = true;


            //apresentação dos dados:
            Console.WriteLine("Dia do nascimento.........: " + diaNascimento);
            Console.WriteLine("Mês do nascimento.........: " + mesNascimento);
            Console.WriteLine("Ano do nascimento.........: " + anoNascimento);
            Console.WriteLine("Idade do funcionário......: " + idadeFuncionario);
            Console.WriteLine("Salário bruto.............: " + salarioBruto);
            Console.WriteLine("Valor desconto............: " + valorDesconto);
            Console.WriteLine("Maior de idade?...........: " + maiorIdade);
            Console.WriteLine("Opção do usuário..........: " + opcaoUsuario);







        }
    }
}
