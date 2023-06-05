using System;

namespace Tabuleiro
{
    internal class Peca 
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tab Tab { get; protected set; }  

        public Peca(Posicao posicao, Cor cor, Tab tab)
        {
            this.Posicao = posicao;
            this.Cor = cor;
            this.Tab = tab;
            this.QteMovimentos = 0;
        }
    }
}
