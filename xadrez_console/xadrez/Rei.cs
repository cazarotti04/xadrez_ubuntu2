using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cc) : base(tab,cc)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
