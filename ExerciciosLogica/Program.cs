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
            Console.WriteLine("Cod. do produto: ");
            string codStr = Console.ReadLine();

            Console.WriteLine("Quantidade do produto: ");
            string qtdStr = Console.ReadLine();

            Console.WriteLine("Valor unitário do produto: ");
            string valorStr = Console.ReadLine();

            if (!int.TryParse(codStr, out cod))
            {
                Console.WriteLine("Caracter nao aceito!");
                return;
            }

            if (!int.TryParse(qtdStr, out qtd))
            {
                Console.WriteLine("Caracter nao aceito!");
                return;
            }

            if (!int.TryParse(valorStr, out valor))
            {
                Console.WriteLine("Caracter nao aceito!");
                return;
            }

            CalculoProduto();
        }

        public void CalculoProduto()
        {
            int total = (qtd * valor);
            Console.WriteLine($"Total: R${total}");
        }
    }
}
