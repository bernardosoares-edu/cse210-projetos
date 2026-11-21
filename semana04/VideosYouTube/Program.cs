using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Como Aprender C# em 1 Hora", "Gabriel Duarte", 3600);
        video1.AdicionarComentario(new Comentario("Ana", "Muito bom, aprendi demais!"));
        video1.AdicionarComentario(new Comentario("Pedro", "Melhor explicação que já vi."));
        video1.AdicionarComentario(new Comentario("Maria", "Vou assistir de novo amanhã."));
        videos.Add(video1);

        Video video2 = new Video("Top 10 Truques de Python", "Canal Tech", 1200);
        video2.AdicionarComentario(new Comentario("João", "O truque 3 salvou minha vida."));
        video2.AdicionarComentario(new Comentario("Lucas", "Não sabia dessa, top!"));
        video2.AdicionarComentario(new Comentario("Carla", "Quero parte 2!"));
        videos.Add(video2);

        Video video3 = new Video("Entendendo Abstração", "BYU", 900);
        video3.AdicionarComentario(new Comentario("Rafael", "Agora entendi o que é abstração."));
        video3.AdicionarComentario(new Comentario("Beatriz", "Exemplo muito claro."));
        video3.AdicionarComentario(new Comentario("Felipe", "Ajudou muito na tarefa."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Exibir();
        }
    }
}