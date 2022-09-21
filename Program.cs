using System;
using tabuleiro;
using Xadrez;
using Xadrez_Console.tabuleiro;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().ToPosicao();

                    bool[,] posicoesPosiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPosiveis);
                    Console.WriteLine();

                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().ToPosicao();

                    partida.executaMovimento(origem, destino);
                }

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
        }
    }
}
