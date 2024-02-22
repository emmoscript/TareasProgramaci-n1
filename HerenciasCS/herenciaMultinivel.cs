// Herencia multinivel

using System;

// Clase base
public class MaquinaDeCafe
{
    public void Encender()
    {
        Console.WriteLine("Máquina de café [Encendida]");
    }

    public void Apagar()
    {
        Console.WriteLine("Máquina de café [Apagada]");
    }
}

// Clase derivada de MaquinaDeCafe
public class Cafetera : MaquinaDeCafe
{
    public void HacerCafe()
    {
        Console.WriteLine("Máquina de café [Haciendo café]");
    }
}

// Clase derivada de Cafetera
public class CafeteraAutomatica : Cafetera
{
    public void HacerCafeAutomatico()
    {
        Console.WriteLine("Máquina de café [modo automático]");
    }
}

class Program
{
    static void Main(string[] args)
    {
        CafeteraAutomatica miCafetera = new CafeteraAutomatica();

        miCafetera.Encender();
        miCafetera.HacerCafe();
        miCafetera.HacerCafeAutomatico();
        miCafetera.Apagar();
    }
}
