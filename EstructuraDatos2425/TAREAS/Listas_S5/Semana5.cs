using System;
using System.Collections.Generic;

// Namespace para la gestión de cursos
namespace GestionDeCursos
{
    public class Curso
    {
        public List<string> Asignaturas { get; private set; }

        public Curso()
        {
            Asignaturas = new List<string>();
        }

        public void AgregarAsignatura(string asignatura)
        {
            Asignaturas.Add(asignatura);
        }

        public void MostrarAsignaturas()
        {
            Console.WriteLine("Asignaturas del curso:");
            foreach (string asignatura in Asignaturas)
            {
                Console.WriteLine($"- {asignatura}");
            }
        }
    }
}

// Namespace para producto escalar
namespace ProductoEscalar
{
    public class Vector
    {
        public List<int> Componentes { get; private set; }

        public Vector(List<int> componentes)
        {
            Componentes = componentes;
        }

        public int ProductoEscalar(Vector otroVector)
        {
            if (Componentes.Count != otroVector.Componentes.Count)
            {
                throw new InvalidOperationException("Los vectores deben tener la misma cantidad de componentes.");
            }

            int resultado = 0;

            for (int i = 0; i < Componentes.Count; i++)
            {
                resultado += Componentes[i] * otroVector.Componentes[i];
            }

            return resultado;
        }
    }
}

// Namespace para el abecedario
namespace Abecedario
{
    public class Abecedario
    {
        public List<char> Letras { get; private set; }

        public Abecedario()
        {
            Letras = new List<char>();
            for (char letra = 'A'; letra <= 'Z'; letra++)
            {
                Letras.Add(letra);
            }
        }

        public void EliminarLetrasMultiploDeTres()
        {
            for (int i = Letras.Count - 1; i >= 0; i--)
            {
                if ((i + 1) % 3 == 0)
                {
                    Letras.RemoveAt(i);
                }
            }
        }

        public void MostrarLetras()
        {
            Console.WriteLine("Letras restantes después de eliminar las posiciones múltiplos de 3:");
            foreach (var letra in Letras)
            {
                Console.Write(letra + " ");
            }
            Console.WriteLine();
        }
    }
}

// Namespace para números inversos
namespace NumerosInversos
{
    public class ListaNumeros
    {
        public List<int> Numeros { get; private set; }

        public ListaNumeros()
        {
            Numeros = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                Numeros.Add(i);
            }
        }

        public void MostrarNumerosInversos()
        {
            for (int i = Numeros.Count - 1; i >= 0; i--)
            {
                if (i != 0)
                {
                    Console.Write(Numeros[i] + ", ");
                }
                else
                {
                    Console.Write(Numeros[i]);
                }
            }
            Console.WriteLine();
        }
    }
}

// Namespace para asignaturas y notas
namespace AsignaturasCurso
{
    public class Curso
    {
        public List<string> Asignaturas { get; set; }

        public Curso()
        {
            Asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
        }

        public void EliminarAsignaturasAprobadas()
        {
            List<string> asignaturasARepetir = new List<string>();

            foreach (var asignatura in Asignaturas)
            {
                Console.WriteLine($"¿Qué nota sacaste en {asignatura}?");
                if (int.TryParse(Console.ReadLine(), out int nota))
                {
                    if (nota < 5)
                    {
                        asignaturasARepetir.Add(asignatura);
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida, por favor ingrese una nota numérica.");
                }
            }

            Asignaturas = asignaturasARepetir;
        }

        public void MostrarAsignaturasARepetir()
        {
            if (Asignaturas.Count > 0)
            {
                Console.WriteLine("\nLas asignaturas que tienes que repetir son:");
                foreach (var asignatura in Asignaturas)
                {
                    Console.WriteLine(asignatura);
                }
            }
            else
            {
                Console.WriteLine("\n¡Felicidades! Has aprobado todas las asignaturas.");
            }
        }
    }
}

// Clase principal que ejecutará todos los bloques
public static class Semana5
{
    public static void run()
    {
        // Ejecución del primer bloque: Gestión de Cursos
        Console.WriteLine("Ejecución del código para Gestión de Cursos:");
        GestionDeCursos.Curso curso = new GestionDeCursos.Curso();
        curso.AgregarAsignatura("Matemáticas");
        curso.AgregarAsignatura("Física");
        curso.AgregarAsignatura("Química");
        curso.AgregarAsignatura("Historia");
        curso.AgregarAsignatura("Lengua");
        curso.MostrarAsignaturas();
        Console.WriteLine("\n--- Fin del primer bloque ---\n");

        // Ejecución del segundo bloque: Producto Escalar
        Console.WriteLine("Ejecución del código para Producto Escalar:");
        List<int> vector1Componentes = new List<int> { 1, 2, 3 };
        List<int> vector2Componentes = new List<int> { -1, 0, 2 };
        ProductoEscalar.Vector vector1 = new ProductoEscalar.Vector(vector1Componentes);
        ProductoEscalar.Vector vector2 = new ProductoEscalar.Vector(vector2Componentes);
        try
        {
            int productoEscalar = vector1.ProductoEscalar(vector2);
            Console.WriteLine("El producto escalar de los dos vectores es: " + productoEscalar);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("\n--- Fin del segundo bloque ---\n");

        // Ejecución del tercer bloque: Abecedario
        Console.WriteLine("Ejecución del código para Abecedario:");
        Abecedario.Abecedario abecedario = new Abecedario.Abecedario();
        abecedario.MostrarLetras();
        abecedario.EliminarLetrasMultiploDeTres();
        abecedario.MostrarLetras();
        Console.WriteLine("\n--- Fin del tercer bloque ---\n");

        // Ejecución del cuarto bloque: Números Inversos
        Console.WriteLine("Ejecución del código para Números Inversos:");
        NumerosInversos.ListaNumeros lista = new NumerosInversos.ListaNumeros();
        lista.MostrarNumerosInversos();
        Console.WriteLine("\n--- Fin del cuarto bloque ---\n");

        // Ejecución del quinto bloque: Asignaturas Curso
        Console.WriteLine("Ejecución del código para Asignaturas Curso:");
        AsignaturasCurso.Curso cursoAsignaturas = new AsignaturasCurso.Curso();
        cursoAsignaturas.EliminarAsignaturasAprobadas();
        cursoAsignaturas.MostrarAsignaturasARepetir();
    }
}
