﻿using System;
using System.Diagnostics.CodeAnalysis;
using tabuleiro;
using xadrex_console;

namespace xadrez
{
    internal class PartidaDeXadrez
    {
        public Tabuleiro tab { get;private set; }
        public int turno { get; private set; }
        public Cor jogadorAtual{ get; private set; }
        public bool termida {  get; private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            termida = false;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem,Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQntdeMovimentos();
            tab.retirarPeca(destino);
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p,destino);
        }

        public void realizaJogada(Posicao origem,Posicao destino)
        {
            executaMovimento(origem,destino);
            turno++;
            mudaJogador();
        }

        public void validaPosicaoDeOrigem(Posicao pos)
        {
            if(tab.peca(pos) == null)
            {
                throw new TabuleiroException("Não existem peça na posição de origem escolhida!");
            }
            if(jogadorAtual != tab.peca(pos).cor)
            {
                throw new TabuleiroException("A peça de origem escolhida não é sua!");
            }
            if (!tab.peca(pos).existeMovimentosPossiveis())
            {
                throw new TabuleiroException("Não há movimentos possiveis para a peça de origem escolhida!");
            }
        }

        public void validarPosicaoDeDestino(Posicao origem,Posicao destino)
        {
            if (!tab.peca(origem).podeMoverPara(destino))
            {
                throw new TabuleiroException("Posição de destino invalida!");
            }

        }

        private void mudaJogador()
        {
            if(jogadorAtual == Cor.Branca)
            {
                jogadorAtual = Cor.Preta;
            }
            else
            {
                jogadorAtual = Cor.Branca;
            }
        }
        private void colocarPecas()
        {
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 1).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 2).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('d', 2).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 2).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 1).ToPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Branca), new PosicaoXadrez('d', 1).ToPosicao());

            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 7).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 8).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('d', 7).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('e', 7).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('e', 8).ToPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Preta), new PosicaoXadrez('d', 8).ToPosicao());

        }
    }

 }
