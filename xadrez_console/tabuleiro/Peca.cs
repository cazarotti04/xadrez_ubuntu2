using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class Peca
    {
        public Posicao pos { get; set; }
        public Tabuleiro tab { get; protected set; }
        public Cor cc { get; protected set; }
        public int qtmov { get; protected set; }

        public Peca(Tabuleiro tab, Cor cc)
        {
            this.pos = null;
            this.tab = tab;
            this.cc = cc;
            this.qtmov = 0;
        }
    }
}
