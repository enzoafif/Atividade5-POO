namespace Atividade5_POO
{
    public class Caixa
    {
        public void Menu()
        {
            ContaBancaria contaBancaria = new();

            bool loop = true;

            while(loop)
            {
                Console.WriteLine("Escolha uma operação:\n");

                Console.WriteLine("1-Depositar");
                Console.WriteLine("2-Sacar");
                Console.WriteLine("3-Obter saldo");
                Console.WriteLine("4-Obter número da conta");
                Console.WriteLine("5-Obter titular da conta");
                Console.WriteLine("0-Sair");

                int escolha = Convert.ToInt32(Console.ReadLine());

                switch(escolha)
                {
                    case 1:
                        Console.Write("\nDigite o valor a ser depositado: ");

                        double valorDeposito = Convert.ToInt32(Console.ReadLine());

                        contaBancaria.Depositar(valorDeposito);
                        break;

                    case 2:
                        Console.Write("\nDigite o valor a ser sacado: ");

                        double valorSaque = Convert.ToInt32(Console.ReadLine());

                        contaBancaria.Sacar(valorSaque);
                        break;

                    case 3:

                        contaBancaria.ObterSaldo();

                        break;

                    case 4:
                        contaBancaria.ObterNumeroConta();

                        break;

                    case 5:
                        contaBancaria.ObterTitularConta();

                        break;

                    case 0:
                        loop = false;

                        break;

                    default:
                        Console.WriteLine("Opção inválida");

                        break;
                }
            }
        }
    }
}
