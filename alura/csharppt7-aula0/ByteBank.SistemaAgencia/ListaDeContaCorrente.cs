using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;
        
        public ContaCorrente this[int indice]
        {
            get 
            {
                return GetItemNoIndice(indice);
            }
        }

        public ListaDeContaCorrente(int capacidadeInicial = 5)
        {
            _itens = new ContaCorrente[capacidadeInicial];
            _proximaPosicao = 0;
        }
        public void Adicionar(ContaCorrente item)
        {
            VerificarCapacidade(_proximaPosicao);
            //Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
            
           _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        } 
        
        public void AdicionarVarios(params ContaCorrente[] itens)
        {
            foreach(ContaCorrente conta in itens) 
            {
                Adicionar(conta);
            }
        }
        
        public void Remover(ContaCorrente item)
        { 
            int indiceItem = -1;

            for(int i = 0; i < _proximaPosicao; i++)
            { 
                ContaCorrente itemAtual = _itens[i];

                if (itemAtual.Equals(item))
                { 
                    indiceItem = i;
                    break;
                } 
            } 
            
            for(int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            } 
            
            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        } 
        
        public ContaCorrente GetItemNoIndice(int indice)
        {
            if(indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _itens[indice];
        }
        
        public int Tamanho 
        { 
            get 
            {
                return _proximaPosicao; 
            }
        } 
        
        private void VerificarCapacidade(int tamanhoNecessario)
        { 
            if (_itens.Length> tamanhoNecessario)
            { 
                return; 
            } 
            
            int novoTamanho = _itens.Length * 2;
            
            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];
            //Console.WriteLine("Aumentando capacidade da lista!");

            for(int indice = 0; indice < _itens.Length; indice++)
            { 
                novoArray[indice] = _itens[indice];
            }

            _itens = novoArray;
        }
        
        public void EscreverListaNaTela()
        {
            for (int i = 0; i < _proximaPosicao; i++)
            { 
                ContaCorrente conta = _itens[i];
                Console.WriteLine($"Conta no índice {i}: numero {conta.Agencia} {conta.Numero}");
            }
        }
    }
}