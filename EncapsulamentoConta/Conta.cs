using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    public class Conta
    {
        //declaração de atributos
        private int numero;
        private string? titular;
        private double saldo;

        public int Numero //propriedade
        {
            set
            {   //value representa qualquer tipo
                this.numero = value;
            }
            get
            {
                return this.numero;
            }
        }
        public string? Titular
        {
            get
            {
                return.this.titular
            }
            set
            {
                this.titular = value;
            }
        }

        public double saldo
        {
            set
            {
                this.saldo = value;
            }
            get
            {
                return this.saldo
            }
        }

        //declaração de funções/métodos
        public void Sacar(double valorSacar){
            saldo -= valorSacar;
        }
        public void Depositar(double valorDeposito){
            saldo = saldo + valorDeposito;
        }
        public void MostrarAtributos(){
            Console.WriteLine("Número: "+ numero +
                        "\tTitular: " + titular +
                        "\tSaldo: " + saldo);
        }
    }
}