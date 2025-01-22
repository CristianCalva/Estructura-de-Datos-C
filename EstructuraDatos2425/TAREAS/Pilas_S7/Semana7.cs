
public class Semana7
{
    /// <summary>
    /// Ejecuta la verificación de fórmulas balanceadas.
    /// </summary>
    public static void run()
    {
        // Fórmula matemática 
        string formula = "{7+(8*5)-[(9-7)+(4+1)]}";

        // Verificar si la fórmula está balanceada
        bool esBalanceada = VerificarBalanceo(formula);

        // Mostrar resultado
        Console.WriteLine(esBalanceada ? "La fórmula está balanceada." : "La fórmula no está balanceada.");
    }

    /// <summary>
    /// Verifica si una fórmula matemática tiene paréntesis, corchetes y llaves balanceados.
    /// </summary>
    /// <param name="formula">La fórmula matemática como cadena de texto.</param>
    /// <returns>True si está balanceada, False en caso contrario.</returns>
    private static bool VerificarBalanceo(string formula)
    {
        // Pilas para realizar el seguimiento de los caracteres de apertura.
        Stack<char> pila = new Stack<char>();

        
        Dictionary<char, char> pares = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        // Recorremos cada carácter de la fórmula.
        foreach (char c in formula)
        {
            // Si es un carácter de apertura, lo añadimos a la pila.
            if (c == '(' || c == '[' || c == '{')
            {
                pila.Push(c);
            }
            // Si es un carácter de cierre, verificamos el balanceo.
            else if (c == ')' || c == ']' || c == '}')
            {
                // Si la pila está vacía o el carácter no coincide con el último de la pila, no está balanceado.
                if (pila.Count == 0 || pila.Peek() != pares[c])
                {
                    return false;
                }
                // Si coincide, retiramos el carácter de apertura de la pila.
                pila.Pop();
            }
        }

        // Si la pila está vacía al final, los paréntesis están balanceados.
        return pila.Count == 0;
    }
}
