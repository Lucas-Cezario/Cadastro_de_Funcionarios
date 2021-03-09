using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Funcionarios
{
    class Tecnico : Funcionario
    {
        private string Cargo { get; set; }
        private string Bonificacao { get; set; }

        public Tecnico()
        {

        }
        public Tecnico(string cargo, string bonificacao)
        {
            Cargo = cargo;
            Bonificacao = bonificacao;
        }
        public void LeDadosT()
        {
            base.LeDado();
            Console.Write("Cargo......: ");
            Cargo = Console.ReadLine();

            Console.Write("Bonificação.: ");
            Bonificacao = Console.ReadLine();
        }
        ArrayList Cad = new ArrayList();
        public void SalvarT(Tecnico X)
        {
            Cad.Add(X);
        }
        public void ListaT()
        {

            foreach (Tecnico x in Cad)
            {
                Console.Write("Nome........: {0}", x.Nome);
                Console.WriteLine();
                Console.Write("Endereço....: {0}", x.Endereço);
                Console.WriteLine();
                Console.Write("Telefone....: {0}", x.Telefone);
                Console.WriteLine();
                Console.Write("Mail.......: {0}", x.Mail);
                Console.WriteLine();
                Console.Write("Salario.....: {0}", x.Salario);
                Console.WriteLine();
                Console.Write("Cargo......: {0}", x.Cargo);
                Console.WriteLine();
                Console.Write("Bonificação.: {0}", x.Bonificacao);
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.ReadKey();
        }

    }
}
