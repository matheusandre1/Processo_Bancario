using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoMs.Titular;

namespace BancoMs
{
    public class ContaCorrente
    {

        
        public Cliente Titular{get; set;}
        public string conta { get; set; }
        
        public int numero_agencia { get; set; }
        public string nome_agencia { get; set; }
        private double saldo { get; set; }

        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }
        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                saldo += valor;
            }


        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }

        }

        //public void DefinirSaldo(double valor)
        //{
        //    if( valor < 0)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        this.saldo = valor;
        //    }
        //}

        //public double obterSaldo()
        //{
        //    return saldo;
        //}

        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if(value< 0)
                {
                    return ;
                }
                else
                {
                    saldo = value;
                }
            }
            
        }


    }
}
