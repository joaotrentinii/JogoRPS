using JogoRPS.JogoRPS.Business;
using JogoRPS.JogoRPS.Types;
using System;

namespace JogoRPS
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDoisJogadores = ListaJogadores.ListaDoisJogadores;

            Jogo jogo = new Jogo();
            Jogador jogadorVencedor = jogo.RpsGameWinner(listaDoisJogadores);
            Console.WriteLine(string.Format("Jogador {0} venceu com a jogada {1}", jogadorVencedor.Nome, jogadorVencedor.Jogada));
            Console.ReadKey();
        }
    }
}
