// Clase principal para gestionar el torneo de fútbol
class Torneo
{
    // Diccionario para almacenar los equipos y sus jugadores
    static Dictionary<string, HashSet<string>> equipos = new Dictionary<string, HashSet<string>>();

    public static void Run()
    {
        while (true)
        {
            Console.WriteLine("--- Gestión de Torneo de Fútbol ---");
            Console.WriteLine("1. Registrar nuevo equipo");
            Console.WriteLine("2. Agregar jugador a un equipo");
            Console.WriteLine("3. Ver equipos y jugadores");
            Console.WriteLine("4. Comparar jugadores de dos equipos");
            Console.WriteLine("5. Salir");
            Console.Write("Elige una opción: ");
            
            string? opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1": RegistrarEquipo(); break;
                case "2": AgregarJugador(); break;
                case "3": ListarEquipos(); break;
                case "4": CompararEquipos(); break;
                case "5": return;
                default: Console.WriteLine("Opción no válida, por favor ingresa una opción correcta."); break;
            }
        }
    }

    // Método para registrar un nuevo equipo
    static void RegistrarEquipo()
    {
        Console.Write("¿Cómo se llama el equipo? ");
        string? equipo = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(equipo) && !equipos.ContainsKey(equipo))
        {
            equipos[equipo] = new HashSet<string>();
            Console.WriteLine("¡Equipo registrado con éxito!");
        }
        else
        {
            Console.WriteLine("Ese nombre de equipo ya existe o no es válido.");
        }
    }

    // Método para agregar un jugador a un equipo
    static void AgregarJugador()
    {
        Console.Write("¿A qué equipo quieres agregar un jugador? ");
        string? equipo = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(equipo) || !equipos.ContainsKey(equipo))
        {
            Console.WriteLine("El equipo no existe. Asegúrate de que lo escribiste correctamente.");
            return;
        }
        
        Console.Write("¿Cómo se llama el jugador? ");
        string? jugador = Console.ReadLine();
        
        if (!string.IsNullOrWhiteSpace(jugador) && equipos[equipo].Add(jugador))
            Console.WriteLine("¡Jugador agregado con éxito!");
        else
            Console.WriteLine("Ese jugador ya está en el equipo o el nombre no es válido.");
    }

    // Método para listar todos los equipos y sus jugadores
    static void ListarEquipos()
    {
        if (equipos.Count == 0)
        {
            Console.WriteLine("Todavía no hay equipos registrados.");
            return;
        }
        
        foreach (var equipo in equipos)
        {
            Console.WriteLine($"Equipo: {equipo.Key}");
            Console.WriteLine("Jugadores: " + (equipo.Value.Count > 0 ? string.Join(", ", equipo.Value) : "Este equipo aún no tiene jugadores."));
        }
    }

    // Método para comparar jugadores entre dos equipos
    static void CompararEquipos()
    {
        Console.Write("¿Cuál es el primer equipo? ");
        string? equipo1 = Console.ReadLine();
        Console.Write("¿Y el segundo equipo? ");
        string? equipo2 = Console.ReadLine();
        
        if (string.IsNullOrWhiteSpace(equipo1) || string.IsNullOrWhiteSpace(equipo2) || !equipos.ContainsKey(equipo1) || !equipos.ContainsKey(equipo2))
        {
            Console.WriteLine("Uno o ambos equipos no existen o los nombres no son válidos. Por favor, revisa los nombres.");
            return;
        }
        
        HashSet<string> jugadores1 = equipos[equipo1];
        HashSet<string> jugadores2 = equipos[equipo2];
        
        // Jugadores en ambos equipos
        HashSet<string> interseccion = new HashSet<string>(jugadores1);
        interseccion.IntersectWith(jugadores2);
        
        // Jugadores exclusivos de equipo1
        HashSet<string> diferencia = new HashSet<string>(jugadores1);
        diferencia.ExceptWith(jugadores2);
        
        Console.WriteLine("Jugadores en ambos equipos: " + (interseccion.Count > 0 ? string.Join(", ", interseccion) : "No hay coincidencias"));
        Console.WriteLine("Jugadores exclusivos del primer equipo: " + (diferencia.Count > 0 ? string.Join(", ", diferencia) : "Ninguno"));
    }
}
