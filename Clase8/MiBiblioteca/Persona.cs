namespace MiBiblioteca;

public class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }

    protected void Saludar()
    {
        Console.WriteLine("Hola humano");
    }
}