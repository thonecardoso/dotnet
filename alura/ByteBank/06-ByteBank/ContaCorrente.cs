using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value >= 0)
                {
                    _saldo = value;
                }
            }
        }

        public void SetSaldo(double saldo)
        {
            if(saldo >= 0)
            {
                this._saldo = saldo;
            }
        }

        public double GetSaldo()
        {
            return this._saldo;
        }

        public bool Sacar(double valor)
        {
            if(this._saldo < valor)
            {
                return false;
            }
            
            this._saldo -= valor;
            return true;
            
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            
            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
            
        }

    }
}
