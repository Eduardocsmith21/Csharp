using System;

namespace ContaCorrente
{
    class Acconunt
    {
        public static async Task Main(string [] args)
        {
            Cliente cl = new Cliente();
            Conta cont = new Conta();

            Console.Write("Informe Seu Login: ");
            string Login = Console.ReadLine();
            Console.Write("Informe Sua senha: ");
            string Senha = Console.ReadLine();

            if (Login == cl.Usuario && Senha == cl.Senha)
            {
                Console.Write("Logando...");
                await Task.Delay(2000);
                Console.WriteLine();
               
                Console.WriteLine("Escolha Uma Opção");
                Console.WriteLine("[1] Depositar");
                Console.WriteLine("[2] Olhar Saldo");
                Console.WriteLine("[3] Sacar");
                Console.Write("Opção: ");
                double op = double.Parse(Console.ReadLine());
            
            switch(op)
            {
                case 1:
                    Console.Write("Valor do deposito: ");
                    double valor = double.Parse(Console.ReadLine());
                    Console.WriteLine("Saldo de: " + (cont.Saldo + valor));
                    break;
                case 2:
                    Console.WriteLine(cont.Saldo);
                    break;
                case 3:
                    Console.Write("Valor do Saque:");
                    double valorSaque = double.Parse(Console.ReadLine());
                    Console.WriteLine("Saldo atual de: " + (cont.Saque - valorSaque));
                    break;
                default:
                    Console.WriteLine("Opção Invalida...");
                    break;
                
            }
            }
            else
            {
                Console.Write("Login Incorreto");
            }
            
            
            Console.WriteLine();
        }
    }
}

namespace ContaCorrente
{
    class Cliente
    {
        private string _usuario = "ed";
        private string _senha = "ed123";

        public string Usuario
        {
            get
            {
                return _usuario;
            }
            set 
            {
                _usuario = value;
            }
        }
        public string Senha
        {
            get
            {
                return _senha;
            }
            set
            {
                _senha = value;
            }
        }

    }
}

namespace ContaCorrente
{
    class Conta
    {
        Principal pr = new Principal();

        private double _saldo;
        private double _saque;
        private double _deposito;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo = value;
            }
        }
        public double Saque
        {
            get
            {
                return _saque;
            }
            set
            {
                if(Saldo < Saque)
                {
                    Console.WriteLine("Saldo Insuficiente Para Saque...");
                }
                else{
                    _saque = value;
                }
            }
        }
        public double Deposito
        {
            get
            {
                return _deposito;
            }
            set
            {
                _deposito = value;
            }
        }

        public double Saldo1 { get => _saldo; set => _saldo = value; }
    }
}