using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Funcionarios
{
    class Professor : Funcionario
    {
        private string Diciplina { get; set; }
        private string THorasAulaSemanais { get; set; }

        public Professor()
        {

        }
        public Professor(string diciplina, string horasAulaSemanais)
        {
            Diciplina = diciplina;
            THorasAulaSemanais = horasAulaSemanais;
        }

        public void LeDadosP()
        {

            base.LeDado();
            Console.Write("Diciplina...: ");
            Diciplina = Console.ReadLine();

            Console.Write("Total de horas trabalhadas semanais: ");
            THorasAulaSemanais = Console.ReadLine();

        }

        ArrayList Cad = new ArrayList();
        public void SalvarP(Professor X)
        {
            Cad.Add(X);
        }
        public void ListaP()
        {

            foreach (Professor x in Cad)
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
                Console.Write("Diciplina...: {0}", x.Diciplina);
                Console.WriteLine();
                Console.Write("Total de horas trabalhadas semanais: {0}", x.THorasAulaSemanais);
                Console.WriteLine();
                Console.WriteLine();
            }

        }


    }
}
