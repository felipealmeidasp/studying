using System;
using System.Globalization;

namespace Studs
{
    class Programa
    {
        public static Produto p = new Produto();
        public static Fornecedor f = new Fornecedor();
        public static Cliente c = new Cliente();
        public static void Main()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("----Bem-vindo ao ProductManager!-----");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("--Escolha uma opção para prosseguir--");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("------------1)-Produtos--------------");
            Console.WriteLine("------------2)-Fornecedores----------");
            Console.WriteLine("------------3)-Clientes--------------");
            Console.WriteLine("-------------------------------------");
            Selecao(int.Parse(Console.ReadLine()));
        }

            static void Selecao (int opcao)
        {
            if (opcao == 1)
            {
                ProdutoService.Selecaop(p);
            } else if (opcao == 2)
            {
                FornecedorService.Selecaof(f);
            } else if (opcao == 3)
            {
                ClienteService.Selecaoc(c);
            }  else
            
            {
                Main();
            }
        }
    }
}
