
using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao bonificacao = new GerenciadorBonificacao();
            
            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "500.761.768-47";
            carlos.Salario = 2000;

            Funcionario giovanna = new Diretor();
            giovanna.Nome = "Giovanna";
            giovanna.CPF = "212.222.555-78";
            giovanna.Salario = 5000;

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            gerenciador.Registrar(giovanna);
            gerenciador.Registrar(carlos);

            Console.WriteLine("Total de Bonificações: " + gerenciador.GetTotalBonificacao());
            Console.ReadLine();
        }
    }
}
