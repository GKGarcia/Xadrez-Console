﻿using System;


namespace tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QntdeMovimentos { get; protected set; }
        public Tabuleiro tab {get; protected set;}

        public Peca(Posicao posicao,Tabuleiro tab,Cor cor)
        {
            this .Posicao = posicao;    
            this .tab = tab;
            this .Cor = cor;
            this.QntdeMovimentos = 0;
        }   
    }
}
