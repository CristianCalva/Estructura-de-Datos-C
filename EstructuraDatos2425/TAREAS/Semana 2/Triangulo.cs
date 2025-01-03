/// <summary>
/// La clase triangulo representa un figura geometrica
/// </summary>
public class Triangulo{
    private double baseTraingulo;
    private double Altura;
    private double Lado1;
    private double Lado2;
    private double Lado3;

/// <summary>
/// Constructor de la clase triangulo para inicializar los valores
/// </summary>
/// <param name="_baseTriangulo">Es la medida de la base del triangulo</param>
/// <param name="_altura">Es la medida de la altura del triangulo</param>
/// <param name="_lado1">Es la medidad del lado 1 del triangulo</param>
/// <param name="_lado2">Es la medidad del lado 2 del triangulo</param>
/// <param name="_lado3">Es la medidad del lado 3 del triangulo</param>
    public Triangulo(double _baseTriangulo, double _altura, double _lado1, double _lado2, double _lado3){
        this.baseTraingulo = _baseTriangulo;
        this.Altura = _altura;
        this.Lado1 = _lado1;
        this.Lado2 = _lado2;
        this.Lado3 = _lado3;
        
     }

/// <summary>
/// Metodo para calcular  el area del triangulo
/// </summary>
/// <returns>Se utiliza la formula (base * altura) / 2 </returns>
    public double CalcularArea(){
        return(baseTraingulo * Altura) / 2;
    }

/// <summary>
/// Metodo para calcular el perimetro del triangulo
/// </summary>
/// <returns>La suma de los tres lados del triangulo</returns>

    public double CalcularPerimetro(){
        return Lado1 + Lado2 + Lado3;
    }

    }
