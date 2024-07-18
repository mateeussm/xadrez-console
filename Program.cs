using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Cavalo(tab, Cor.Preta), new Posicao(0, 1));
            tab.colocarPeca(new Bispo(tab, Cor.Preta), new Posicao(0, 2));
            tab.colocarPeca(new Dama(tab, Cor.Preta), new Posicao(0, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 4));
            tab.colocarPeca(new Bispo(tab, Cor.Preta), new Posicao(0, 5));
            tab.colocarPeca(new Cavalo(tab, Cor.Preta), new Posicao(0, 6));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 7));
            for(int c = 0;c < tab.colunas;c++)
            {
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, c));
            }
            Tela.imprimirTabuleiro(tab);

        }
    }
}