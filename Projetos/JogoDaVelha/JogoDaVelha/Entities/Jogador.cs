﻿namespace JogoDaVelha.Entities
{
    public class Jogador
    {
        public string Nome;
        public int vitorias;

        public Jogador(string nome)
        {
            Nome = nome;
            vitorias = 0;
        }

        public void Vitoria()
        {
            vitorias++;
        }
    }
}
