using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GameHub.Entities
{
    public class GerenciadorJSON
    {
        public GerenciadorJSON()
        {

        }

        public void CarregarJogadores()
        {

        }

        public void SalvarJogadores()
        {

        }

        public void CarregarRankingBatalhaNaval()
        {

        }

        public void SalvarRankingBatalhaNaval()
        {

        }

        public void CarregarRankingJogoDaVelha()
        {

        }

        public void SalvarRankingJogoDaVelha()
        {
            Jogador jogador = new Jogador("Keiler");
            jogador.pontuacao = 5;
            jogador.vitorias = 8;
            jogador.senha = "343242";

            List<Jogador> lista = new List<Jogador>();

            using (StreamReader r = new StreamReader("dataReady.json"))
            {
                string json = r.ReadToEnd();
                lista = JsonSerializer.Deserialize<List<Jogador>>(json);
            }


            lista.Add(jogador);
            

            
            string jsonString = JsonSerializer.Serialize(lista, new JsonSerializerOptions() { WriteIndented = true });
            using (StreamWriter outputFile = new StreamWriter("dataReady.json"))
            {
                outputFile.WriteLine(jsonString);
            }

        }


    }
}
