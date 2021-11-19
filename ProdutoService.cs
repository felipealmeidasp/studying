using System;
using System.Globalization;

namespace Studs
{
    class ProdutoService
    {
        public static void Selecaop(Produto p)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("----Bem-vindo-ao-módulo-de-produtos--");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"----Nome:{p.pNome},---Preço:{p.pPreco.ToString("F2", CultureInfo.InvariantCulture)}--");
            Console.WriteLine($"------Quantidade:{ p.pQuant},-Total:{p.pTotal}-------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("--Escolha-uma-opção-para-prosseguir--");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("------------1)-Alterar-nome----------");
            Console.WriteLine("------------2)-Alterar-preço---------");
            Console.WriteLine("------------3)-Alterar-quantidade----");
            Console.WriteLine("------------4)-Voltar----------------");
            ExecProd(int.Parse(Console.ReadLine()), p);
        }
        private static void ExecProd(int opcaop, Produto p)
        {
            if (opcaop == 1)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("-------Digite-o-nome-desejado.-------");
                Console.WriteLine("-------------------------------------");
                string pre_nome = Console.ReadLine();
                if (pre_nome.Length < 3)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("-Nome-muito-curto.-Tente-novamente.--");
                    Console.WriteLine("-------------------------------------");
                    ExecProd(opcaop, p);
                }
                else
                {
                    p.SetpNome(pre_nome, p);
                }
            }
            else if (opcaop == 2)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("-------Digite-o-preço-desejado-.-----");
                Console.WriteLine("-------------------------------------");
                p.pPreco = double.Parse(Console.ReadLine());
            }
            else if (opcaop == 3)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("----Digite-a-quantidade-desejada-.---");
                Console.WriteLine("-------------------------------------");
                p.pQuant = int.Parse(Console.ReadLine());
            }
            else if (opcaop == 4)
            {
                Programa.Main();
            }
            else
            {
                Selecaop(p);
            }
        }
    }
}
