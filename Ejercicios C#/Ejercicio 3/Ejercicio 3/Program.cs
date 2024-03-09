using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad en kilómetros: ");
        double cantidadKilometros = Convert.ToDouble(Console.ReadLine());

        double metros = cantidadKilometros * 1000;
        double yardas = cantidadKilometros * 1094;
        double varas = cantidadKilometros * 1194;

        Console.WriteLine($"En metros: {metros} metros");
        Console.WriteLine($"En yardas: {yardas} yardas");
        Console.WriteLine($"En varas: {varas} varas");
    }
}
