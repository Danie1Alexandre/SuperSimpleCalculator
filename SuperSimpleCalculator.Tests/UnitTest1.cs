//Made by Daniel Alexandre 2021
using System;
using Xunit;
using SuperSimpleCalculator;

namespace SuperSimpleCalculator.Tests
{
    public class SuperSimpleCalculatorTests
    {
        [Fact]
        public void DiviedZeroTests()
        {
            double arg1 = 100;
            double arg2 = 0;
            double result = Program.Divide(arg1, arg2);
            Assert.True(double.IsInfinity(result));
        }

        [Theory] //add array with theory
        [InlineData(1, 2, 4, 5, 12)]
        [InlineData(7, 2, 4, 5, 18)]

        public void AddTestsArray(double a, double b, double c, double d, double expected)
        {
            double result;
            double[] nummberList = new double[] { a, b, c, d };

            result = Program.Add(nummberList);
          
            Assert.Equal(expected, result);

        }


        [Fact]
        public void AddTests()
        {
            double numberA = 110, numberB = 35;
            double result, expected;

            result = Program.Add(numberA, numberB);//add two nummbers
            expected = 145;
            Assert.Equal(expected, result);

        }

        [Fact]
        public void SubTests()
        {
            double numberA = 100, numberB = 10;
            double result, expected;

            expected = 90;
            result = Program.Sub(numberA, numberB);

            Assert.Equal(expected, result);

        }

        [Theory] //sub array with theory
        [InlineData(1, 2, 4, 5, -12)]
        [InlineData(70, 2, 4, 5, -81)]

        public void SubTestsArray(double a, double b, double c, double d, double expected)
        {
            double result = 0;
            double[] nummberList = new double[] { a, b, c, d };

            for (int i = 0; i < 4; i++) //add arry of nummbers
            {
                result = Program.Sub(nummberList);
            }
            Assert.Equal(expected, result);

        }


        [Fact]
        public void MultiplyTests()
        {
            double arg1 = 100;
            double arg2 = 10;
            double expexted = 1000;

            double result = Program.Multiply(arg1, arg2);
            Assert.Equal(expexted, result);
        }

    }
}

