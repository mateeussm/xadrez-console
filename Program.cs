﻿using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                Console.WriteLine();

            }
            catch (tabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // PosicaoXadrez pos = new PosicaoXadrez('h',1);
            // Console.WriteLine(pos);
            // Console.WriteLine(pos.toPosicao());

        }
    }
}