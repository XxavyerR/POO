// Main()
using ConstrutorConta;
Conta c1 = new Conta(); //chamdada do construtor padrão
c1.MostrarAtributos();
Console.WriteLine(Conta.Contador);
//chamada  do construtor com 1 parâmetro
Conta c2 = new Conta(1);
c2.MostrarAtributos();
Console.WriteLine(Conta.Contador);

Conta c3 = new Conta("Anna", 100);
c3.MostrarAtributos();
Console.WriteLine("Qtde:" + Conta.Contador);