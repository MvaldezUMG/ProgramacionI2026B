namespace Clase7;

public class PublicacionConImagen : Publicacion
{
    public string URLImagen { get; set; }

    public void AgregarImagen(string url)
    {
        this.URLImagen = url;
    }
}