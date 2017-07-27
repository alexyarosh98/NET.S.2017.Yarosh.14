using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class FibonacciNumbers
    {
        /// <summary>
        /// Find specified amount of fibonacci numbers
        /// </summary>
        /// <param name="numberOfElements">Number of elements to be found</param>
        /// <returns>IEnumberable object of fibonacci numbers</returns>
        public static IEnumerable<int> FiboGenerate(int numberOfElements)
        {
            if(numberOfElements<=0) throw new ArgumentOutOfRangeException($"{nameof(numberOfElements)} must be a positive number");

            int firstNum = 1;
            int secondNum = 1;
            int sum;
            int currentIndex = 0;

            yield return firstNum;
            if (numberOfElements <= 1) yield break;
            yield return secondNum;

            while (currentIndex < numberOfElements - 2)
            {
                yield return sum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = sum;
                currentIndex++;
            }
        }
    }
}
