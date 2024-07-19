namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }
        //Construtor da Peca
        public Peca(Tabuleiro tab, Cor cor)
        {
            posicao = null;
            this.tab = tab;
            this.cor = cor;
            qteMovimentos = 0;
        }
        //Metodo para incrementar quantidade de movimentos na Peca
        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }

    }
}