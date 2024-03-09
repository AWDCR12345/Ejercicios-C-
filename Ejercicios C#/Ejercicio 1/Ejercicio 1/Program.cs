using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el nombre del vendedor: ");
        string nombre = Console.ReadLine();

        double[] ventasMensuales = new double[12];

        for (int i = 0; i < 12; i++)
        {
            Console.Write($"Ingrese las ventas para el mes {i + 1}: ");
            if (double.TryParse(Console.ReadLine(), out double ventas))
            {
                ventasMensuales[i] = ventas;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Ingrese un número válido.");
                i--; 
            }
        }

        double promedioVentas = CalculaPromedio(ventasMensuales);

        Console.WriteLine($"El promedio de ventas mensuales de {nombre} es: {promedioVentas:C}");
    }
    static double CalculaPromedio(double[] ventasMensuales)
    {
        double totalVentas = 0;

        foreach (double ventas in ventasMensuales)
        {
            totalVentas += ventas;
        }

        return totalVentas / ventasMensuales.Length;
    }
}