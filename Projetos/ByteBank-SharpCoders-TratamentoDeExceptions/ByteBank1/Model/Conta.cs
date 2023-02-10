namespace ByteBank1.Model {
    public class Conta {

        // get - visualização
        // set - alteração

        // atributos
        public long Id { get; set; }
        public string Cpf { get;  set; } = null!;
        public string Senha { get;  set; } = null!;
        public double Saldo { get; private set; }
        public bool EstaBloqueada { get; protected set; }

        // construtor
        public Conta(long id, string cpf, string senha) {
            Id = id;
            Cpf = cpf;
            Senha = senha;
            Saldo = 0.0;
            EstaBloqueada = false;
        }


        // métodos
        public bool Depositar(double quantia) {
            if (EstaBloqueada) 
                return false;

            Saldo += quantia;
            return true;
        }

        public bool Sacar(double quantia) {
            Saldo -= quantia;
            return true;
        }

        public bool Transferir(double quantia, Conta contaDestino) {
            Sacar(quantia);
            return contaDestino.Depositar(quantia);
        }

    }
}
