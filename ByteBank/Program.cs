
using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
            Console.ReadLine();
        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer joao = new Designer("555.555.555-55");
            joao.Nome = "Joao";

            Diretor giovanna = new Diretor("222.222.222-22");
            giovanna.Nome = "Giovanna";

            Desenvolvedor beatriz = new Desenvolvedor("45.124.888-22");
            giovanna.Nome = "Beatriz";

            Auxiliar pedro = new Auxiliar("111.111.111-11");
            pedro.Nome = "Pedro";

            GerenteDeConta andreza = new GerenteDeConta("122.122.122-12");
            andreza.Nome = "Andreza";

            gerenciadorBonificacao.Registrar(joao);
            gerenciadorBonificacao.Registrar(beatriz);
            gerenciadorBonificacao.Registrar(giovanna);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(andreza);

            Console.WriteLine("Bonificações totais no mês: " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
