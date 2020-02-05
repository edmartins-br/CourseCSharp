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
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.Write("Origem: "); 
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }

                Tela.imprimirTabuleiro(partida.tab);
                Console.ReadLine();
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine("ERRO: " + e.Message);
            }
            
            Posicao P;
            P = new Posicao(3, 4);

            Console.WriteLine("Posição: " + P);
            
        }
    }
}
