using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoTrabalho
{
    public class Venda
    {
        private Comprador comprador;
        private Vendedor vendedor;
        private List<Produto> produtos = new List<Produto>();

        public Venda(Comprador comprador, Vendedor vendedor)
        {
            this.comprador = comprador;
            this.vendedor = vendedor;
        }

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public void RealizarVenda()
        {
            double valorTotal = 0;
            foreach (Produto produto in produtos)
            {
                valorTotal += produto.GetPreco();
            }
            comprador.DiminuirVerba(valorTotal);
            vendedor.CalcularComissao(valorTotal);
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Produtos vendidos:");
            foreach (Produto produto in produtos)
            {
                produto.MostrarAtributos();
            }
            comprador.MostrarAtributos();
            vendedor.MostrarAtributos();
        }
    }
}