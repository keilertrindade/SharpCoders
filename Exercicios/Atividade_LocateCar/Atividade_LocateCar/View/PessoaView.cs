﻿using Atividade_LocateCar.Model;

namespace Atividade_LocateCar.View
{
    public class PessoaView
    {
        public static Pessoa MenuNovaPessoa() {

            Console.WriteLine("## Cadastrando uma nova pessoa ##");
            Console.Write("Digite o seu nome: ");
            string? nome = Console.ReadLine();
            Console.Write("Digite o seu cpf: ");
            string? cpf = Console.ReadLine();
            Console.Write("Digite o seu email: ");
            string? email = Console.ReadLine();

            return new Pessoa
            {
                Name = nome, Cpf = cpf, Email = email;
           
            }

        } 


    }
}
