using xadrex_console.tabuleiro;

namespace xadrex_console {
    internal class Tela {
        public static void ImprimirTabuleiro(Tabuleiro tab) {
            // PADRÃO USADO PARA PERCORRER MATRIZES
            for (int i = 0; i < tab.linhas; i++) {
                for (int j = 0; j < tab.colunas; j++) {
                    // CASO NÃO TENHA PEÇA
                    if (tab.peca(i, j) == null) {
                        Console.Write("- ");
                    }
                    // CASO TENHA PEÇA
                    else {
                        Console.Write(tab.peca(i, j) + " ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
