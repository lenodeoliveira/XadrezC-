using System;

namespace tabuleiro
{
    //quando a classe tem pelo menos um método abstrato ela se torna classe abstrata
    abstract class Peca
    {

        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int gteMovimentos { get; set; }
        public Tabuleiro tab { get; protected set; }
        
        public Peca(Tabuleiro tab, Cor cor) {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.gteMovimentos = 0;


        }
         
        public void incrementarQteMovimentos() {

            gteMovimentos++; 

        }
       

        public abstract bool[,] movimentosPossiveis();

    }
    
} 