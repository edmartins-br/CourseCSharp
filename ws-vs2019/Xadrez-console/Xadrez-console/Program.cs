using System;
using tabuleiro;
using xadrez;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
            Console.WriteLine();
            */


            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.imprimirPartida(partida);

                        

                        Console.WriteLine();

                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                        //validar posicao de origem
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.WriteLine();

                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                        partida.validarPosicaoDeDestino(origem, destino);

                        partida.realizaJogada(origem, destino);
                    }

                    catch (TabuleiroException e)
                    {
                        Console.WriteLine("ATENÇÃO: " + e.Message);
                        Console.ReadLine();
                    }
                }

                Console.Clear();
                Tela.imprimirPartida(partida);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine("ATENÇÃO: " + e.Message);
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("OCORREU UM ERRO INESPERADO: " + e.Message);
            }

            Posicao P;
            P = new Posicao(3, 4);

            Console.WriteLine("Posição: " + P);

        }
    }
}
