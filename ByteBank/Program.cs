
using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao bonificacao = new GerenciadorBonificacao();
            
            Funcionario carlos = new Funcionario(2000, "500.761.768-47");
            carlos.Nome = "Carlos";

            Diretor giovanna = new Diretor(5000,"212.222.555-78");
            giovanna.Nome = "Giovanna";

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            gerenciador.Registrar(giovanna);
            gerenciador.Registrar(carlos);

            Console.WriteLine("Total de Bonificações: " + gerenciador.GetTotalBonificacao());
            Console.ReadLine();
        }
    }
}
