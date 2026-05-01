//
// int temperaturaNum = 0;
// try
// { //Ejecuta el codigo que puede fallar
//     Console.WriteLine("Por favor ingresar la temperatura.");
//     string temperatura = Console.ReadLine();
//     temperaturaNum = int.Parse(temperatura);
//     if (temperaturaNum < 20)
//     {
//         Console.WriteLine("Abrigate bien");
//     }
//     if (temperaturaNum == 20)
//     {
//         Console.WriteLine("La temperatura es agradable");
//     }
//     if (temperaturaNum > 20)
//     {
//         Console.WriteLine("Usa ropa ligera");
//     }
// }
// catch (Exception ex)
// {
//     //Captura el error y nos da informacion acerca del mismo
//     Console.WriteLine("Ha ocurrido un error " + ex.Message);
// }
// Console.WriteLine("El programa ha terminado");

//EstructuraSwitch();

BuclesFor();

static void EstructuraSwitch()
{
    Console.WriteLine("Ingrese su opcion de juego");
    string opcion = Console.ReadLine();
    switch (opcion)
    {
        case "piedra":
            Console.WriteLine("papel");
            break;
        case "papel":
            Console.WriteLine("tijera");
            break;
        case "tijera":
            Console.WriteLine("piedra");
            break;
        default:
            Console.WriteLine("No reconozco la opcion");
            break;
    }
}

static void BuclesFor()
{
    Console.WriteLine("Ingrese numero de datos");
    int n =  int.Parse(Console.ReadLine());
    int acumulador = 0;
    for (int i = 0; i < n; i++)
    {
        try
        {
            Console.WriteLine("Ingrese el numero");
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                break;
            }
            acumulador += num;
        }
        catch
        {
            Console.WriteLine("El dato es incorrecto");
            n ++;
        }
    }
    Console.WriteLine("La suma es {0}", acumulador);
}