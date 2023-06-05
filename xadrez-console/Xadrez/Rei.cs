using System;
using Tabuleiro;

namespace Xadrez
{
    internal class Rei : Peca
    {
        public Rei(Cor cor, Tab tab) : base(cor, tab) { }

        public override string ToString()
        {
            return "R";
        }
    }
}
