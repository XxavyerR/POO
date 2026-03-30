using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoTrabalho
{
    public class Vendedor
    {
        private double comissao;

        public void setComissao(double valor)
        {
            comissao = valor;
        }

        public double GetComissao()
        {
            return comissao;
        }

        public void CalcularComissao(double valorVenda)
        {
            comissao += valorVenda * 0.02;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Comissão R$:" + comissao);
        }
    }
}