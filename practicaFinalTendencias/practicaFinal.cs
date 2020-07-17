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
                throw new System.DivideByZeroException();
            }
            else if (number1 == double.MaxValue || number2 == double.MaxValue)
            {
                throw new System.Exception();
            }
            
            return resultado;
        }
    }
}
