using System;

namespace ExerciciosLogica
{
    public class Program
    {
        public int cod, qtd, valor;

        public static void Main(string[] args)
        {
            new Program().Input();
        }

        public void Input()
        {
            Console.WriteLine("Fazer um programa para ler o código de uma peça 1, " +
                "\no número de peças 1, o valor unitário de cada peça 1, o código de uma " +
                "\npeça 2, o número de peças 2 e o valor unitário de cada peça 2. " +
                "\nCalcule e mostre o valor a ser pago. ");
            Console.ReadKey();
            Console.WriteLine("\n");

            Console.WriteLine("Cod. do produto: ");
            string codStr = Console.ReadLine();

            Console.WriteLine("Quantidade do produto: ");
            string qtdStr = Console.ReadLine();

            Console.WriteLine("Valor unitário do produto: ");
            string valorStr = Console.ReadLine();

            if (!int.TryParse(codStr, out cod))
            {
                Console.WriteLine("Caractere não aceito!");
                return;
            }

            if (!int.TryParse(qtdStr, out qtd))
            {
                Console.WriteLine("Caractere não aceito!");
                return;
            }

            if (!int.TryParse(valorStr, out valor))
            {
                Console.WriteLine("Caractere não aceito!");
                return;
            }

            CalculoProduto();
        }

        public void CalculoProduto()
        {
            int total = (qtd * valor);
            Console.WriteLine($"Total: R$ {total}");
        }
    }
}
