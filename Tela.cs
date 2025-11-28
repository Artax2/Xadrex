using tabuleiro;

using xadrex;

namespace xadrex_console {
    internal class Tela {
        public static void ImprimirTabuleiro(Tabuleiro tab) {
            // PADRÃO USADO PARA PERCORRER MATRIZES
            for (int i = 0; i < tab.linhas; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++) {
                    // CASO NÃO TENHA PEÇA
                    if (tab.peca(i, j) == null) {
                        Console.Write("- ");
                    }
                    // CASO TENHA PEÇA
                    else {
                        Tela.ImprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

         public static void ImprimirPeca(Peca peca) {
            if (peca.cor == Cor.Branca) {
                Console.Write(peca);
            }
            else {
                ConsoleColor aux = Console.ForegroundColor;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }

        public static PosicaoXadrex lerPosicaoXadrex() {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrex(coluna, linha);
        }
    }
}
