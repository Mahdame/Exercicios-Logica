using System;

namespace ExerciciosLogica2
{
    public class Program
    {
        public double raio;
        static void Main(string[] args)
        {
            new Program().Raio();
        }

        public void Raio()
        {
            Console.WriteLine("Faça um programa para ler o valor do raio de um círculo, " +
                "\ne depois mostrar o valor da área deste círculo com quatro casas decimais " +
                "\nconforme exemplos. ");
            Console.ReadKey();
            Console.WriteLine("\n");

            Console.WriteLine("Digite o valor do raio de um circulo: ");
            string raioStr = Console.ReadLine();

            if (!double.TryParse(raioStr, out raio))
            {
                Console.WriteLine("Caractere não aceito!");
                return;
            }

            Area();

            Console.WriteLine("\n");
            Console.WriteLine("Pressione qualquer botão para sair...");
            Console.ReadKey();
            Environment.Exit(0);
        }

        public void Area()
        {
            double area = Math.PI * Math.Pow(raio, 2);
            area = Math.Round(area, 4);

            Console.WriteLine($"A área total do circulo é: {area}");
        }
    }
}
