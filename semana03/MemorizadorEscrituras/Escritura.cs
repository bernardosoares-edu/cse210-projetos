using System;
using System.Collections.Generic;

public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavras = new List<Palavra>();

        string[] partes = texto.Split(' ');
        foreach (string parte in partes)
        {
            _palavras.Add(new Palavra(parte));
        }
    }

    public void OcultarPalavrasAleatorias(int numeroParaOcultar)
    {
        Random aleatorio = new Random();
        int escondidasAgora = 0;

        if (EstaCompletamenteOculta())
        {
            return;
        }

        while (escondidasAgora < numeroParaOcultar)
        {
            int indice = aleatorio.Next(_palavras.Count);

            if (!_palavras[indice].EstaOculto())
            {
                _palavras[indice].Ocultar();
                escondidasAgora++;
            }

            if (EstaCompletamenteOculta())
            {
                break;
            }
        }
    }

    public string ObterTexto()
    {
        List<string> textos = new List<string>();
        foreach (Palavra p in _palavras)
        {
            textos.Add(p.ObterTexto());
        }

        string textoJunto = string.Join(" ", textos);
        return $"{_referencia.ObterTexto()} {textoJunto}";
    }

    public bool EstaCompletamenteOculta()
    {
        foreach (Palavra p in _palavras)
        {
            if (!p.EstaOculto())
            {
                return false;
            }
        }
        return true;
    }
}