using System;

class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }

    public Persona(string nombre, string apellido)
    {
        Nombre = nombre;
        Apellido = apellido;
    }

    public void Hablar()
    {
        Console.WriteLine($"{Nombre} {Apellido} dice: Buenos días!");
    }
}

class Estudiante : Persona
{
    public Estudiante(string nombre, string apellido) : base(nombre, apellido)
    {
    }

    public new void Hablar()
    {
        base.Hablar();
        Console.WriteLine(" (Estudiante)");
    }
}

class Profesor : Persona
{
    public Profesor(string nombre, string apellido) : base(nombre, apellido)
    {
    }

    public new void Hablar()
    {
        base.Hablar();
        Console.WriteLine(" (Profesor)");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Persona[] personas = new Persona[]
        {
            new Estudiante("Juan", "Pérez"),
            new Estudiante("María", "García"),
            new Profesor("Ana", "López"),
            new Profesor("Pedro", "Martínez"),
        };

        foreach (Persona persona in personas)
        {
            persona.Hablar();
        }
    }
}
