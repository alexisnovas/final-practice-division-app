using System;
using practicaFinalTendencias;

namespace DivisionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO AL PROGRAMA PARA REALIZAR DIVISIONES\n");

            try
            {
                Console.WriteLine("Por favor digite el número 1:");
                double numero1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Por favor digite el número 2:");
                double numero2 = double.Parse(Console.ReadLine());

                double resultado = practicaFinal.DivisionCalculation(numero1, numero2);
                Console.WriteLine($"\nEl resultado de la división es: {resultado}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Console.WriteLine($" {ex}");
            }


        }
    }
}
