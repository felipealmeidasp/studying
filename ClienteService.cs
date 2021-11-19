using System;
using System.Globalization;

namespace Studs
{
    class ClienteService
    {

        /*public static void Selecaoc(Cliente c)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("---------Cadastre-o-cliente----------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("----------------1)-Nome--------------");
            string cnome = Console.ReadLine();
            Console.WriteLine("----------------2)-Idade-------------");
            int cidade = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------3)-Sexo--------------");
            string csexo = Console.ReadLine();
            Console.WriteLine("----------------4)-ID----------------");
            int cid = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------5)-Cidade------------");
            string ccidade = Console.ReadLine();
            ExecCli(cnome, cidade, csexo, cid, ccidade);*
        }*/
        public static void Selecaoc(Cliente c)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("----Bem-vindo-ao-módulo-de-clientes--");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"----Nome:{c.cNome},---Idade:{c.cIdade}--");
            Console.WriteLine($"------Sexo:{c.cSexo},-ID:{c.cID}-------");
            Console.WriteLine($"----------Cidade:{c.cCidade}-----------------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("------------1)-Alterar-nome----------");
            Console.WriteLine("------------2)-Alterar-idade---------");
            Console.WriteLine("------------3)-Alterar-sexo----------");
            Console.WriteLine("------------4)-Alterar-cidade--------");
            Console.WriteLine("------------5)-Voltar----------------");
            ExecProd(int.Parse(Console.ReadLine()), c);

        }
        
        private static void ExecProd (int opcao, Cliente c){ 
            
            if (opcao == 1) {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("------------Digite-o-nome:-----------");
                Console.WriteLine("-------------------------------------");
                string nome = Console.ReadLine();
                if (nome.Length < 3 || nome == null)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("------------Nome-inválido!-.---------");
                    Console.WriteLine("-----------Tente novamente-----------");
                    Console.WriteLine("-------------------------------------");
                    ExecProd(opcao, c);
                }
                else
                {
                    c.cNome = nome;
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("------------Nome-alterado!-.---------");
                    Console.WriteLine("-------------------------------------");
                    Selecaoc(c);
                }
            } 
            else if (opcao == 2)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("-----------Digite-a-idade:-----------");
                Console.WriteLine("-------------------------------------");
                int idade = int.Parse(Console.ReadLine());
                if (idade <= 0)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("-------Idade-fora-dos-parâmetros!----");
                    Console.WriteLine("-----------Tente-novamente.----------");
                    Console.WriteLine("-------------------------------------");
                    ExecProd(opcao, c);
                } else
                {
                    c.cIdade = idade;
                }
            }
            else if (opcao == 3)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("------------Digite-o-sexo:-----------");
                Console.WriteLine("-------------------------------------");
                string sexo = Console.ReadLine();
                if (sexo.Length < 3 || sexo == null)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("------------Sexo-inválido!-.---------");
                    Console.WriteLine("-----------Tente novamente-----------");
                    Console.WriteLine("-------------------------------------");
                    ExecProd(opcao, c);
                }
                else
                {
                    c.cSexo = sexo;
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("------------Sexo-alterado!-.---------");
                    Console.WriteLine("-------------------------------------");
                    Selecaoc(c);
                }
            } 
            else if (opcao == 4) 
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("-----------Digite-a-cidade:----------");
                Console.WriteLine("-------------------------------------");
                string cidade = Console.ReadLine();
                if (cidade.Length < 3 || cidade == null)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("-----------Cidade-inválida!-.--------");
                    Console.WriteLine("-----------Tente novamente-----------");
                    Console.WriteLine("-------------------------------------");
                    ExecProd(opcao, c);
                }
                else
                {
                    c.cCidade = cidade;
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("-----------Cidade-alterada!-.--------");
                    Console.WriteLine("-------------------------------------");
                    Selecaoc(c);
                }
            }
            else
            {
                Programa.Main();
            }
        }
    }
}
