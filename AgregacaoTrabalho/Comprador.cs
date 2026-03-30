using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoTrabalho
{
    public class Comprador
    {
        private double verba;

        public void setVerba(double valor)
        {
            verba = valor;
        }

        public double GetVerba()
        {
            return verba;
        }

        public void DiminuirVerba(double valor)
        {
            verba -= valor;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Verba restante R$:" + verba);
        }
    }
}