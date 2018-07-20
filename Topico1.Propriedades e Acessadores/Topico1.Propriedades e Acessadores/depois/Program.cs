using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topico1
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario(1000);
            //funcionario.salario = 1000;
            //Console.WriteLine(funcionario.salario);

            //funcionario.salario = -1200;
            //Console.WriteLine(funcionario.salario);

            //funcionario.Salario = -1200;
            //funcionario.Salario = 1200;
            Console.WriteLine(funcionario.Salario);
            //funcionario.Salario = 2000;
            //funcionario.Salario = 800;
        }
    }

    class Funcionario
    {
        public Funcionario(decimal salario)
        {
            if (salario < 0)
            {
                throw new ArgumentOutOfRangeException("salário não pode ser negativo");
            }
            this.salario = salario;
        }

        decimal salario;

        public decimal Salario //encapsulamento do campo salario
        {
            get
            {
                return salario;
            }
            //set
            //{
            //    if (value < 0)
            //    {
            //        throw new ArgumentOutOfRangeException("salário não pode ser negativo");
            //    }
            //    salario = value;
            //}
        }

        //private decimal salario;

        //public decimal Salario
        //{
        //    get { return salario; }
        //    set { salario = value; }
        //}

        //public decimal Salario { get; set; }
    }

    public class Banco
    {
        public Banco()
        {
            Conta conta = new Conta();
            conta.Saldo = 1000;
            Console.WriteLine(conta.Saldo);
        }
    }

    public class Conta
    {
        public Conta()
        {
            this.Saldo = 1000;
            Console.WriteLine(this.Saldo);
        }

        void Sacar(decimal saque)
        {
            Saldo = Saldo - saque;
        }

        public decimal Saldo { get; set; }
    }

    public class ContaCorrente : Conta
    {
        public ContaCorrente()
        {
            this.Saldo = 1000;
            Console.WriteLine(this.Saldo);
        }
    }
}
