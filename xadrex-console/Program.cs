using System;
using tabuleiro;
using xadrez;
namespace xadrex_console
{
    class Program
    {
        static void Main(string[] args) {

           PosicaoXadrez pos = new PosicaoXadrez('a',1);

            Console.WriteLine(pos);

            Console.ReadLine();
        }
    }
}