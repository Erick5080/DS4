using System;

public class CalculosMatematicos
{
    public double CalculoArea(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Crear una instancia de la clase CalculosMatematicos
        CalculosMatematicos calculadora = new CalculosMatematicos();

        // Solicitar al usuario que ingrese el radio del círculo
        Console.Write("Ingrese el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        // Calcular el área utilizando el método CalculoArea
        double area = calculadora.CalculoArea(radio);

        // Mostrar el resultado en la consola
        Console.WriteLine($"El área del círculo es: {area}");
    }
}