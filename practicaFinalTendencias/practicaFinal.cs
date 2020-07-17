using System;

namespace practicaFinalTendencias
{
    public class practicaFinal
    {
        public static double DivisionCalculation(double number1, double number2)
        {
            double resultado = number1/number2;

            if (number2 == 0)
            {
                throw new System.DivideByZeroException("Se está tratando de dividir un número entre cero.");
            }
            else if (number1 == double.MaxValue || number2 == double.MaxValue)
            {
                throw new System.Exception("El número ingresado excede el límite del tipo de dato double.");
            }
            
            return resultado;
        }
    }
}
