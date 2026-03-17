using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        private int numero;
        private string? titular;
        private double saldo;
        private static int contador;
        public static contador;
        public int Contador{//
            get{
                return contador;
            }
        }
        public Conta()
        {
            //nao tem parametro e é concedido de forma automática a você
            contador ++;
        }
        public Conta(int numero)
        { //atributo = parametro
            this.numero = numero;
            contador++;
        }
        public Conta(string? titular, double saldo)
        { //atributo = parametro
            this.titular = titular;
            this.saldo = saldo;
            contador++;
        }
        public void MostrarAtributos(){
            Console.WriteLine("\tNumero: "+ numero +
                        "\ttitular: " + titular +
                        "\tsaldo: " + saldo);
        }
    }
}
