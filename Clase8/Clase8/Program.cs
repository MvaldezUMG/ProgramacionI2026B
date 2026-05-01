using System.Runtime.InteropServices.JavaScript;
using Clase8;
using MiBiblioteca;

Console.WriteLine("Hello, World!");

Auto propio = new Auto("P-390MDS", 100, "Azul");
Auto rentado = new Auto("P-495MGA",150, "Verde");

propio.MostrarDetalles();
propio.Reparar();

Audi q7 = new Audi("P-593GJD", 150, "Azul", "Q7");
q7.MostrarDetalles();
q7.Reparar();

Persona persona = new Persona
{
    Nombre = "Juan",
    Apellido = "Perez",
};

//persona.Saludar();


//Aleatorios(20, 1000);


string fecha = "02/May/2026";
string fecha1 = "02/05/2026";
string fecha2 = "02-05-2026";

string fecha3 = "2026/05/02";
string fecha4 = "2026/02/05";

DateTime now = DateTime.Now;

Console.WriteLine(now.ToString("dd/MM/yyyy hh:mm"));
Console.WriteLine(now.ToString("MM/dd/yyyy hh:mm"));
Console.WriteLine(now.ToString("yyyy/MM/dd hh:mm"));
int day = now.Day;
int month = now.Month;
int year = now.Year;

int edad = CalcularEdad("01/01/1998");

Console.WriteLine("Edad " + edad);

static void Aleatorios(int n, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(rnd.Next(1, max));
    }   
}

static int CalcularEdad(string fechaNacimiento)
{
    DateTime fecha = DateTime.ParseExact(fechaNacimiento, "dd/MM/yyyy", null);
    int years = (DateTime.Now - fecha).Days / 365;
    return years;
}