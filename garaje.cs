using System;

// Clase Motor
class Motor
{
    public int LitrosDeAceite { get; set; }
    public int Potencia { get; private set; }

    public Motor(int potencia)
    {
        Potencia = potencia;
        LitrosDeAceite = 0;
    }
}



// Clase coche
class Coche
{
    public Motor Motor { get; set; }
    public string Marca { get; }
    public string Modelo { get; }
    public double PrecioAverias { get; private set; }

    public Coche(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
        PrecioAverias = 0;
    }

    public void AcumularAveria(double importe)
    {
        PrecioAverias += importe;
    }
}



// Clase Garaje
class Garaje
{
    private Coche coche;
    private string averia_asociada;
    private int coches_atendidos;

    public Garaje()
    {
        coches_atendidos = 0;
    }

    public bool AceptarCoche(Coche coche, string averia_asociada)
    {
        if (this.coche != null)
            return false;

        this.coche = coche;
        this.averia_asociada = averia_asociada;
        coches_atendidos++;
        return true;
    }

    public void DevolverCoche()
    {
        coche = null;
        averia_asociada = null;
    }

    public int CochesAtendidos => coches_atendidos;
    public string AveriaAsociada => averia_asociada;
}



// Clase Principal método Main
class PracticaPOO
{
    static void Main(string[] args)
    {
        Garaje garaje = new Garaje();
        Coche coche1 = new Coche("Toyota", "Corolla");
        Coche coche2 = new Coche("Honda", "Civic");

        Random rnd = new Random();

        for (int i = 0; i < 2; i++)
        {
            coche1.Motor = new Motor(150); // Asigna un nuevo objeto Motor a coche1 antes de entrar al garaje

            if (garaje.AceptarCoche(coche1, "aceite"))
            {
                Console.WriteLine("Coche 1 entró al garaje.");
                double importe = rnd.NextDouble() * 100; // Genera un importe aleatorio entre 0 y 100
                coche1.AcumularAveria(importe);
                if (garaje.AveriaAsociada == "aceite")
                {
                    coche1.Motor.LitrosDeAceite += 10;
                }
                garaje.DevolverCoche();
            }

            if (garaje.AceptarCoche(coche2, "motor"))
            {
                Console.WriteLine("Coche 2 entró al garaje.");
                double importe = rnd.NextDouble() * 100; // Genera un importe aleatorio entre 0 y 100
                coche2.AcumularAveria(importe);
                garaje.DevolverCoche();
            }
        }

        Console.WriteLine("Información de los coches:");
        Console.WriteLine("Marca: {0}, Modelo: {1}, Precio de Averías: {2}", coche1.Marca, coche1.Modelo, coche1.PrecioAverias);
        Console.WriteLine("Marca: {0}, Modelo: {1}, Precio de Averías: {2}", coche2.Marca, coche2.Modelo, coche2.PrecioAverias);
    }
}
