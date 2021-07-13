
using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();

            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor giovanna = new Diretor("222.222.222-22");
            giovanna.Nome = "Giovanna";
            giovanna.Senha = "123";

            GerenteDeConta andreza = new GerenteDeConta("122.122.122-12");
            andreza.Nome = "Andreza";
            andreza.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");
            sistemaInterno.Logar(andreza, "abc");
            sistemaInterno.Logar(giovanna, "123");
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
