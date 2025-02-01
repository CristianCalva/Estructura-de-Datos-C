
class Atraccion
{
    private int capacidad;
    private Queue<string> colaEspera;
    private List<string> asientosOcupados;

    public Atraccion(int capacidad)
    {
        this.capacidad = capacidad;
        colaEspera = new Queue<string>();
        asientosOcupados = new List<string>();
    }

    public void AgregarPersona(string nombre)
    {
        if (asientosOcupados.Count < capacidad)
        {
            colaEspera.Enqueue(nombre);
            Console.WriteLine($"{nombre} ha sido añadido a la cola de espera.");
        }
        else
        {
            Console.WriteLine("Todos los asientos están vendidos. No se pueden añadir más personas a la cola.");
        }
    }

    public void SubirPersona()
    {
        if (colaEspera.Count > 0 && asientosOcupados.Count < capacidad)
        {
            string persona = colaEspera.Dequeue();
            asientosOcupados.Add(persona);
            Console.WriteLine($"{persona} ha subido a la atracción y ha ocupado un asiento.");
        }
        else if (colaEspera.Count == 0)
        {
            Console.WriteLine("No hay personas en la cola de espera.");
        }
        else
        {
            Console.WriteLine("Todos los asientos están vendidos. No se pueden subir más personas.");
        }
    }

    public void MostrarCola()
    {
        Console.WriteLine("Cola de espera:");
        foreach (var persona in colaEspera)
        {
            Console.WriteLine(persona);
        }
    }

    public void MostrarAsientosOcupados()
    {
        Console.WriteLine("Asientos ocupados:");
        for (int i = 0; i < asientosOcupados.Count; i++)
        {
            Console.WriteLine($"Asiento {i + 1}: {asientosOcupados[i]}");
        }
    }

    public int PersonasEnCola()
    {
        return colaEspera.Count;
    }
}

class Semana8
{
    public static void run()
    {
        Atraccion atraccion = new Atraccion(30);

        atraccion.AgregarPersona("Juan");
        atraccion.AgregarPersona("María");
        atraccion.AgregarPersona("Luis");
        atraccion.AgregarPersona("Ana");
        atraccion.AgregarPersona("Pedro");

        atraccion.MostrarCola();

        for (int i = 0; i < 30; i++)
        {
            atraccion.SubirPersona();
        }

        atraccion.MostrarAsientosOcupados();

        Console.WriteLine($"Personas en cola: {atraccion.PersonasEnCola()}");
    }
}

class Semana
{
    static void Main(string[] args)
    {
        Semana8.run();
    }
}
