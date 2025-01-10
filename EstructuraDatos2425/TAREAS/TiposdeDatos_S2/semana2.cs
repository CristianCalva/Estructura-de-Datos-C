public static class semana2{
    public static void run(){


Console.WriteLine("Triangulo-area perimetro");
Triangulo figura2 = new Triangulo(6,10,6,6,8);
Console.WriteLine("El area del triangulo es: " + figura2.CalcularArea() );
Console.WriteLine("El perimetro del triangulo es: " + figura2.CalcularPerimetro() );


Console.WriteLine("Rectangulo-area perimetro");
Rectangulo figura1 = new Rectangulo(7,10);

Console.WriteLine("El area del rectangulo es: " + figura1.Area() );

    }

}