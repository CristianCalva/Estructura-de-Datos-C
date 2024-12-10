using System.Timers;

Console.WriteLine("=============================");
Console.WriteLine("Universidad Estatal Amazonica");
Console.WriteLine("=============================");
Console.WriteLine();

Console.WriteLine("=============================");
Console.WriteLine("Triangulo-area perimetro");
Triangulo figura2 = new Triangulo(9,6,9,6,6);
Console.WriteLine("El area del triangulo es: " + figura2.CalcularArea() );

Console.WriteLine("=============================");
Console.WriteLine("rectangulo-area perimetro");
Rectangulo figura1 = new Rectangulo(7,10);
Console.WriteLine("El area del rectangulo es: " + figura1.Area() );
