using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoTrabalho
{
    public class Produto
    {
        public int codigo;
        public string? nome;
        public double preco;

        public void MostrarAtributos()
        {
            Console.WriteLine("Código"+ codigo +
                            "\tNome do produto: " + produto +
                            "\tPreço do produto: " + preco

            );
        }

    }
}