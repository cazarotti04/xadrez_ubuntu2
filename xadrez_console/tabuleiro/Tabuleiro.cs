using System;


namespace tabuleiro
{
    class Tabuleiro
    {
        private Peca[,] pecas;
        public int linhas { get; set; }
        public int colunas { get; set; }

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

		public Peca peca(Posicao pos){
			return pecas [pos.linha, pos.coluna];
		}

		public bool existePeca(Posicao pos){
			validarPosicao (pos);
			return peca (pos) != null;
		}

        public Peca pp(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        public void colocarPeca(Peca p, Posicao pos)
        {
			if (existePeca (pos)) {
				throw new TabuleiroException ("Ja existe uma peca nesta posicao!");
			}
			pecas[pos.linha, pos.coluna] = p;
			p.pos = pos;
            
        }

		public bool posicaovalida(Posicao pos){
			if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas) {
				return false;
			} else {
				return true;
			}
		}

		public void validarPosicao(Posicao pos){
			if (!posicaovalida (pos)) {
				throw new TabuleiroException ("Posição Inválida!");
			}
		}

    }
}
