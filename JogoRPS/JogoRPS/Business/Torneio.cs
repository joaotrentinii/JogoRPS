using JogoRPS.JogoRPS.Types;
using System.Collections.Generic;

namespace JogoRPS.JogoRPS.Business
{
    public class Torneio
    {
        private List<Jogador> _ganhadores = new List<Jogador>();
        private List<Jogador> _jogadores = new List<Jogador>();
        private Jogador _ganhador;

        public Jogador RpsTournamentWinner(List<Jogador[][]> jogadores)
        {                        
            PercorrerJogadores(jogadores);
            PercorrerGanhadores();

            return this._ganhador;
        }

        private void PercorrerJogadores(List<Jogador[][]> jogadores)
        {
            for (int l = 0; l < jogadores.Count; l++)
            {
                for (int c = 0; c < jogadores[l].Length; c++)
                {
                    for(int i = 0; i < jogadores[l][c].Length; i++)
                    {
                        this._jogadores.Add(jogadores[l][c][i]);
                    }
                    
                    this._ganhadores.Add(EncontrarVencedor());
                }
            }
        }

        private void PercorrerGanhadores()
        {
            var ganhadores = new List<Jogador>();
            foreach(Jogador jogador in this._ganhadores)
            {
                this._jogadores.Add(jogador);

                if (this._jogadores.Count == 2)
                    ganhadores.Add(EncontrarVencedor());
            }

            this._jogadores = ganhadores;
            this._ganhador = EncontrarVencedor();
        }

        private Jogador EncontrarVencedor()
        {
            var ganhador = Jogo.RpsGameWinner(this._jogadores);
            this._jogadores.Clear();

            return ganhador;
        }
    }
}
