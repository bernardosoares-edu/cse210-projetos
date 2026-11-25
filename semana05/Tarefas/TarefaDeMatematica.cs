using System;
// Classe filha que herda tudo da classe base Tarefa
public class TarefaDeMatematica : Tarefa
{
    // Atributos só da tarefa de matemática
    private string _capitulo;
    private string _problemas;

    // Construtor: recebe os 4 valores e manda os 2 primeiros pra classe base
    public TarefaDeMatematica(string nomeEstudante, string topico, string capitulo, string problemas)
        : base(nomeEstudante, topico)
    {
        _capitulo = capitulo;
        _problemas = problemas;
    }

    // Devolve a lista no formato: "Capitulo 7.3 Problemas 8-19"
    public string ObterListaDeTarefas()
    {
        return $"Capitulo {_capitulo} Problemas {_problemas}";
    }
}