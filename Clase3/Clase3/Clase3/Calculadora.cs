namespace Clase3;

public class Calculadora
{
    private double valor1;
    private double valor2;

    public Calculadora(double valor1, double valor2)
    {
        this.valor1 = valor1;
        this.valor2 = valor2;
    }

    public double Sumar(double valor1, double valor2)
    {
        return valor1 + valor2;
    }
}