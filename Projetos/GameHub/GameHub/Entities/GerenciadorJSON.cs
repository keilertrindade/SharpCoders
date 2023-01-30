using System;
using System.Collections;
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

        public List<Jogador> CarregarJogadores()
        {
            List<Jogador> jogadoresCadastrados = new List<Jogador>();
            string cadastroJogadores = "CadastroJogadores.json";

            if (File.Exists(cadastroJogadores))
            {
                using (StreamReader r = new StreamReader(cadastroJogadores))
                {
                    string json = r.ReadToEnd();
                    jogadoresCadastrados = JsonSerializer.Deserialize<List<Jogador>>(json);
                }
            }

            return jogadoresCadastrados;
        }

        public void SalvarJogadores(List<Jogador> jogadoresCadastrados)
        {
            string cadastroJogadores = "CadastroJogadores.json";
            string jsonString = JsonSerializer.Serialize(jogadoresCadastrados, new JsonSerializerOptions() { WriteIndented = true });
            using (StreamWriter outputFile = new StreamWriter(cadastroJogadores))
            {
                outputFile.WriteLine(jsonString);
            }

            Console.WriteLine("Usuário cadastrado com sucesso!");
            Console.ReadLine();
        }

        public List<RankingBatalhaNaval> CarregarRankingBatalhaNaval()
        {
            List<RankingBatalhaNaval> listaBatalhaNaval = new List<RankingBatalhaNaval>();
            string rankingBatalhaNaval = "RankingBatalhaNaval.json";

            if (File.Exists(rankingBatalhaNaval))
            {
                using (StreamReader r = new StreamReader(rankingBatalhaNaval))
                {
                    string json = r.ReadToEnd();
                    listaBatalhaNaval = JsonSerializer.Deserialize<List<RankingBatalhaNaval>>(json);
                }
            }
            return listaBatalhaNaval;
        }

        public void SalvarRankingBatalhaNaval(List<RankingBatalhaNaval> listaRankingBatalhaNaval)
        {
            string rankingBatalhaNaval = "RankingBatalhaNaval.json";
            string jsonString = JsonSerializer.Serialize(listaRankingBatalhaNaval, new JsonSerializerOptions() { WriteIndented = true });
            using (StreamWriter outputFile = new StreamWriter(rankingBatalhaNaval))
            {
                outputFile.WriteLine(jsonString);
            }
        }


        public void AdicionarJogadorRankingJogoDaVelha(Jogador jogador)
        {
            List<RankingJogoDaVelha> listaRankingJogoDaVelha = CarregarRankingJogoDaVelha();
            RankingJogoDaVelha novaEntrada = new RankingJogoDaVelha();
           
            novaEntrada.nomeJogador = jogador.nomeJogador;
            novaEntrada.ultimaPartida = DateTime.Now;
            novaEntrada.partidasJogadas = 0;
            novaEntrada.partidasVencidas = 0;
            listaRankingJogoDaVelha.Add(novaEntrada);

            SalvarRankingJogoDaVelha(listaRankingJogoDaVelha);

        }

        public List<RankingJogoDaVelha> CarregarRankingJogoDaVelha()
        {
            List<RankingJogoDaVelha> listaRankingJogoDaVelha = new List<RankingJogoDaVelha>();
            string RankingJogoDaVelha = "RankingJogoDaVelha.json";

            if (File.Exists(RankingJogoDaVelha))
            {
                using (StreamReader r = new StreamReader(RankingJogoDaVelha))
                {
                    string json = r.ReadToEnd();
                    listaRankingJogoDaVelha = JsonSerializer.Deserialize<List<RankingJogoDaVelha>>(json);
                }
            }
            return listaRankingJogoDaVelha;
        }

        public void SalvarRankingJogoDaVelha(List<RankingJogoDaVelha> listaRankingJogoDaVelha)
        {
            string rankingBatalhaNaval = "RankingJogoDaVelha.json";
            string jsonString = JsonSerializer.Serialize(listaRankingJogoDaVelha, new JsonSerializerOptions() { WriteIndented = true });
            using (StreamWriter outputFile = new StreamWriter(rankingBatalhaNaval))
            {
                outputFile.WriteLine(jsonString);
            }

        }
    }
}
