using System;

namespace ExerciciosLogica3
{
    public class Program
    {
        public double a, b, c, x, x1, x2, delta;

        static void Main(string[] args)
        {
            new Program().Bhaskara();
        }

        public void Bhaskara()
        {
            Console.WriteLine("Ler os valores dos três coeficientes 'a', 'b' e 'c' " +
                "de uma equação do segundo grau: ax² + bx + c = 0. " +
                "\nEm seguida, mostrar os valores das raízes da equação, conforme exemplos, " +
                "\nusando a fórmula de Baskara. Se a equação não possuir raízes " +
                "\n(o valor de 'a' não pode ser zero, e o valor de 'delta' não pode ser negativo), " +
                "\nmostrar uma mensagem 'Impossível calcular'.");

            Console.ReadKey();
            Console.WriteLine("\n");

            Console.Write("Escreva o valor de a: ");
            string valorA = Console.ReadLine();

            Console.Write("Escreva o valor de b: ");
            string valorB = Console.ReadLine();

            Console.Write("Escreva o valor de c: ");
            string valorC = Console.ReadLine();

            if (!double.TryParse(valorA, out a) || a == 0)
            {
                Console.WriteLine("O valor de a não pode ser zero.");
                return;
            }

            if (!double.TryParse(valorB, out b))
            {
                Console.WriteLine("Caractere não aceito.");
                return;
            }

            if (!double.TryParse(valorC, out c))
            {
                Console.WriteLine("Caractere não aceito.");
                return;
            }

            CalculoBhaskara();

            Console.WriteLine("\n");
            Console.WriteLine("Pressione qualquer botão para sair...");
            Console.ReadKey();
            Environment.Exit(0);
        }

        public void CalculoBhaskara()
        {
            delta = Math.Pow(b, 2) - (4 * (a * c));

            x1 = (-(b) + Math.Sqrt(delta)) / (2 * a);
            x2 = (-(b) - Math.Sqrt(delta)) / (2 * a);

            if (a == 0 || delta < 0)
            {
                Console.WriteLine("Impossível calcular.");
            }
            Console.WriteLine($"\nx1 = {x1}\nx2 = {x2}");
        }
    }
}
