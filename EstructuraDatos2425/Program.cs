using System.Timers;

Console.WriteLine("=============================");
Console.WriteLine("Universidad Estatal Amazonica");
Console.WriteLine("=============================");
Console.WriteLine("===Estructura de Datos===");
Console.WriteLine("=============================");
Console.WriteLine("Cristian Paul Calva Abad");
Console.WriteLine("=============================");
Console.WriteLine();

Console.WriteLine("=============================");
Console.WriteLine("Triangulo-area perimetro");
Triangulo figura2 = new Triangulo(6,10,6,6,8);
Console.WriteLine("El area del triangulo es: " + figura2.CalcularArea() );
Console.WriteLine("El perimetro del triangulo es: " + figura2.CalcularPerimetro() );

Console.WriteLine("=============================");
Console.WriteLine("Rectangulo-area perimetro");
Rectangulo figura1 = new Rectangulo(7,10);
Console.WriteLine("El area del rectangulo es: " + figura1.Area() );
