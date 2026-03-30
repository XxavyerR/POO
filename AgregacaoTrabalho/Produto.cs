using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoTrabalho
{
    public class Produto
    {
        private static int contador = 501;
        private int codigo;
        private string? nome;
        private double preco;

        public void CadastrarProduto(string nome, double preco)
        {
            if (preco > 0)
            {
                this.codigo = ++contador;
                this.nome = nome;
                this.preco = preco;
            }
            else
            {
                Console.WriteLine("Preço inválido, tente novamente.");
            }
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + codigo +
                            "\tNome do produto: " + nome +
                            "\tPreço do produto: " + preco);
        }

        public double GetPreco()
        {
            return preco;
        }

        public string? GetNome()
        {
            return nome;
        }

    }
}