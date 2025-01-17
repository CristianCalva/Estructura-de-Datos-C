using System;

class Nodo(int dato)
{
    public int dato = dato;
    public Nodo? siguiente = null;
}

class Lista
{
    public Nodo? cabeza;

#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de agregar el modificador "required" o declararlo como un valor que acepta valores NULL.
    public Lista()
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de agregar el modificador "required" o declararlo como un valor que acepta valores NULL.
    {
        cabeza = null;
    }

    // Método para agregar un elemento al final de la lista
    public void Agregar(int dato)
    {
        Nodo nuevoNodo = new Nodo(dato);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.siguiente != null)
            {
                actual = actual.siguiente;
            }
            actual.siguiente = nuevoNodo;
        }
    }

    // Método de búsqueda que devuelve el número de veces que se encuentra el dato en la lista
    public void Buscar(int valor)
    {
        int contador = 0;
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
        Nodo actual = cabeza;
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
        while (actual != null)
        {
            if (actual.dato == valor)
            {
                contador++;
            }
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            actual = actual.siguiente;
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
        }

        if (contador > 0)
        {
            Console.WriteLine($"El número {valor} aparece {contador} veces en la lista.");
        }
        else
        {
            Console.WriteLine($"El número {valor} no fue encontrado en la lista.");
        }
    }

    // Método para eliminar nodos fuera de un rango dado
    public void EliminarFueraDeRango(int min, int max)
    {
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
        Nodo actual = cabeza;
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
        Nodo? anterior = null;

        while (actual != null)
        {
            if (actual.dato < min || actual.dato > max)
            {
                if (anterior == null) // Si el nodo a eliminar es el primero
                {
                    cabeza = actual.siguiente;
                }
                else
                {
                    anterior.siguiente = actual.siguiente;
                }
            }
            else
            {
                anterior = actual;
            }
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            actual = actual.siguiente;
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
        }
    }

    // Método para mostrar la lista
    public void Mostrar()
    {
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
        Nodo actual = cabeza;
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
        while (actual != null)
        {
            Console.Write(actual.dato + " ");
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            actual = actual.siguiente;
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
        }
        Console.WriteLine();
    }
}

class Semana6
{
    public static void run()
    {
        // Ejercicio 1: Búsqueda en la lista
        Lista lista1 = new Lista();
        lista1.Agregar(5);
        lista1.Agregar(10);
        lista1.Agregar(5);
        lista1.Agregar(15);
        lista1.Agregar(5);

        Console.WriteLine("Ejercicio 1: Búsqueda en la lista");
        lista1.Buscar(5);  // Prueba de búsqueda
        lista1.Buscar(100); // Prueba de búsqueda de número no encontrado
        Console.WriteLine();

        // Ejercicio 2: Eliminar valores fuera de un rango
        Lista lista2 = new Lista();
        Random rand = new Random();

        // Crear una lista con 50 números aleatorios entre 1 y 999
        for (int i = 0; i < 50; i++)
        {
            lista2.Agregar(rand.Next(1, 1000));
        }

        Console.WriteLine("Ejercicio 2: Eliminar valores fuera del rango");
        Console.WriteLine("Lista original:");
        lista2.Mostrar();

        // Leer el rango de valores desde el teclado
        Console.Write("Ingrese el valor mínimo: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor máximo: ");
        int max = int.Parse(Console.ReadLine());

        // Eliminar nodos fuera del rango
        lista2.EliminarFueraDeRango(min, max);

        Console.WriteLine($"Lista después de eliminar los valores fuera del rango ({min}, {max}):");
        lista2.Mostrar();
    }
}
