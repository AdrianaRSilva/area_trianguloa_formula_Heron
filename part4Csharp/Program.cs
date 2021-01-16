using System;
using System.Globalization;
namespace part4Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // programa para ler as medidas dos lados de dois triângulos X e Y usando fórmula de Heron
            CultureInfo CI = CultureInfo.InvariantCulture;
            Console.WriteLine("Entre com as medidas do triângulo X: ");
            double xA = double.Parse(Console.ReadLine(), CI);
            double xB = double.Parse(Console.ReadLine(), CI);
            double xC = double.Parse(Console.ReadLine(), CI );

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            double yA = double.Parse(Console.ReadLine(),CI);
            double yB = double.Parse(Console.ReadLine(), CI);
            double yC = double.Parse(Console.ReadLine(), CI);

            double p = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(p*(p - xA)*(p - xB)*(p - xC));

            p = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Área de X = "+ areaX.ToString("F3", CI));
            Console.WriteLine("Área de Y = "+ areaY.ToString("F3", CI));
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
                Console.WriteLine("Maior área: Y ");
                
        }

    }
}
