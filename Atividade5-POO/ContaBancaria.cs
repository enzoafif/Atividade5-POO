namespace Atividade5_POO
{
    public class ContaBancaria
    {
        public double Saldo { get; private set; }
        public string? NumeroConta { get; set; }
        public string? Titular { get; set; }

        public void Depositar(double valor)
        {
            try
            {
                if(valor < 0)
                {
                    Console.WriteLine("O valor não pode ser menor que 0");

                    return;
                }

                Saldo += valor;

                Console.WriteLine("Depósito feito com sucesso");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        public void Sacar(double valor)
        {
            try
            {

                if (valor > Saldo)
                {
                    Console.WriteLine("Valor maior que o saldo disponível\n");
                    return;
                }

                if (valor < 0)
                {
                    Console.WriteLine("Não é possível sacar um valor menor que 0\n");
                    return;
                }

                Saldo -= valor;

                Console.WriteLine("Saldo efetuado com sucesso\n");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }

        }
        public void ObterSaldo()
        {
            Console.WriteLine($"O saldo atual é: {Saldo}\n");
        }

        public void ObterNumeroConta()
        {
            if (NumeroConta == null)
            {
                Console.Write("Digite o número da conta: ");

                NumeroConta = Console.ReadLine();

                return;
            }

            Console.WriteLine($"O número da conta é: {NumeroConta}\n");
        }

        public void ObterTitularConta()
        {
            if (Titular == null)
            {
                Console.Write("Digite o nome do titular: ");

                Titular = Console.ReadLine();

                return;
            }

            Console.WriteLine($"O nome do titular é: {Titular}\n");
        }

    }
}
