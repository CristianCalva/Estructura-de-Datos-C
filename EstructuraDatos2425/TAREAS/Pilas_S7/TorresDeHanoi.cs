
public class TorreDeHanoi
{
    // Propiedades estáticas para representar las tres pilas (torres)
    private static Stack<int> torre1 = new Stack<int>();
    private static Stack<int> torre2 = new Stack<int>();
    private static Stack<int> torre3 = new Stack<int>();

    // Método estático para inicializar las pilas con discos en la torre 1
    private static void Inicializar(int cantidadDeDiscos)
    {
        // Añadimos los discos a la torre1 (de mayor a menor)
        for (int i = cantidadDeDiscos; i >= 1; i--)
        {
            torre1.Push(i);
        }
    }

    // Método estático para imprimir el estado actual de las tres torres
    private static void ImprimirEstado()
    {
        Console.WriteLine("Estado actual de las torres:");
        Console.WriteLine($"Torre 1: {string.Join(", ", torre1)}");
        Console.WriteLine($"Torre 2: {string.Join(", ", torre2)}");
        Console.WriteLine($"Torre 3: {string.Join(", ", torre3)}");
        Console.WriteLine();
    }

    // Método estático para resolver las Torres de Hanoi, moviendo discos de torre origen a torre destino
    private static void MoverDisco(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar)
    {
        if (n == 1)
        {
            // Si hay un solo disco, lo movemos directamente de la torre origen a la torre destino
            Console.WriteLine($"Mover disco {origen.Peek()} de {GetNombreTorre(origen)} a {GetNombreTorre(destino)}");
            destino.Push(origen.Pop());
            ImprimirEstado(); // Imprimimos el estado después de cada movimiento
        }
        else
        {
            // Mover los n-1 discos a la torre auxiliar
            MoverDisco(n - 1, origen, auxiliar, destino);

            // Mover el disco más grande a la torre destino
            Console.WriteLine($"Mover disco {origen.Peek()} de {GetNombreTorre(origen)} a {GetNombreTorre(destino)}");
            destino.Push(origen.Pop());
            ImprimirEstado(); // Imprimimos el estado después de cada movimiento

            // Mover los n-1 discos de la torre auxiliar a la torre destino
            MoverDisco(n - 1, auxiliar, destino, origen);
        }
    }

    // Método estático para obtener el nombre de la torre (representación visual)
    private static string GetNombreTorre(Stack<int> torre)
    {
        if (torre == torre1)
            return "Torre 1";
        else if (torre == torre2)
            return "Torre 2";
        else
            return "Torre 3";
    }

    // Método estático público para iniciar la solución del problema de Torres de Hanoi
    public static void run(int cantidadDeDiscos)
    {
        Inicializar(cantidadDeDiscos); // Inicializamos las torres
        ImprimirEstado(); // Imprimimos el estado inicial de las torres
        MoverDisco(cantidadDeDiscos, torre1, torre3, torre2); // Llamamos a la función que resuelve el problema
    }
}

// Ejemplo de cómo llamar al método Run
public class Programa
{
    public void Ejecutar()
    {
        // Llamamos al método Run con 3 discos como ejemplo
        TorreDeHanoi.run(3);
    }
}


