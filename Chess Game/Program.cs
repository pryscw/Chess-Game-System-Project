using System;
using System.Globalization;
using System.Collections.Generic;
using tabuleiro;

namespace Chess_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8,8);
            Tela.imprimirTabuleiro(tab);
        }
    }
}
