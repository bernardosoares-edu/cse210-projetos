using System.Collections.Generic;
using System.ComponentModel;

public class Video
{
    public string _titulo;
    public string _autor;
    public int _duracao;
    
    public List<Comentario> _comentarios = new List<Comentario>();

    public Video(string titulo, string autor, int duracao)
    {
        _titulo = titulo;
        _autor = autor;
        _duracao = duracao;
    }

    public void AdicionarComentario(Comentario comentario)
    {
        _comentarios.Add(comentario);
    }

    public int ObterNumeroDeComentarios()
    {
        return _comentarios.Count;
    }

    public void Exibir()
    {
        Console.WriteLine($"Título: {_titulo}");
        Console.WriteLine($"Autor: {_autor}");
        Console.WriteLine($"Duração: {_duracao} segundos");
        Console.WriteLine($"Número de Comentários: {ObterNumeroDeComentarios()}");
        Console.WriteLine("Comentários:");

        foreach (Comentario comentario in _comentarios)
        {
            Console.WriteLine($"  - {comentario._nome}: {comentario._texto}");
        }
        Console.WriteLine();
    }
}