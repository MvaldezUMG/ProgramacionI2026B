namespace Clase6;

public class Caja
{
    //Propiedades publicas, preferir usar privadas
    //con getter y setters porque rompemos encapsulamiento
    public int Largo { get; set; }
    public int Ancho { get; set; }
    public int Alto { get; set; }

    public int Volumen
    {
        get { return Largo * Ancho * Alto; }
    }

    // public int Volumen()
    // {
    //     return Largo * Ancho * Alto;
    // }

    ~Caja()
    {
        
    }
}