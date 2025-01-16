namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qteMovimentos = 0;
        }

        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis(); 
        // essa classe por ser genérica não é possivel aplicar a funcionalidade, precisaria ser expecífico
        // então o método se tornando abstrato a classe se torna abstrata
        // o método será aplicado para as peças do tipo Peca em expecífico
      
    }
}
