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

        // VERIFICA SE A PEÇA EXISTI
        public bool existirPeca(Posicao pos) {
            ValidarPosicao(pos);
            return peca(pos.linha, pos.coluna) != null;
        }

        public void ColocarPeca(Peca p, Posicao pos) {
            // O ATO DE COLOCAR A PEÇA NO TABULEIRO SE BASEIA EM DEFINIR A POSIÇÃO DA MATRIX A PARTIR DA POSIÇÃO DA LINHA E DA COLUNA
            if (existirPeca(pos)) {
                throw new TabuleiroException("Já existe uma peça nessa posição");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        // MÉTODO DE VERIFICAÇÃO SE O TAMANHO DO TABULEIRO FOR EXCEDIDO OU MENOR DO QUE 0
        public bool PosicaoValida(Posicao pos) {
            if (pos.linha < 0 || pos.linha >= 8 || pos.coluna < 0 || pos.coluna >= 8) {
                return false;
            }
            else {
                return true;
            }
        }

        // CAPTURA UMA EXCEÇÃO CASO A POSIÇÃO NÃO SEJA VÁLIDA
        public void ValidarPosicao(Posicao pos) {
            if (!PosicaoValida(pos)) {
                throw new TabuleiroException("Posição inválida");
            }
        }
    }
}
