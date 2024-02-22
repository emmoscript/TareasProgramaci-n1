// Herencia Híbrida o herencia múltiple a través de interfaces.

using System;

// Clase base para productos de repostería
public class ProductoReposteria
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Producto: {Nombre}, Precio: {Precio}$");
    }
}

// Clase base para postres
public class Postre : ProductoReposteria
{
    public void Servir()
    {
        Console.WriteLine($"Sirviendo el postre: {Nombre}");
    }
}

// Interfaz para productos con relleno
public interface IConRelleno
{
    void AgregarRelleno(string relleno);
}

// Interfaz para productos decorados
public interface IDecorado
{
    void Decorar(string decoracion);
}

// Clase para pastel
public class Pastel : Postre, IConRelleno, IDecorado
{
    public void AgregarRelleno(string relleno)
    {
        Console.WriteLine($"Agregando relleno de {relleno} al pastel.");
    }

    public void Decorar(string decoracion)
    {
        Console.WriteLine($"Decorando el pastel con {decoracion}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pastel pastelDeCumpleaños = new Pastel();
        pastelDeCumpleaños.Nombre = "Tarta Helada";
        pastelDeCumpleaños.Precio = 25.99m;

        pastelDeCumpleaños.MostrarInformacion();
        pastelDeCumpleaños.AgregarRelleno("chocolate");
        pastelDeCumpleaños.Decorar("M&Ms");
        pastelDeCumpleaños.Servir();
    }
}