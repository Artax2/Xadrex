using System.Net.Http.Headers;

using xadrex_console.tabuleiro;
using xadrex_console.xadrex;
namespace xadrex_console {
    internal class Program {
        static void Main(string[] args) {
            try {
                // TAMANHO DO TABULEIRO 
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 9));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                Tela.ImprimirTabuleiro(tab);
                Console.ReadLine();
            }
            catch(TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
