namespace BatalhaNaval.Entities
{
    public class Jogador
    {
        public string nome;
		public string senha;
        public int vitorias;
        public int pontuacao;

        public Jogador(string nome)
        {
            Nome = nome;
            vitorias = 0;
            pontuacao = 0;
        }

        public void Vitoria()
        {
            vitorias++;
        }
    }
}
