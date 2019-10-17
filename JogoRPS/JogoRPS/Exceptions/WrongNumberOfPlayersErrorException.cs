using System;

namespace JogoRPS.JogoRPS.Exceptions
{
    class WrongNumberOfPlayersErrorException : Exception
    {
        public string _jogador { get; }

        public WrongNumberOfPlayersErrorException()
        {
        }

        public WrongNumberOfPlayersErrorException(string message)
            :base(message)
        {
        }

        public WrongNumberOfPlayersErrorException(string message, Exception inner)
            :base(message, inner)
        {
        }        
    }
}
