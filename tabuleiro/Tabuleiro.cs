
namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;
        //construtor tabuleiro
        public Tabuleiro(int linha, int colunas)
        {
            linhas = linha;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }
        //Metodo para retornar Peca do tabuleiro
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        //Sobrecarga do metodo que retorna Peca do tabuleiro por posicao
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }
        //Metodo para inserir peca no tabuleiro 
        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new tabuleiroException("Já existe uma peça neste lugar!");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
        //Metodo para retirar peca do tabuleiro
        public Peca retirarPeca(Posicao pos)
        {
            if (peca(pos) == null)
            {
                return null;
            }
            else
            {
                Peca aux = peca(pos);
                aux.posicao = null;
                pecas[pos.linha, pos.coluna] = null;
                return aux;
            }
        }
        //Metodo para validar se existe peca na posicao
        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }
        //metodo para validar se posicao e valida
        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }
        //Metodo para validar posicao e criar Exception personalizada
        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new tabuleiroException("Posição do tabuleiro Inválida!");
            }
        }
    }
}