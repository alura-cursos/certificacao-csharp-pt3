using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topico3
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <image url="$(ProjectDir)\Cracha.png" />
            /// < image url="$(ProjectDir)\Cracha2.png" />
            Funcionario funcionario = new Funcionario(1500);
            funcionario.CPF = "123.456.789-00";
            funcionario.Nome = "josé da silva";
            funcionario.DataNascimento = new DateTime(2000, 1, 1);

            funcionario.CargaHorariaMensal = 168;
            funcionario.EfeturarPagamento();
            funcionario.CrachaGerado += (s, e) =>
            {
                Console.WriteLine("Crachá gerado");
            };
            funcionario.GerarCracha();
        }
    }

    interface IFuncionario
    {
        string CPF { get; set; }
        string Nome { get; set; }
        DateTime DataNascimento { get; set; }

        event EventHandler CrachaGerado;

        void GerarCracha();

        decimal Salario { get; }
        int CargaHorariaMensal { get; set; }

        void EfeturarPagamento();
    }

    class Funcionario : IFuncionario
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public event EventHandler CrachaGerado;

        public void GerarCracha()
        {
            if (CrachaGerado != null)
            {
                CrachaGerado(this, new EventArgs());
            }
        }

        public decimal Salario { get; }

        public int CargaHorariaMensal { get; set; }

        public Funcionario(decimal salario)
        {
            Salario = salario;
        }

        public void EfeturarPagamento()
        {
            Console.WriteLine("Pagamento Efetuado");
        }
    }
}
