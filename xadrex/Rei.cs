using tabuleiro;

namespace xadrez {
    class Rei : Peca {

        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) {
        }

        public override string ToString() {
            return "R";
        }

        private bool podeMover(Posicao pos) {
            Peca p = tabuleiro.peca(pos.linha, pos.coluna);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[tabuleiro.linhas, tabuleiro.colunas];

            Posicao pos;

            // Acima
            pos = new Posicao(posicao.linha - 1, posicao.coluna);
            if (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            // Nordeste
            pos = new Posicao(posicao.linha - 1, posicao.coluna + 1);
            if (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            // Direita 
            pos = new Posicao(posicao.linha, posicao.coluna + 1);
            if (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            // Sudeste
            pos = new Posicao(posicao.linha + 1, posicao.coluna + 1);
            if (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            // Abaixo
            pos = new Posicao(posicao.linha + 1, posicao.coluna);
            if (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            // Sudoeste
            pos = new Posicao(posicao.linha + 1, posicao.coluna - 1);
            if (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            // Esquerda
            pos = new Posicao(posicao.linha, posicao.coluna - 1);
            if (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            // Noroeste
            pos = new Posicao(posicao.linha - 1, posicao.coluna - 1);
            if (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;
        }
    }
}
