using System;
class Program
{
    static void Main(string[] args)
    {
        // Testa a tarefa normal
        Tarefa tarefa1 = new Tarefa("Samuel Silva", "Multiplicação");
        Console.WriteLine(tarefa1.ObterResumo());

        // Testa a tarefa de matemática
        TarefaDeMatematica tarefa2 = new TarefaDeMatematica("Roberto Rodriguez", "Frações", "7.3", "8-19");
        Console.WriteLine(tarefa2.ObterResumo());
        Console.WriteLine(tarefa2.ObterListaDeTarefas());
        // Testa a tarefa de redacao
        TarefaDeRedacao tarefa3 = new TarefaDeRedacao("Maria Antunes", "História da Europa", "As Causas da Segunda Guerra Mundial");
        Console.WriteLine(tarefa3.ObterResumo());
        Console.WriteLine(tarefa3.ObterInformacoesDaRedacao());
    }
}