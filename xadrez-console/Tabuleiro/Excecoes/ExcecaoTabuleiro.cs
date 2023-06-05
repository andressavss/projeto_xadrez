using System;

namespace Tabuleiro.Excecoes
{
    internal class ExcecaoTabuleiro : Exception
    {
        public ExcecaoTabuleiro(string message) : base(message) { }
    }
}
