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
            Posicao P;
            P = new Posicao(3, 4);

            Console.WriteLine(P);
            Console.ReadLine();

            Tabuleiro tab;
            tab = new Tabuleiro(8, 8);
            Console.WriteLine(tab);
            Console.ReadLine();
        }
    }
}
