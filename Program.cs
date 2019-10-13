﻿using System;
using tabuleiro;
using xadrez;

namespace XadrezC_
{
    class Program
    {
        static void Main(string[] args)
        {
             try {

           PartidadeXadrez partida = new PartidadeXadrez();

           while (!partida.terminada) {
            try {  

            Console.Clear();  
            Tela.imprimirTabuleiro(partida.tab);  
            Console.WriteLine();
            Console.WriteLine("Turno: " + partida.turno);
            Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);

            Console.WriteLine();    
            Console.Write("Origem: ");   
            Posicao origem = Tela.lerPosicaoXadrez().ToPosicao();
            partida.validarPossicaoDeOrigem(origem);
            
            bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

            Console.Clear();
            Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);  
            
            Console.WriteLine(); 
            Console.Write("Destino: ");
            Posicao destino = Tela.lerPosicaoXadrez().ToPosicao();
            partida.validarPossicaoDeDestino(origem, destino);
            
            partida.realizaJogada(origem, destino);
            
            }
            catch(TabuleiroException e) {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
         
          }


           
           Tela.imprimirTabuleiro(partida.tab);

          }
          catch(TabuleiroException e){

              System.Console.WriteLine(e.Message);

          }
           Console.ReadLine(); 
          
        }
    }
}
