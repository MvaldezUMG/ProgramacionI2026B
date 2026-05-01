using Clase3;

//Creamos una instancia de Alumno
Alumno carlos = new Alumno("Carlos", "Perez");

carlos.Asistir();
carlos.Inscribir();

Alumno kevin = new Alumno("Kevin", "Lopez");
kevin.Asistir();
//Invocamos metodo estatico
string detalles = Alumno.Detalles(kevin);
Console.WriteLine(detalles);
