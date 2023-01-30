using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Entities
{
    public class RankingJogoDaVelha
    {
        public DateTime ultimaPartida { get; set; }
        public string nomeJogador { get; set; }
        public int partidasVencidas { get; set; }

        public int partidasJogadas { get; set; }

        public RankingJogoDaVelha() { }
    }
}
