//El espacio de nombres sirve para agrupar conjuntos de clases.
namespace Clase3;

public class Alumno
{
    //Atributos
    private string Nombres;
    private string Apellidos;
    private int Edad;
    private string Correo;
    private string Telefono;

    //public string Nombre { get; set; }

    //Constructor
    public Alumno(string nombres, string apellidos)
    {
     Nombres = nombres;   
     Apellidos = apellidos;
    }
    //Acciones se las llama metodos
    public void Asistir()
    {
        Console.WriteLine($"{Nombres} asistio a clases");
    }

    public void Inscribir()
    {
        Console.WriteLine($"{Nombres} se inscribio");
    }

    public static string Detalles(Alumno alumno)
    {
        return $"{alumno.Nombres} : {alumno.Apellidos}";
    }
}