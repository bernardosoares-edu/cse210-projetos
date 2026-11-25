using System;

// Classe base que guarda o que é comum em toda tarefa
public class Tarefa
{
    // Atributos da tarefa
    protected string _nomeEstudante;
    private string _topico;

    // Construtor: recebe os valores e guarda nos atributos
    public Tarefa(string nomeEstudante, string topico)
    {
        _nomeEstudante = nomeEstudante;
        _topico = topico;
    }

    //  metodo - Devolve o resumo no formato: "Nome - Tópico"
    public string ObterResumo()
    {
        return $"{_nomeEstudante} - {_topico}";
    }
}