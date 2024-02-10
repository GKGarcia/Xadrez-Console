﻿using System;
using tabuleiro;
using xadrez;
namespace xadrex_console
{
    class Program
    {
        static void Main(string[] args) {

            
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {

                try
                {
                    Console.Clear();
                    Tela.imprimirPartida(partida);

                    Console.WriteLine();
                    Console.Write("Origem:");
                    Posicao origem = Tela.lerPosicaoXadrez().ToPosicao();
                    partida.validaPosicaoDeOrigem(origem);

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino:");
                    Posicao destino = Tela.lerPosicaoXadrez().ToPosicao();
                    partida.validarPosicaoDeDestino(origem, destino);

                    partida.realizaJogada(origem, destino);
                   
                }
                catch (TabuleiroException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
    }
}