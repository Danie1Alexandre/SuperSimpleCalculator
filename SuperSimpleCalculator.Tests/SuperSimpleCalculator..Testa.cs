using System;
using Xunit;
using SuperSimpleCalculator;

namespace SuperSimpleCalculator.Tests
{
    public class SuperSimpleCalculatorTests
    {
        [Fact]
        public void diviedZeroTests()
        {
            double arg1 = 100;
            double arg2 = 0;
            double result = Program.Divide(arg1, arg2);
            Assert.True(double.IsInfinity(result)); 
        }
    
        [Fact]
        public void AddAndSubTests()
        {
            double[]  arg1 = new double[] {100, };
            double[] arg2 = new double[] { 10, };
            double result,expexted ;

            expexted = 110;
            result = Program.add(arg1[0], arg2[0]);
            Assert.Equal(expexted, result);

            expexted = 90; 
            result = Program.sub(arg1[0], arg2[0]);
            Assert.Equal(expexted, result);
        }
        [Fact]
        public void MultiplyTests()
        {
            double arg1 = 100;
            double arg2 = 10;
            double expexted = 1000;

            double result = Program.multiply(arg1, arg2);
            Assert.Equal(expexted, result); 
        }

    }
}
