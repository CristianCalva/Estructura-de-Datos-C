
public class Conjunto
{
    public static void Run()
    {
        // Generar el conjunto de 500 ciudadanos
        HashSet<string> ciudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add($"Ciudadano {i}");
        }

        // Generar el conjunto de ciudadanos vacunados con Pfizer
        HashSet<string> vacunadosPfizer = GenerarVacunados(ciudadanos, 75);
        
        // Generar el conjunto de ciudadanos vacunados con AstraZeneca
        HashSet<string> vacunadosAstraZeneca = GenerarVacunados(ciudadanos, 75);

        // Ciudadanos no vacunados
        HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
        noVacunados.ExceptWith(vacunadosPfizer);
        noVacunados.ExceptWith(vacunadosAstraZeneca);

        // Ciudadanos que recibieron ambas vacunas
        HashSet<string> ambasVacunas = new HashSet<string>(vacunadosPfizer);
        ambasVacunas.IntersectWith(vacunadosAstraZeneca);

        // Ciudadanos que solo recibieron Pfizer
        HashSet<string> soloPfizer = new HashSet<string>(vacunadosPfizer);
        soloPfizer.ExceptWith(vacunadosAstraZeneca);

        // Ciudadanos que solo recibieron AstraZeneca
        HashSet<string> soloAstraZeneca = new HashSet<string>(vacunadosAstraZeneca);
        soloAstraZeneca.ExceptWith(vacunadosPfizer);

        // Imprimir resultados
        ImprimirLista("Ciudadanos no vacunados", noVacunados);
        ImprimirLista("Ciudadanos con ambas vacunas", ambasVacunas);
        ImprimirLista("Ciudadanos solo con Pfizer", soloPfizer);
        ImprimirLista("Ciudadanos solo con AstraZeneca", soloAstraZeneca);
    }

    static HashSet<string> GenerarVacunados(HashSet<string> ciudadanos, int cantidad)
    {
        Random rand = new Random();
        HashSet<string> vacunados = new HashSet<string>();
        List<string> listaCiudadanos = ciudadanos.ToList();

        while (vacunados.Count < cantidad)
        {
            string ciudadano = listaCiudadanos[rand.Next(listaCiudadanos.Count)];
            vacunados.Add(ciudadano);
        }
        return vacunados;
    }

    static void ImprimirLista(string titulo, HashSet<string> lista)
    {
        Console.WriteLine($"\n{titulo} ({lista.Count} ciudadanos):");
        foreach (var ciudadano in lista)
        {
            Console.WriteLine(ciudadano);
        }
    }

    public static void run()
    {
        Run();
    }
}
