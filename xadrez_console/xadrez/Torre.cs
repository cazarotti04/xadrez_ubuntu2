using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
		public Torre(Tabuleiro tab, Cor cc) : base(tab, cc)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
