// Herencia multinivel

using System;

// Clase base
public class MaquinaDeCafe
{
    public void Encender()
    {
        Console.WriteLine("M�quina de caf� [Encendida]");
    }

    public void Apagar()
    {
        Console.WriteLine("M�quina de caf� [Apagada]");
    }
}

// Clase derivada de MaquinaDeCafe
public class Cafetera : MaquinaDeCafe
{
    public void HacerCafe()
    {
        Console.WriteLine("M�quina de caf� [Haciendo caf�]");
    }
}

// Clase derivada de Cafetera
public class CafeteraAutomatica : Cafetera
{
    public void HacerCafeAutomatico()
    {
        Console.WriteLine("M�quina de caf� [modo autom�tico]");
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
