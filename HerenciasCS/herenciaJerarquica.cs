// Herencia jer�rquica

using System;

// Clase base
public class FiguraGeometrica
{
    public virtual void Dibujar()
    {
        Console.WriteLine("Dibujando una figura geom�trica.");
    }
}

// Subclase 1
public class Circulo : FiguraGeometrica
{
    public override void Dibujar()
    {
        Console.WriteLine("Dibujando un c�rculo.");
    }

    public void CalcularArea(double radio)
    {
        double area = Math.PI * radio * radio;
        Console.WriteLine($"El �rea del c�rculo es: {area}");
    }
}

// Subclase 2
public class Rectangulo : FiguraGeometrica
{
    public override void Dibujar()
    {
        Console.WriteLine("Dibujando un rect�ngulo.");
    }

    public void CalcularArea(double baseRect, double altura)
    {
        double area = baseRect * altura;
        Console.WriteLine($"El �rea del rect�ngulo es: {area}");
    }
}

// Subclase 3
public class Triangulo : FiguraGeometrica
{
    public override void Dibujar()
    {
        Console.WriteLine("Dibujando un tri�ngulo.");
    }

    public void CalcularArea(double baseTriangulo, double altura)
    {
        double area = (baseTriangulo * altura) / 2;
        Console.WriteLine($"El �rea del tri�ngulo es: {area}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circulo circulo = new Circulo();
        circulo.Dibujar();
        circulo.CalcularArea(5);

        Rectangulo rectangulo = new Rectangulo();
        rectangulo.Dibujar();
        rectangulo.CalcularArea(4, 6);

        Triangulo triangulo = new Triangulo();
        triangulo.Dibujar();
        triangulo.CalcularArea(3, 4);
    }
}