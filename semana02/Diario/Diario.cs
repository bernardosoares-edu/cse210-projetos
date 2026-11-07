using System;
using System.Collections.Generic;
using System.IO;

public class Diario
{
    public List<Registro> _registros;

    public Diario()
    {
        _registros = new List<Registro>();
    }

    public void AdicionarRegistro(Registro novoRegistro)
    {
        _registros.Add(novoRegistro);
    }

    public void ExibirTodos()
    {
        if (_registros.Count == 1)
        {
            Console.WriteLine($"Você tem 1 registro no seu diário.");
        }
        else
        {
            Console.WriteLine($"Você tem {_registros.Count} registros no seu diário.");
        }
        Console.WriteLine();

        foreach (Registro registro in _registros)
        {
            registro.Exibir();
        }
    }

    public void SalvarNoArquivo(string arquivo)
    {
        using (StreamWriter arquivoSaida = new StreamWriter(arquivo))
        {
            foreach (Registro registro in _registros)
            {
                arquivoSaida.WriteLine($"{registro._data}|{registro._textoPergunta}|{registro._textoResposta}");
            }
        }
    }

    public void CarregarDoArquivo(string arquivo)
    {
        if (!File.Exists(arquivo))
        {
            Console.WriteLine("Arquivo não encontrado.");
            return;
        }

        string[] linhas = File.ReadAllLines(arquivo);

        _registros.Clear();

        foreach (string linha in linhas)
        {
            string[] partes = linha.Split("|");

            string data = partes[0];
            string pergunta = partes[1];
            string resposta = partes[2];

            Registro registro = new Registro(data, pergunta, resposta);
            _registros.Add(registro);
        }
    }
}