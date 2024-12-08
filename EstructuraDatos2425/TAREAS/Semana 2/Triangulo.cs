
public class Triangulo{
    private double baseTraingulo;
    private double Altura;
    private double Lado1;
    private double Lado2;
    private double Lado3;


    public Triangulo(double _baseTriangulo, double _altura, double _lado1, double _lado2, double _lado3){
        this.baseTraingulo = _baseTriangulo;
        this.Altura = _altura;
        this.Lado1 = _lado1;
        this.Lado2 = _lado2;
        this.Lado3 = _lado3;
        
     }

    public double CalcularArea(){
        return(baseTraingulo * Altura) / 2;
    }

    }
