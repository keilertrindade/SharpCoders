using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Entities
{
    public class Navio
    {
        public int pontuacao;
        public int tamanho;
        public int partesAfundadas = 0;

        public bool derrubado = false;

        public string tipo;

        public List<string> coordenadasPosicoes = new List<string>();

        public Navio(int pontuacao, int tamanho, string tipo)
        {
            this.pontuacao = pontuacao;
            this.tamanho = tamanho;
            this.tipo = tipo;
        }
    }
}
