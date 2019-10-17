using JogoRPS.JogoRPS.Exceptions;
using JogoRPS.JogoRPS.Types;
using JogoRPS.Resources;
using System;
using System.Collections.Generic;

namespace JogoRPS.JogoRPS.Business
{
    public class Jogo
    {
        private static int _QUANTIDADE_JOGADORES = 2;
        private static int JOGADOR_UM = 0;
        private static int JOGADOR_DOIS = 1;
        
        public static Jogador RpsGameWinner(List<Jogador> jogadores)
        {            
            if (jogadores.Count != _QUANTIDADE_JOGADORES)
                throw new WrongNumberOfPlayersErrorException(ExceptionMessages.NumeroJogadoresInvalido);

            ValidarJogada(jogadores);
            return CalcularGanhador(jogadores);
        }
        
        private static void ValidarJogada(List<Jogador> jogadores)
        {
            foreach (Jogador jogador in jogadores)
            {
                if (jogador.Jogada.ToUpper() != "R" && jogador.Jogada.ToUpper() != "P" && jogador.Jogada.ToUpper() != "S")
                    throw new NoSuchStrategyErrorException(String.Format(ExceptionMessages.JogadaInvalida, jogador.Nome));
            }
        }

        //R bate S; S bate P; e P bate R
        private static Jogador CalcularGanhador(List<Jogador> jogadores)
        {
            var jogadaJogadorUm = jogadores[JOGADOR_UM].Jogada.ToUpper();
            var jogadaJogadorDois = jogadores[JOGADOR_DOIS].Jogada.ToUpper();

            if (jogadaJogadorUm == jogadaJogadorDois || 
                jogadaJogadorUm == "R" && jogadaJogadorDois == "S" || 
                jogadaJogadorUm == "S" && jogadaJogadorDois == "P" || 
                jogadaJogadorUm == "P" && jogadaJogadorDois == "R")
            {
                return jogadores[JOGADOR_UM];
            }

            return jogadores[JOGADOR_DOIS];
        }
    }
}
