using System;
using Xunit;
using practicaFinalTendencias;

namespace practicaFinalTests
{
    public class Tests
    {
        //POSITIVE CASES
        [Fact]
        public void DivisionCalculation_OneDividedByOne_ReturnTrue()
        {
            var resultado = practicaFinal.DivisionCalculation(1,1);
            double esperado = 1;
            Assert.Equal(resultado,esperado);
        }

        [Fact]
        public void DivisionCalculation_TwelveDividedByFour_ReturnThree()
        {
            var resultado = practicaFinal.DivisionCalculation(12, 4);
            double esperado = 3;
            Assert.Equal(resultado,esperado);
        }


        [Fact]
        public void DivisionCalculation_CeroDividedByInteger_ReturnCero()
        {
            var resultado = practicaFinal.DivisionCalculation(0,8);
            double esperado = 0;
            Assert.Equal(resultado, esperado);
        }

        [Fact]
        public void DivisionCalculation_ThreeDividedByFour_ReturnCeroPointSeventyFive()
        {
            var resultado = practicaFinal.DivisionCalculation(3,4);
            double esperado = 0.75;
            Assert.Equal(resultado, esperado);
        }

        //NEGATIVE CASES

        [Fact]
        public void DivisionCalculation_IntegerDividedByCero_ReturnException()
        {
            Assert.Throws<System.DivideByZeroException>(() => practicaFinal.DivisionCalculation(8, 0));
            
        }

        [Fact]
        public void DivisionCalculation_DecimalNumberDividedByCero_ReturnException()
        {
            Assert.Throws<System.DivideByZeroException>(() => practicaFinal.DivisionCalculation(5.4, 0));

        }

        [Fact]
        public void DivisionCalculation_ParameterNumber1IsEqualToDoubleTypeLimit_ReturnException()
        {
            var DoubleLimit = double.MaxValue;
            Assert.Throws<System.Exception>(() => practicaFinal.DivisionCalculation(DoubleLimit,8));

        }

        [Fact]
        public void DivisionCalculation_ParameterNumber2IsEqualToDoubleLimit_ReturnException()
        {
            var DoubleLimit = double.MaxValue;
            Assert.Throws<System.Exception>(() => practicaFinal.DivisionCalculation(8, DoubleLimit));

        }





    }
}
