class CatalogoRevistas
{
    // Lista para almacenar los títulos de las revistas
    static List<string> catalogo = new List<string>
    {
        "Revista de Ciencia",
        "Revista de Sociales",
        "Revista de Ingles",
        "Revista de Historia",
        "Revista de Literatura",
        "Revista de Medicina",
        "Revista de Ropa",
        "Revista de Arte",
        "Revista de Calzado",
        "Revista de Perfumes"
    };

    
    public static void Run()
    {
        while (true)
        {
            // Menú de las opciones
            Console.WriteLine("--- Catálogo de Revistas ---");
            Console.WriteLine("1. Buscar un título");
            Console.WriteLine("2. Salir");
            Console.Write("Seleccione una opción (1 o 2): ");
            
            
            string? opcion = Console.ReadLine();
            
            switch (opcion)
            {
                case "1":
                    BuscarTituloMenu();
                    break;
                case "2":
                    return;
                default:
                    Console.WriteLine("Opción no válida, por favor ingresa una opción correcta.");
                    break;
            }
        }
    }

    // Método para buscar un título en el catálogo
    static void BuscarTituloMenu()
    {
        Console.Write("Ingrese el título a buscar: ");
        string? tituloBusqueda = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(tituloBusqueda)) // Verifica que el título no esté vacío
        {
            if (BuscarTitulo(tituloBusqueda))
            {
                Console.WriteLine("Título encontrado.");
            }
            else
            {
                Console.WriteLine("Título no encontrado.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un título válido.");
        }
    }

    // Función de búsqueda iterativa
    static bool BuscarTitulo(string titulo)
    {
        foreach (var item in catalogo)
        {
            if (item.Equals(titulo, StringComparison.OrdinalIgnoreCase))
            {
                return true; // Título encontrado
            }
        }
        return false; // Título no encontrado
    }
}