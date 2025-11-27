using System.Net.Http.Headers;

namespace xadrex_console.tabuleiro {
    internal class Tabuleiro {
        public int linhas { get; set; }
        public int colunas { get; set; }
        // MATRIX BIDIMENSIONAL
        /*      coluna    1       2
          linha ______ _______ _______
            1   ______ _______ _______
            2   ______ _______ _______
        */
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas) {
            this.linhas = linhas;
            this.colunas = colunas;
            // RECEBE COMO PARÂMETROS AS LINHAS E COLUNAS
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna) {
            return pecas[linha, coluna];
        }

        public void ColocarPeca(Peca p, Posicao pos) {
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
    }
}
