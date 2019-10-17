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
            var jogadorVencedor = Jogo.RpsGameWinner(listaDoisJogadores);
            Console.WriteLine(string.Format("Jogador {0} venceu com a jogada {1}", jogadorVencedor.Nome, jogadorVencedor.Jogada));
            Console.ReadKey();

            var listaJogadoresTorneio = ListaJogadores.ListaJogadoresTorneio;
            var torneio = new Torneio();
            var ganhadorTorneio = torneio.RpsTournamentWinner(listaJogadoresTorneio);
            Console.WriteLine(string.Format("Jogador {0} venceu o torneio com a jogada {1}", ganhadorTorneio.Nome, ganhadorTorneio.Jogada));
            Console.ReadKey();
        }
    }
}
