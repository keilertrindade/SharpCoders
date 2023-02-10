using ByteBank1.Model;
using ByteBank1.Model.DTO;
using ByteBank1.Exceptions;

namespace ByteBank1.Service
{
    public class ContaService
    {

        // atributo
        private List<Conta> _contas;
        private Conta? _contaLogada;
        private bool _isContaLogada
        {
            get { return _contaLogada != null; }
        }

        public ContaService()
        {

            _contas = new List<Conta>() {
                new Conta(1L,"123","123pass"),
                new Conta(2L, "1234", "1234pass")
        };
            _contaLogada = null;
        }

        public void depositar(double amount) {
            if (!_isContaLogada)
                throw new ContaNaoLogadaException("Você precisa realizar login ou se registrar antes.");

            if(_contaLogada.EstaBloqueada)
                throw new ContaInativaException("Esta conta não está autorizada.");

            _contaLogada.Depositar(amount);

           /* if (!hasContaSufficientSaldo(amount))
                throw new SaldoInsufficientException("Saldo Insuficiente!"); */

        }

        public void transferir(double amount, string cpfDestino) {

            if (!_isContaLogada)
                throw new ContaNaoLogadaException("Você precisa realizar login ou se registrar antes.");

            if (_contaLogada.EstaBloqueada)
                throw new ContaInativaException("Esta conta não está autorizada.");
            
            if(!hasContaSufficientSaldo(amount))
                throw new SaldoInsufficientException("Saldo Insuficiente.");

            Conta contaDestino = null;
            try
            {
                contaDestino = toConta(cpfDestino);
            }catch(ContaInexistenteException e)
            {
                throw;
            }


            
            _contaLogada.Transferir(amount, contaDestino);



        }

        // métodos
        public void register()
        {
            // TODO apresentar menu de registro
            string cpf = Console.ReadLine();
            string senha = Console.ReadLine();
            long id = _contas.Count + 1;
            _contas.Add(new Conta(id, cpf, senha));
        }

        //DTO = Data Transfer Objetct
        public void login(LoginFormDTO loginForm)
        {
            if (!isContaExists(loginForm.Cpf))
                return;

            if (!isPasswordMatch(loginForm))
                throw new PasswordNotMatchException();

            Conta toLogin = toConta(loginForm.Cpf);


            if (toLogin.EstaBloqueada)
                throw new ContaInativaException("Esta conta não está autorizada.");

            _contaLogada = toLogin;

        }

        public void logout()
        {
            if (_contaLogada == null)
                return;

            _contaLogada = null;
        }


        private bool isContaExists(string cpf)
        {

            return _contas.Find(c => c.Cpf.Equals(cpf)) != null;
        }

        private bool isPasswordMatch(LoginFormDTO loginForm)
        {
            Conta conta = _contas.Find(c => c.Cpf.Equals(loginForm.Cpf));
            return conta.Senha.Equals(loginForm.Password);
        }

        private Conta toConta(string cpf)
        {
           var conta = _contas.Find(c => c.Cpf.Equals(cpf));
            if (conta == null)
                throw new ContaInexistenteException("Conta não identificada");
            return conta;

        }

        private bool hasContaSufficientSaldo(double amount)
        {
            return _contaLogada.Saldo >= amount;
        }

    }
}
