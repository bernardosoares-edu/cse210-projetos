using System;
// Classe filha que herda tudo da classe base Tarefa
public class TarefaDeRedacao : Tarefa
{
    // Atributos só da tarefa de matemática
    private string _titulo;
   
    // Construtor: recebe os 4 valores e manda os 2 primeiros pra classe base
    public TarefaDeRedacao(string nomeEstudante, string topico, string titulo)
        : base(nomeEstudante, topico)
    {
        _titulo = titulo;
    
    }

    // Devolve a lista no formato: "Capitulo 7.3 Problemas 8-19"
    public string ObterInformacoesDaRedacao()
    {
        return $"{_titulo}, por {_nomeEstudante}";
    }
}