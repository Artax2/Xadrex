using tabuleiro;

namespace xadrez {
    internal class Torre : Peca {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) {
        }

        public override string ToString() {
            return "T";
        }

        private bool podeMover(Posicao pos) {
            Peca p = tabuleiro.peca(pos.linha, pos.coluna);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[tabuleiro.linhas, tabuleiro.colunas];
            Posicao pos = new Posicao(0, 0);

            // Acima
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            while (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
                if (tabuleiro.peca(pos.linha, pos.coluna) != null && tabuleiro.peca(pos.linha, pos.coluna).cor != cor) {
                    break;
                }
                pos.linha = pos.linha - 1;
            }

            // Abaixo
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            while (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
                if (tabuleiro.peca(pos.linha, pos.coluna) != null && tabuleiro.peca(pos.linha, pos.coluna).cor != cor) {
                    break;
                }
                pos.linha = pos.linha + 1;
            }

            // Direita
            pos.definirValores(posicao.linha, posicao.coluna + 1);
            while (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
                if (tabuleiro.peca(pos.linha, pos.coluna) != null && tabuleiro.peca(pos.linha, pos.coluna).cor != cor) {
                    break;
                }
                pos.coluna = pos.coluna + 1;
            }

            // Esquerda
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            while (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
                if (tabuleiro.peca(pos.linha, pos.coluna) != null && tabuleiro.peca(pos.linha, pos.coluna).cor != cor) {
                    break;
                }
                pos.coluna = pos.coluna - 1;
            }

            return mat;
        }
    }
}
