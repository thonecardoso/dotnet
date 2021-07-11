using System;

namespace ByteBank.SistemaAgencia
{
    public class Lista<T>
    {
        private T[] _itens;
        private int _proximaPosicao;
        
        public T this[int indice]
        {
            get 
            {
                return GetItemNoIndice(indice);
            }
        }

        public Lista(int capacidadeInicial = 5)
        {
            _itens = new T[capacidadeInicial];
            _proximaPosicao = 0;
        }
        public void Adicionar(T item)
        {
            VerificarCapacidade(_proximaPosicao);
            //Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
            
           _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        } 
        
        public void AdicionarVarios(params T[] itens)
        {
            foreach(T item in itens) 
            {
                Adicionar(item);
            }
        }
        
        public void Remover(T item)
        { 
            int indiceItem = -1;

            for(int i = 0; i < _proximaPosicao; i++)
            { 
                T itemAtual = _itens[i];

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
            // _itens[_proximaPosicao] = null;
        } 
        
        public T GetItemNoIndice(int indice)
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
            
            T[] novoArray = new T[novoTamanho];
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
                T item = _itens[i];
                Console.WriteLine(item);
            }
        }
    }
}