using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual é a sua porcentagem de nota? ");
        string entrada = Console.ReadLine();
        int porcentagem = int.Parse(entrada);

        string letra = "";
        string sinal = "";

        // Descobre a letra
        if (porcentagem >= 90)
        {
            letra = "A";
        }
        else if (porcentagem >= 80)
        {
            letra = "B";
        }
        else if (porcentagem >= 70)
        {
            letra = "C";
        }
        else if (porcentagem >= 60)
        {
            letra = "D";
        }
        else
        {
            letra = "F";
        }

        // Desafio do sinal + e -
        int ultimoDigito = porcentagem % 10;

        if (ultimoDigito >= 7)
        {
            sinal = "+";
        }
        else if (ultimoDigito < 3)
        {
            sinal = "-";
        }

        // Regras especiais: não tem A+ e nem F+ / F-
        if (letra == "A" && sinal == "+")
        {
            sinal = "";
        }
        if (letra == "F")
        {
            sinal = "";
        }

        Console.WriteLine($"\nSua nota é: {letra}{sinal}");

        if (porcentagem >= 70)
        {
            Console.WriteLine("Parabéns! Você passou no curso!");
        }
        else
        {
            Console.WriteLine("Não foi dessa vez, continue se esforçando!");
        }
    }
}