using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    /// <summary>
    /// A simple calculator class that performs basic arithmetic operations and keeps a history of the calculations.
    /// </summary>
    public class Calculator
    {
        private List<string> historyList;

        /// <summary>
        /// Initializes a new instance of the <see cref="Calculator"/> class.
        /// </summary>
        public Calculator()
        {
            historyList = new List<string>();
        }

        /// <summary>
        /// Adds two integers.
        /// </summary>
        /// <param name="num1">The first number.</param>
        /// <param name="num2">The second number.</param>
        /// <returns>The sum of the two numbers.</returns>
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            historyList.Insert(0, "Result:" + result);

            return result;
        }

        /// <summary>
        /// Subtracts one integer from another.
        /// </summary>
        /// <param name="num1">The number to subtract from.</param>
        /// <param name="num2">The number to subtract.</param>
        /// <returns>The result of the subtraction.</returns>
        public int Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            historyList.Insert(0, "Result:" + result);

            return result;
        }

        /// <summary>
        /// Multiplies two integers.
        /// </summary>
        /// <param name="num1">The first number.</param>
        /// <param name="num2">The second number.</param>
        /// <returns>The product of the two numbers.</returns>
        public int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            historyList.Insert(0, "Result:" + result);
            
            return result;
        }

        /// <summary>
        /// Divides one integer by another.
        /// </summary>
        /// <param name="num1">The dividend.</param>
        /// <param name="num2">The divisor.</param>
        /// <returns>The quotient of the division.</returns>
        /// <exception cref="DivideByZeroException">Thrown when attempting to divide by zero.</exception>
        public int Divide(int num1, int num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            int result = num1 / num2;
            historyList.Insert(0, "Result:" + result);

            return result;
        }

        /// <summary>
        /// Retrieves the calculation history.
        /// </summary>
        /// <returns>A list of strings representing the history of calculations.</returns>
        public List<string> History()
        {
            // Limits the history list to 3 entries
            if (historyList.Count > 3)
                historyList.RemoveRange(3, historyList.Count - 3);
            
            return historyList;
        }
    }
}
