using System;
using System.Collections.Generic;

public class GeradorDePerguntas
{
    public List<string> _perguntas;

    public GeradorDePerguntas()
    {
        _perguntas = new List<string>
        {
            "Quem foi a pessoa mais interessante com quem interagi hoje?",
            "Qual foi a melhor parte do meu dia?",
            "Como vi a mão do Senhor em minha vida hoje?",
            "Qual foi a emoção mais forte que senti hoje?",
            "Se eu pudesse fazer uma coisa de novo hoje, o que seria?",
            "Pelo que sou grato hoje?",
            "O que aprendi hoje?"
        };
    }

    public string ObterPerguntaAleatoria()
    {
        Random aleatorio = new Random();
        int indice = aleatorio.Next(_perguntas.Count);
        return _perguntas[indice];
    }
}