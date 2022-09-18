using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Tabuleiro
    {

        public int linhas { get; set; }
        public int colunas { get; set; }
        public Tabuleiro tab { get; protected set; }

        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.tab = tab;
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }
    }
}
