using System.Collections.Generic;

namespace JogoRPS.JogoRPS.Types
{
    public static class ListaJogadores
    {
        public static List<Jogador> ListaDoisJogadores
        {
            get
            {
                return new List<Jogador>
                {
                    new Jogador
                    {
                        Nome = "Armando",
                        Jogada = "P"
                    },
                    new Jogador
                    {
                        Nome = "Dave",
                        Jogada = "S"
                    }
                };
            }
        }
    }
}
