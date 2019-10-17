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

        public static List<Jogador[][]> ListaJogadoresTorneio
        {
            get
            {
                return new List<Jogador[][]>
                {
                    new[]
                    {
                        new[]
                        {
                            new Jogador("Armando", "P"),
                            new Jogador("Dave", "S")
                        },
                        new[]
                        {
                            new Jogador("Richard", "R"),
                            new Jogador("Michael", "S")
                        }
                    },
                    new[]
                    {
                        new[]
                        {
                            new Jogador("Allen", "S"),
                            new Jogador("Omer", "P")
                        },
                        new[]
                        {
                            new Jogador("David E.", "R"),
                            new Jogador("Richard X.", "P")
                        }
                    }
                };
            }
        }
    }
}
