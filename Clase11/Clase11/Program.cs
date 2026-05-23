using Clase11;

ConexionSqlite con = new ConexionSqlite("Data Source=progra1.db");


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

//Crear un menu que me permita realizar las operaciones indicadas.
