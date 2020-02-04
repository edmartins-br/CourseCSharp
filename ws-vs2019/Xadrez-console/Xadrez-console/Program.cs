using System;
using tabuleiro;
using xadrez;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            Console.WriteLine(pos);
            Console.WriteLine();
            
            /*
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 7));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 4));
                //tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 0));

                Tela.imprimirTabuleiro(tab);

                Console.ReadLine();
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine("ERRO: " + e.Message);
            }
            
            Posicao P;
            P = new Posicao(3, 4);

            Console.WriteLine("Posição: " + P);
            */
        }
    }
}
