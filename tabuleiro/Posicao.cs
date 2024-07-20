namespace tabuleiro
{
    class Posicao
    {
        public int linha { get; set; }
        public int coluna { get; set; }
        //Construtor da Posicao recebendo linha e coluna
        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public void definirValores(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;    
        }
        override public string ToString()
        {
            return linha + "," + coluna;
        }
    }
}