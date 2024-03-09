using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el sueldo base del empleado:");
        double sueldoBase = Convert.ToDouble(Console.ReadLine());

        double renta = sueldoBase * 0.10;
        double afp = sueldoBase * 0.07;
        double seguroSocial = sueldoBase * 0.05;

        double sueldoNeto = sueldoBase - renta - afp - seguroSocial;

        Console.WriteLine($"Sueldo Base: {sueldoBase:C}");
        Console.WriteLine($"Descuento Renta: {renta:C}");
        Console.WriteLine($"Descuento AFP: {afp:C}");
        Console.WriteLine($"Descuento Seguro Social: {seguroSocial:C}");
        Console.WriteLine($"Sueldo Neto a Pagar: {sueldoNeto:C}");
    }
}