// Herencia Simple o única

using System;

// Clase base
public class Vehiculo
{
    public string Marca { get; set; }

    public void EncenderMotor()
    {
        Console.WriteLine("¡Motor encendido! ¡Vroom vroom!");
    }
}

// Clase derivada
public class Carro : Vehiculo
{
    public string Modelo { get; set; }

    public void MostrarDetalles()
    {
        Console.WriteLine($"Este vehículo es de la marca {Marca} y modelo {Modelo}.");
    }
    public void TocarBocina()
    {
        Console.WriteLine("¡Beep Beep!");
    }

    public void EncenderLuces()
    {
        Console.WriteLine("¡Luces encendidas!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Carro miCarro = new Carro();
        miCarro.Marca = "Audi";
        miCarro.Modelo = "Q3";

        miCarro.EncenderMotor();
        miCarro.TocarBocina();
        miCarro.EncenderLuces();
        miCarro.MostrarDetalles();
    }
}