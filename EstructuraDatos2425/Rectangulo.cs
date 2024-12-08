
/// La clase rectangulo encapsula los atributos y proporciona metodos para calcular su area 
public class Rectangulo{
    private double Base;    /// Atributos privados
    private double Altura;


/// <summary>
/// Contructr de la clase rectangulo
/// </summary>
/// <param name="_base">La medidad de la base del rectangulo</param>
/// <param name="_altura">La medidad de la altura del rectangulo</param>
    public Rectangulo(double _base, double _altura){
        Base = _base;
        Altura = _altura;
    }


/// <summary>
/// Funcion para calcular el area de un rectangulo
/// </summary>
/// <returns> Retorna un valor double </returns>
    public double Area(){
        return Base * Altura;

    }

    }

    

    