using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese el largo del rectángulo
        Console.Write("Ingrese el largo del rectángulo: ");
        double largo = Convert.ToDouble(Console.ReadLine());

        // Solicitar al usuario que ingrese el ancho del rectángulo
        Console.Write("Ingrese el ancho del rectángulo: ");
        double ancho = Convert.ToDouble(Console.ReadLine());

        // Calcular el perímetro
        double perimetro = 2 * (largo + ancho);

        // Mostrar el resultado en la consola
        Console.WriteLine($"El perímetro del rectángulo es: {perimetro}");
    }
}