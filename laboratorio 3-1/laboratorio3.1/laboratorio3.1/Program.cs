using System;

public class CalculosMatematicos
{
    public double Calcular(double a, double b)
    {
        return (a + b) * (a - b);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Crear una instancia de la clase CalculosMatematicos
        CalculosMatematicos calculadora = new CalculosMatematicos();

        // Solicitar al usuario que ingrese los dos números
        Console.Write("Ingrese el primer número (a): ");
        double numeroA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número (b): ");
        double numeroB = Convert.ToDouble(Console.ReadLine());

        // Calcular el resultado utilizando el método Calcular
        double resultado = calculadora.Calcular(numeroA, numeroB);

        // Mostrar el resultado en la consola
        Console.WriteLine($"El resultado de la operación (a+b)*(a-b) es: {resultado}");
    }
}