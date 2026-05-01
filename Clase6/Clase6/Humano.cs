namespace Clase6;

public class Humano
{
    private string _primerNombre;
    private string _primerApellido;
    private string _colorOjos;
    private int _edad;

    public Humano(string primerNombre, string primerApellido)
    {
        _primerNombre = primerNombre;
        _primerApellido = primerApellido;
    }

    public Humano(string primerNombre, string primerApellido, string colorOjos)
    {
        _primerNombre = primerNombre;
        _primerApellido = primerApellido;
        _colorOjos = colorOjos;
    }

    public Humano(string primerNombre, string primerApellido, string colorOjos, int edad)
    {
        _primerNombre = primerNombre;
        _primerApellido = primerApellido;
        _colorOjos = colorOjos;
        _edad = edad;
    }

    public void Presentame()
    {
        Console.WriteLine($"{_primerNombre} {_primerApellido}  Ojos:{_colorOjos} Edad:{_edad}");
    }
}