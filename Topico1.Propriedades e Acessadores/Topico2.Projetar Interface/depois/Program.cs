using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topico2
{
    class Program
    {
        static void Main(string[] args)
        {
            Televisao eletro1 = new Televisao();
            Abajur eletro2 = new Abajur();
            Lanterna eletro3 = new Lanterna();
            Radio eletro4 = new Radio();
        }
    }

    class Televisao
    {
        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public double FrequenciaDoCanal { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
            if (Ligou != null)
            {
                Ligou(this, new EventArgs());
            }
        }
    }

    class Abajur
    {
        public int PotenciaDaLampada { get; set; }

        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Lanterna
    {
        public double PotenciaDaLampada { get; set; }

        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Radio
    {
        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public double FrequenciaDaEstacao { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

}
