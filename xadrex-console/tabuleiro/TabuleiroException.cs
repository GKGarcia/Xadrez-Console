﻿using System;
using System.Collections.Generic;


namespace tabuleiro
{
    internal class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg){ 
        }
    }
}
