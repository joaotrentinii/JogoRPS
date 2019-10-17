namespace JogoRPS.JogoRPS.Types
{
    public class Jogador
    {
        public string Nome { get; set; }
        public string Jogada { get; set; }

        public Jogador(string nome, string jogada)
        {
            this.Nome = nome;
            this.Jogada = jogada;
        }

        public Jogador() { }
        
    }
}
