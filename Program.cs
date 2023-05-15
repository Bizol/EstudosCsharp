using System.Globalization;

namespace ContaBancaria {
    internal class Program {
        static void Main(string[] args) {

            Conta conta;

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá deposito inicial? ");
            char d = char.Parse(Console.ReadLine());

            if (d == 's' || d == 'S') {
                Console.Write("Entre o valor do deposito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new Conta(nome, numero, saldo);
            }
            else {
                conta = new Conta(nome, numero);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor pra deposito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valor);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor pra saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valor);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}