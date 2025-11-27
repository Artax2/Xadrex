using xadrex_console.tabuleiro;
namespace xadrex_console {
    internal class Program {
        static void Main(string[] args) {
            Tabuleiro tab = new Tabuleiro(8, 8);
            Tela.ImprimirTabuleiro(tab);
            Console.ReadLine();
        }
    }
}
