using tabuleiro;

namespace xadrez
{
    class Bispo : Peca
    {

        public Bispo(Tabuleiro tab, Cor cor) : base(tab, cor)
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

            //ne
            pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                for (int i = pos.linha; i <= tab.linhas; i--)
                {
                    for (int j = posicao.coluna; j <= tab.colunas; j++)
                    {
                        pos.coluna = j;
                    }
                    pos.linha = i;
                }
            }
            //se
            pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                for (int i = pos.linha; i <= tab.linhas; i++)
                {
                    for (int j = pos.coluna; j <= tab.colunas; j++)
                    {
                        pos.coluna = j;
                    }
                    pos.linha = i;
                }
            }
            //so
            pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                for (int i = pos.linha; i <= tab.linhas; i++)
                {
                    for (int j = pos.coluna; j <= tab.colunas; j++)
                    {
                        pos.coluna = j;
                    }
                    pos.linha = i;
                }
            }
           //no
            pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                for (int i = pos.linha; i <= tab.linhas; i++)
                {
                    for (int j = pos.coluna; j <= tab.colunas; j++)
                    {
                        pos.coluna = j;
                    }
                    pos.linha = i;
                }
            }
            return mat;
        }
        public override string ToString()
        {
            return "B";
        }
    }
}