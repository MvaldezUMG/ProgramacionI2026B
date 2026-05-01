namespace Clase8;
public class Audi : Auto
{
 public string Modelo { get; set; }
 public Audi(string placa, int hp, string color, string modelo) : base(placa, hp, color)
 {
  Modelo = modelo;
 }
 public override void MostrarDetalles()
 {
  Console.WriteLine("Es el buen AUDI");
 }
 public override void Reparar()
 {
  Console.WriteLine($"El Audi Modelo {Modelo} ha sido reparado");
 }
}