using System;
using tabuleiro;
using xadrez;
namespace xadrex_console
{
    class Program
    {
        static void Main(string[] args) {

            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarpeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarpeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarpeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                tab.colocarpeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));
                Tela.ImprimirTabuleiro(tab);

            }catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}