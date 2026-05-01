namespace Clase8;

public class Auto
{
    public string Placa { get; set; }
    public int HP { get; set; }
    public string Color { get; set; }
    //Constructor
    public Auto(string placa, int hp, string color)
    {
        Placa = placa;
        HP = hp;
        Color = color;
    }

    public virtual void MostrarDetalles()
    {
        Console.WriteLine($"Placa: {Placa} - {Color} - {HP} HP");
    }

    public virtual void Reparar()
    {
        Console.WriteLine("El vehiculo ha sido reparado");
    }
}