using Services;
using Xunit;

namespace CalculatorTests
{
    /// <summary>
    /// Test class for the Calculator class.
    /// </summary>
    public class CalculatorTests
    {
        /// <summary>
        /// Tests the Add method of the Calculator class.
        /// </summary>
        /// <param name="num1">The first number.</param>
        /// <param name="num2">The second number.</param>
        /// <param name="expectedResult">The expected result of the addition.</param>
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestAdd(int num1, int num2, int expectedResult)
        {
            Calculator calc = new Calculator();

            int actualResult = calc.Add(num1, num2);

            Assert.Equal(expectedResult, actualResult);
        }

        /// <summary>
        /// Tests the Subtract method of the Calculator class.
        /// </summary>
        /// <param name="num1">The number to subtract from.</param>
        /// <param name="num2">The number to subtract.</param>
        /// <param name="expectedResult">The expected result of the subtraction.</param>
        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TestSubtract(int num1, int num2, int expectedResult)
        {
            Calculator calc = new Calculator();

            int actualResult = calc.Subtract(num1, num2);

            Assert.Equal(expectedResult, actualResult);
        }

        /// <summary>
        /// Tests the Multiply method of the Calculator class.
        /// </summary>
        /// <param name="num1">The first number.</param>
        /// <param name="num2">The second number.</param>
        /// <param name="expectedResult">The expected result of the multiplication.</param>
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiply(int num1, int num2, int expectedResult)
        {
            Calculator calc = new Calculator();

            int actualResult = calc.Multiply(num1, num2);

            Assert.Equal(expectedResult, actualResult);
        }

        /// <summary>
        /// Tests the Divide method of the Calculator class.
        /// </summary>
        /// <param name="num1">The dividend.</param>
        /// <param name="num2">The divisor.</param>
        /// <param name="expectedResult">The expected result of the division.</param>
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TestDivide(int num1, int num2, int expectedResult)
        {
            Calculator calc = new Calculator();

            int actualResult = calc.Divide(num1, num2);

            Assert.Equal(expectedResult, actualResult);
        }

        /// <summary>
        /// Tests division by zero.
        /// </summary>
        [Fact]
        public void TestDivideByZero()
        {
            Calculator calc = new Calculator();

            Assert.Throws<DivideByZeroException>(
                () => calc.Divide(3, 0)
            );
        }

        /// <summary>
        /// Tests the history functionality of the Calculator class.
        /// </summary>
        [Fact]
        public void TestHistory()
        {
            Calculator calc = new Calculator();

            calc.Add(1, 2);
            calc.Add(2, 8);
            calc.Add(3, 7);
            calc.Add(4, 1);

            var historyList = calc.History();
            Assert.NotEmpty(historyList);
            Assert.Equal(3, historyList.Count);
        }
    }
}




