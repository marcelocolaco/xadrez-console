using System;
using System.Collections.Generic;
using System.Text;
using xadrez_console.Tabuleiro;

namespace xadrez_console.tabuleiro
{
    public class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;


        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[Linhas, Colunas];


        }

        Tabuleiro t = new Tabuleiro(3, 4);
    }
}
