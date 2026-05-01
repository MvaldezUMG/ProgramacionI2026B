namespace Clase7;

public class Publicacion
{
    public int ID { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public bool EsPublic { get; set; }

    public void Publicar()
    {
        Console.WriteLine("La publicacion ha sido publicada");
    }

    public void Editar(string titulo, bool esPublico)
    {
        this.Titulo = titulo;
        this.EsPublic = esPublico;
    }
}