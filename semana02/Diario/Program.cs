// EXTRA - Supera os requisitos:
// Criei um método que mostra a quantidade de registros no diário
// quando o usuário escolhe a opção 2 (Exibir).
// Ex: "Você tem 2 registros no seu diário."

using System;

class Program
{
    static void Main(string[] args)
    {
        Diario diario = new Diario();
        GeradorDePerguntas gerador = new GeradorDePerguntas();

        Console.WriteLine("Bem-vindo ao Diário!");

        string escolha = "";

        while (escolha != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Por favor, selecione uma das seguintes opções:");
            Console.WriteLine("1. Escrever");
            Console.WriteLine("2. Exibir");
            Console.WriteLine("3. Carregar");
            Console.WriteLine("4. Salvar");
            Console.WriteLine("5. Sair");
            Console.Write("O que você gostaria de fazer? ");
            escolha = Console.ReadLine();

            if (escolha == "1")
            {
                string pergunta = gerador.ObterPerguntaAleatoria();
                Console.WriteLine(pergunta);
                Console.Write("> ");
                string resposta = Console.ReadLine();

                string data = DateTime.Now.ToShortDateString();

                Registro novoRegistro = new Registro(data, pergunta, resposta);
                diario.AdicionarRegistro(novoRegistro);
            }
            else if (escolha == "2")
            {
                diario.ExibirTodos();
            }
            else if (escolha == "3")
            {
                Console.Write("Qual é o nome do arquivo? ");
                string arquivo = Console.ReadLine();
                diario.CarregarDoArquivo(arquivo);
            }
            else if (escolha == "4")
            {
                Console.Write("Qual é o nome do arquivo? ");
                string arquivo = Console.ReadLine();
                diario.SalvarNoArquivo(arquivo);
            }
        }
    }
}