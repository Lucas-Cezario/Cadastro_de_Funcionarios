using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Funcionarios
/*Para todos os funcionários a empresa precisa cadastrar seus dados pessoais, como Nome, Endereço, 
 * Telefone e Mail e Salário. Especificamente se o funcionário for um professor é necessário armazenar também a Disciplina em que ele ministra aulas e o Total de Horas/Aula semanais.
 * Se ele for um técnico precisa ser armazenado seu Cargo e sua Bonificação por Produtividade.
   Crie um programa em C#.NET que crie as classes necessárias para armazenar os dados dos funcionários dessa empresa. Crie construtores nas classes que inicializem cada atributo.
   No programa principal crie, por meio de Vetores ou ArrayLists, uma estruturas capazes de armazenar até 100 funcionários que trabalham em cada uma das duas áreas descritas.
   O programa deverá também listar todos os funcionários cadastrados em cada uma das áreas.
*/

{
    
   

   
    class Program
    {
        static void Main(string[] args)
        {
            Professor prof = new Professor();
            Tecnico Tec = new Tecnico();

            int op;
            
            char profissional;

            do
            {
                

                Console.Clear();
                Console.WriteLine("***********Bem Vindo**********");
                Console.WriteLine("Cadastro de Novos funcionários\n");
                Console.WriteLine("1 - Cadastrar  2 - Listar  3 - Sair");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("P - Professor   T - Técnico");
                            profissional = char.Parse(Console.ReadLine().ToUpper());
                            if (profissional == 'P')
                            {
                                Professor P = new Professor();
                                P.LeDadosP();
                                prof.SalvarP(P);
                            }
                            if (profissional == 'T')
                            {
                                Tecnico T = new Tecnico();
                                T.LeDadosT();
                                Tec.SalvarT(T);
                            }
                            Console.WriteLine("Deseja Cadastrar mais ?? (ESC para sair)");

                        } while (Console.ReadKey().Key!=ConsoleKey.Escape);
                     
                        break;
                    case 2:
                        Console.Clear();

                        Console.WriteLine("****Professores*****");
                        prof.ListaP();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("*******Técnicos*****");
                        Tec.ListaT();
                        break;
                }

            } while (op != 3);

            Console.Clear();
            Console.WriteLine("Obrigado!!");
            Console.ReadKey();
        }
    }
}
