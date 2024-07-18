using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            colocarPecas();
        }
        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }
        public void colocarPecas()
        {
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('a', 1).toPosicao());
            tab.colocarPeca(new Cavalo(tab, Cor.Preta), new PosicaoXadrez('a', 2).toPosicao());
            tab.colocarPeca(new Bispo(tab, Cor.Preta), new PosicaoXadrez('a', 3).toPosicao());
            tab.colocarPeca(new Dama(tab, Cor.Branca), new PosicaoXadrez('a', 4).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Branca), new PosicaoXadrez('a', 5).toPosicao());
            tab.colocarPeca(new Bispo(tab, Cor.Preta), new PosicaoXadrez('a', 6).toPosicao());
            tab.colocarPeca(new Cavalo(tab, Cor.Preta), new PosicaoXadrez('a', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('a', 8).toPosicao());
            for (int c = 0; c < tab.colunas; c++)
            {
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao('b', c+1));
            }
        }

    }
}