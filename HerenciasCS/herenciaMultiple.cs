// Herencia multiple (Con interfaces)


using System;

// Interfaz Ataque
public interface IAtacar
{
    void Atacar();
}

// Interfaz Curación
public interface ISanar
{
    void Sanar();
}

// Interfaz Sigilo
public interface ISigiloso
{
    void Sigiloso();
}

// Clase Personaje
public class Personaje
{
    public string Nombre { get; set; }

    public void MostrarNombre()
    {
        Console.WriteLine($"Nombre del personaje: {Nombre}");
    }
}

// Clase Guerrero
public class Guerrero : Personaje, IAtacar, ISanar
{
    public void Atacar()
    {
        Console.WriteLine($"{Nombre} ataca con su espada!");
    }

    public void Sanar()
    {
        Console.WriteLine($"{Nombre} se cura usando una poción.");
    }
}

// Clase Ladrón
public class Ladron : Personaje, IAtacar, ISigiloso
{
    public void Atacar()
    {
        Console.WriteLine($"{Nombre} realiza un ataque furtivo!");
    }

    public void Sigiloso()
    {
        Console.WriteLine($"{Nombre} se mueve sigilosamente entre las sombras.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Guerrero guerrero = new Guerrero();
        guerrero.Nombre = "Ragnar";
        guerrero.MostrarNombre();
        guerrero.Atacar();
        guerrero.Sanar();

        Console.WriteLine();

        Ladron ladron = new Ladron();
        ladron.Nombre = "Darko";
        ladron.MostrarNombre();
        ladron.Atacar();
        ladron.Sigiloso();
    }
}
