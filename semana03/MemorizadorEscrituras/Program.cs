// EXCEDENDO OS REQUISITOS:
// Para ir além do básico, criei uma biblioteca com várias escrituras
// em vez de apenas uma. O programa escolhe uma escritura aleatória
// toda vez que é executado, assim o usuário pode praticar escrituras
// diferentes sem precisar mudar o código.

using System;
class Program
{
    static void Main(string[] args)
    {
        List<Escritura> biblioteca = new List<Escritura>();

        biblioteca.Add(new Escritura(
            new Referencia("João", 3, 16),
            "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito, para que todo aquele que nele crê não pereça, mas tenha a vida eterna."));

        biblioteca.Add(new Escritura(
            new Referencia("Provérbios", 3, 5, 6),
            "Confia no Senhor de todo o teu coração e não te apoies no teu próprio entendimento. Reconhece-o em todos os teus caminhos e ele endireitará as tuas veredas."));

        biblioteca.Add(new Escritura(
            new Referencia("Salmos", 23, 1),
            "O Senhor é o meu pastor e nada me faltará."));

        Random aleatorio = new Random();
        int indice = aleatorio.Next(biblioteca.Count);
        Escritura escritura = biblioteca[indice];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(escritura.ObterTexto());
            Console.WriteLine();
            Console.WriteLine("Pressione Enter para continuar ou digite 'sair' para terminar.");

            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "sair")
            {
                break;
            }

            escritura.OcultarPalavrasAleatorias(3);

            if (escritura.EstaCompletamenteOculta())
            {
                Console.Clear();
                Console.WriteLine(escritura.ObterTexto());
                Console.WriteLine();
                Console.WriteLine("Todas as palavras foram ocultas. Bom trabalho!");
                break;
            }
        }
    }
}