using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Entities
{
    public class Jogador
    {
        public string nomeJogador { get; set; }
        public string senha { get; set; }
        public int vitorias { get; set; }
        public int pontuacao { get; set; }

        public Jogador(string nome)
        {
            nomeJogador = nome;
            vitorias = 0;
            pontuacao = 0;
        }

        public Jogador() { 
        
        
        }

        public void Vitoria()
        {
            vitorias++;
        }
    }
}
