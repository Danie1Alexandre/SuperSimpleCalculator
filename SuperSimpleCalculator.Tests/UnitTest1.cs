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
            double[] nummberList = new double[] { 100, 10, 20, 5 };
            double result, expected;

            result = Program.Add(nummberList[0], nummberList[1]);//add two nummbers
            expected = 110;
            Assert.Equal(expected, result);

        }

        [Fact]
        public void SubTests()
        {
            double[] nummberList = new double[] { 100, 10, 20, 5 };
            double result, expected;

            expected = 90;
            result = Program.Sub(nummberList[0], nummberList[1]);

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

/*[Theory] //add with theory altenativ way maybe not so good
[InlineData(1, 2, 4, 5)]
public void AddTests2(double a, double b, double c, double d, )
{
    double expected, result;
    double[] nummberList = new double[] { a, b, c, d };
    result = 0;
    for (int i = 0; i < 4; i++) //add arry of nummbers
    {
        result = Program.Add(nummberList[i], result);
    }
    expected = 12;
    Assert.Equal(expected, result);
    result = Program.Add(nummberList[0], nummberList[1]);//add two nummbers
    expected = 3;
    Assert.Equal(expected, result);*/