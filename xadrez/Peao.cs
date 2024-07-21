using tabuleiro;

namespace xadrez
{
    class Peao : Peca
    {

        public Peao(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //acima 2 casas
            int count = 0;
            if (cor == Cor.Branca)
            {
                pos.definirValores(posicao.linha - 1, posicao.coluna);
            }
            else
            {
                pos.definirValores(posicao.linha + 1, posicao.coluna);
            }
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor || count >= 1)
                {
                    break;
                }
                if (cor == Cor.Branca)
                {
                    pos.linha -= 1;
                }
                else
                {
                    pos.linha += 1;
                }
                count += 1;
            }
            return mat;
        }
        public override string ToString()
        {
            return "p";
        }
    }
}