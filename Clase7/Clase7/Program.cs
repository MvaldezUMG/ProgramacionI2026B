//Declaramos el arreglo con 10 elementos

using Clase7;

int[] arreglo = new int[10];
int[] arreglo2 = new int[] {1, 5, 6, 8};
int[] arreglo3 = [3,5,6,4];
int[] arreglo4 = {3,5,6,4};
//Modificar/crear valores en un arreglo
arreglo[0] = 10;
arreglo[1] = 20;
arreglo[2] = 30;
//Acceder a los valores
Console.WriteLine(arreglo[1]);
Console.WriteLine(arreglo[9]);
//Recorrer un arreglo
for (int i = 0; i < arreglo.Length; i++)
{
    Console.WriteLine("Valor en la posicion {0} es {1}", i, arreglo[i] );
}
for (int i = 0; i < arreglo.Length; i++)
{
    arreglo[i] *= 2;
    //arreglo2[i] = arreglo[i] * 2;
    Console.WriteLine("Valor en la posicion {0} es {1}", i, arreglo[i] );
}
foreach (int valor in arreglo4)
{
    Console.WriteLine(valor);
}
string[,] matriz2d = new string[,]
{
    {"A", "B", "C"},
    {"D", "E", "F"},
    {"G", "H", "I"},
};

Console.WriteLine("Valor en matriz 2d {0}",matriz2d[2,2]);

//Recorrer
for (int i = 0; i < matriz2d.GetLength(0); i++)
{
    for (int j = 0; j < matriz2d.GetLength(1); j++)
    {
        Console.WriteLine("Elemento en {0},{1}, valor: {2}",i, j, matriz2d[i,j]);
    }
}
foreach(string m in matriz2d){
    Console.WriteLine(m);
}

string [,,] matriz3d = new  string[,,]
{
    {
        {"A", "B", "C"},
        {"D", "E", "F"},
    },
    {
        {"G", "H", "I"},
        {"J", "K", "L"}
    }
};

static void Herencia()
{
    Publicacion publicacion = new  Publicacion
    {
        ID = 1,
        Titulo = "Mi primera publicacion",
        EsPublic = true,
        Autor ="Juan"
    };

    PublicacionConImagen publicacionConImagen = new PublicacionConImagen
    {
        ID = 2,
        Titulo = "Mi primera publicacion",
        EsPublic = true,
        Autor = "Pedro"
    };
    publicacionConImagen.Publicar();
    publicacionConImagen.Editar("Hola", true);
}