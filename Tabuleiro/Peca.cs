using System;
using System.Collections.Generic;
using System.Text;
using xadrez_console.Tabuleiro;

namespace xadrez_console.tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; set; }
        public int QtdeMovimentos { get; set; }
        public tabuleiro.Tabuleiro Tabuleiro { get; set; }

        public Peca(Posicao posicao, Cor cor, tabuleiro.Tabuleiro tabuleiro)
        {
            Posicao = posicao;
            Cor = cor;
            Tabuleiro = tabuleiro;
            QtdeMovimentos = 0;
        }
    }
}
