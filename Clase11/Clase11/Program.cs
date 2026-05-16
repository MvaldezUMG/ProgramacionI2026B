using Clase11;


ConexionSqlite con = new ConexionSqlite("");


Alumno juan =  new Alumno
{
    Carnet = "32940329",
    Nombres = "Juan",
    Apellidos = "Perez",
    Correo = "demo@com.com",
    DPI = "2034239322",
    Telefono = "12345678"
};

con.EliminarAlumno(juan.Carnet);
con.CrearAlumno(juan);

List<Alumno> alumnos = con.ListarAlumnos();
for (int i = 0; i < alumnos.Count; i++)
{
    Console.WriteLine(alumnos[i].Carnet + " " +  alumnos[i].Nombres);
}

Alumno juanEncontrado = con.AlumnoPorCarnet(juan.Carnet);
Console.WriteLine(juanEncontrado.Apellidos + " " + juanEncontrado.Carnet);