// See https://aka.ms/new-console-template for more information
using Clase6;
//Con metodos estaticos
//Calculadora.Sumar(1, 3);
//necesitamos instanciar la clase
//Calculadora2 calc =  new Calculadora2();
//calc.Sumar(1, 5);

Humano fernanda = new Humano("Fernanda", "Mendez");

fernanda.Presentame();

Humano kevin = new Humano("Kevin", "Lopez", "negros", 26);
kevin.Presentame();

//Instanciar con propiedades publicas
Caja caja = new Caja
{
    Alto = 10,
    Ancho = 20,
    Largo = 40,
};
Console.WriteLine(caja.Volumen);

//Console.WriteLine(caja.Volumen());