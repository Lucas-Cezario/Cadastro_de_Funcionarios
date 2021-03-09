using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Funcionarios
{
    class Funcionario
    {
        protected string Nome { get; set; }
        protected string Endereço { get; set; }
        protected string Telefone { get; set; }
        protected string Mail { get; set; }
        protected double Salario { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(string nome, string endereço, string telefone, string mail, double salario)
        {
            Nome = nome;
            Endereço = endereço;
            Telefone = telefone;
            Mail = mail;
            Salario = salario;
        }

        public void LeDado()
        {
            Console.Write("Nome........: ");
            Nome = Console.ReadLine();

            Console.Write("Endereço....: ");
            Endereço = Console.ReadLine();

            Console.Write("Telefone....: ");
            Telefone = Console.ReadLine();

            Console.Write("Mail.......: ");
            Mail = Console.ReadLine();

            Console.Write("Salario.....: ");
            Salario = double.Parse(Console.ReadLine());
        }
    }
}
