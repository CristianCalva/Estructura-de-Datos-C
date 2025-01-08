public static class semana3{

    // Clase que representa un producto
class Producto
{
    // Propiedades del producto
    public int Id { get; set; } // Identificador único del producto
    public string Nombre { get; set; } // Nombre del producto
    public string Unidad { get; set; } // Unidad de medida del producto (ej: kg, unidad, litro)
    public decimal[] Precios { get; set; } // Array para almacenar tres precios del producto

    // Constructor para inicializar un producto
    public Producto(int id, string nombre, string unidad, decimal[] precios)
    {
        Id = id;
        Nombre = nombre;
        Unidad = unidad;
        Precios = precios;
    }

    // Método para mostrar la información del producto
    public void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}\nNombre: {Nombre}\nUnidad: {Unidad}");
        Console.WriteLine("Precios:");
        for (int i = 0; i < Precios.Length; i++)
        {
            Console.WriteLine($"  Precio {i + 1}: {Precios[i]:C}");
        }
    }
}


    public static void run(){
        Producto miproducto = new Producto(1,"esfero", "unidad", [1,2,3]);
        miproducto.MostrarInformacion(); 
    }
}
