using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Entities
{
    public class RankingBatalhaNaval
    {

        public DateTime data { get; set; }
        public string vencedor { get; set; }
        public string oponente { get; set; }
        public int pontosVencedor { get; set; }

        public RankingBatalhaNaval() { }
    }
}
