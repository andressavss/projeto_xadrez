﻿using System;
using Tabuleiro;

namespace Xadrez
{
    internal class Torre : Peca
    {
        public Torre(Cor cor, Tab tab) : base(cor, tab) { }

        public override string ToString()
        {
            return "T";
        }
    }
}
