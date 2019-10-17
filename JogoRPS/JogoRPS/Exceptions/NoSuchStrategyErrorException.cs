using System;

namespace JogoRPS.JogoRPS.Exceptions
{
    public class NoSuchStrategyErrorException: Exception
    {
        public NoSuchStrategyErrorException()
        {
        }

        public NoSuchStrategyErrorException(string message)
            : base(message)
        {
        }

        public NoSuchStrategyErrorException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
