using System;
using AgregacaoTrabalho;

Comprador comprador = new Comprador();
comprador.setVerba(5000.00);

Vendedor vendedor = new Vendedor();
vendedor.setComissao(0);

Produto produto1 = new Produto();
produto1.CadastrarProduto("Notebook", 3500.00);

Produto produto2 = new Produto();
produto2.CadastrarProduto("Smartphone", 1500.00);

Venda venda = new Venda(comprador, vendedor);
venda.AdicionarProduto(produto1);
venda.AdicionarProduto(produto2);

venda.RealizarVenda();

venda.MostrarAtributos();