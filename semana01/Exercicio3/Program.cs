using System;

class Program
{
    static void Main(string[] args)
    {
        string jogarNovamente = "sim";

        while (jogarNovamente.ToLower() == "sim")
        {
            Random randomGenerator = new Random();
            int numeroMagico = randomGenerator.Next(1, 101);

            int palpite = 0;
            int tentativas = 0;

            Console.WriteLine("\nAdivinhe o número mágico entre 1 e 100!");

            while (palpite != numeroMagico)
            {
                Console.Write("Qual é o seu palpite? ");
                palpite = int.Parse(Console.ReadLine());
                tentativas++;

                if (palpite < numeroMagico)
                {
                    Console.WriteLine("Mais alto");
                }
                else if (palpite > numeroMagico)
                {
                    Console.WriteLine("Mais baixo");
                }
                else
                {
                    Console.WriteLine("Você adivinhou!");
                    Console.WriteLine($"Foram {tentativas} tentativas.");
                }
            }

            Console.Write("\nDeseja jogar novamente? (sim/nao) ");
            jogarNovamente = Console.ReadLine();
        }
    }
}