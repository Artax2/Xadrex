using xadrex_console.tabuleiro;

namespace xadrex_console.xadrex {
    internal class Rei : Peca{

        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) {
        }

        public override string ToString() {
            return "R";
        }

    }
}
