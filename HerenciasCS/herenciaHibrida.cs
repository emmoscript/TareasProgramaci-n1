// Herencia H�brida o herencia m�ltiple a trav�s de interfaces.

using System;

// Clase base para productos de reposter�a
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
        Pastel pastelDeCumplea�os = new Pastel();
        pastelDeCumplea�os.Nombre = "Tarta Helada";
        pastelDeCumplea�os.Precio = 25.99m;

        pastelDeCumplea�os.MostrarInformacion();
        pastelDeCumplea�os.AgregarRelleno("chocolate");
        pastelDeCumplea�os.Decorar("M&Ms");
        pastelDeCumplea�os.Servir();
    }
}