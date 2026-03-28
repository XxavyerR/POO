using AgregacaoConta;
internal class Program
{
    private static void Main(string[] args)
    {
        Cliente cli = new Cliente();
        cli.Nome = "Ana";
        cli.Rg = 100;
        cli.Telefone = 999;

        Conta c1 = new Conta();
        c1.Numero = 1;
        c1.Saldo = 1500;
        // Titular é um atributo/Propriedade que quando recebe 
        // o objeto cli, o Titular passa a ser um objeto Cliente
        // e efetiva a agregação
        c1.Titular = cli;

        Conta c2 = new Conta();
        c2.Numero = 2;
        c2.Saldo = 3400;
        c2.Titular = new Cliente();
        c2.Titular.Nome = "Bia";
        c2.Titular.Rg = 300;
        c2.Titular.Telefone = 9998;

    }
}