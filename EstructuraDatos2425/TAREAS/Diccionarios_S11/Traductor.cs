
class Traductor
{
    // Diccionario con palabras en español y sus traducciones al inglés
    static Dictionary<string, string> diccionario = new Dictionary<string, string>
    {
        {"perro", "dog"}, {"luna", "moon"}, {"playa", "beach"},
        {"rio", "river"}, {"montaña", "mountain"}, {"nube", "cloud"},
        {"ciudad", "city"}, {"mar", "sea"}, {"cielo", "sky"},
        {"bosque", "forest"}, {"fuego", "fire"}, {"estrella", "star"},
        {"hoja", "leaf"}, {"trueno", "thunder"}, {"viento", "wind"},
        {"sol", "sun"}, {"nieve", "snow"}, {"lluvia", "rain"}
    };

    public static void Run()
    {
        int opcion;
        do
        {
            // Menú principal
            Console.WriteLine("***DICCIONARIO ESPAÑOL/INGLES***");
            Console.WriteLine("    +++MENU PRINCIPAL+++        ");
            Console.WriteLine("================================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    TraducirFrase();
                    break;
                case 2:
                    AgregarPalabra();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa... ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no reconocida, intente nuevamente.");
                    break;
            }
        } while (opcion != 0);
    }

    static void TraducirFrase()
    {
        Console.Write("Ingrese una frase en español: ");
        string? frase = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(frase))
        {
            Console.WriteLine("No ingresó una frase válida.");
            return;
        }

        string[] palabras = frase.ToLower().Split(' '); // Convertir y separar en palabras

        for (int i = 0; i < palabras.Length; i++)
        {
            if (diccionario.TryGetValue(palabras[i], out string? traduccion))
            {
                palabras[i] = traduccion; // Reemplaza solo si está en el diccionario
            }
        }

        Console.WriteLine("Traducción: " + string.Join(" ", palabras));
    }

    static void AgregarPalabra()
    {
        Console.Write("Ingrese la palabra en español: ");
        string? espanol = Console.ReadLine()?.Trim().ToLower();

        if (string.IsNullOrEmpty(espanol))
        {
            Console.WriteLine("Debe ingresar una palabra válida.");
            return;
        }

        Console.Write("Ingrese la traducción en inglés: ");
        string? ingles = Console.ReadLine()?.Trim().ToLower();

        if (string.IsNullOrEmpty(ingles))
        {
            Console.WriteLine("Debe ingresar una traducción válida.");
            return;
        }

        if (diccionario.ContainsKey(espanol))
        {
            Console.WriteLine("Esa palabra ya está en el diccionario.");
        }
        else
        {
            diccionario.Add(espanol, ingles);
            Console.WriteLine("Palabra agregada con éxito.");
        }
    }
}
