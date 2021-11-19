using System;
using System.Globalization;

namespace Studs
{
    class FornecedorService
    {
        public static void Selecaof(Fornecedor f)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-Bem-vindo-ao-módulo-de-fornecedores-");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"-----------ID:{f.fID},---Nome:{f.fNome}---------");
            Console.WriteLine($"------------Tipo:-{f.fTipo}-------------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("--Escolha-uma-opção-para-prosseguir--");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("------------1)-Alterar-ID------------");
            Console.WriteLine("------------2)-Alterar-Nome----------");
            Console.WriteLine("------------3)-Alterar-Tipo----------");
            Console.WriteLine("------------4)-Voltar----------------");
            ExecForn(int.Parse(Console.ReadLine()), f);
        }
        private static void ExecForn(int opcaof, Fornecedor f)
        {
            if (opcaof == 1)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("--------Digite-o-ID-desejado.--------");
                Console.WriteLine("-------------------------------------");
                int fid = int.Parse(Console.ReadLine());
                f.fID = fid;
            }
            else if (opcaof == 2)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("-------Digite-o-nome-desejado.-------");
                Console.WriteLine("-------------------------------------");
                string nomef = Console.ReadLine();
                if (nomef.Length < 3)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("-Nome-muito-curto.-Tente-novamente.--");
                    Console.WriteLine("-------------------------------------");
                    ExecForn(opcaof, f);
                }
                else
                {
                    f.fNome = nomef;
                }
            }
            else if (opcaof == 3)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("-------Digite-o-tipo-desejado.-------");
                Console.WriteLine("-------------------------------------");
                string tipof = Console.ReadLine();
                if (tipof.Length < 3)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("-Tipo-muito-curto.-Tente-novamente.--");
                    Console.WriteLine("-------------------------------------");
                    ExecForn(opcaof, f);
                }
                else
                {
                    f.fTipo = tipof;
                }
            }
            else if (opcaof == 4)
            {
                Programa.Main();
            }
            else
            {
                Selecaof(f);
            }
        }
    }
}
