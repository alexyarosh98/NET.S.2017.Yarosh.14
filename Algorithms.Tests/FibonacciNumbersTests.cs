using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Algorithms.Tests
{
    [TestFixture]
    public class FibonacciNumbersTests
    {
        [TestCase(1,new []{1})]
        [TestCase(2,new []{1,1})]
        [TestCase(5,new[]{1,1,2,3,5})]
        [TestCase(15,new[]{ 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610 })]
        public void FiboGenerate_NumberOfElementsToBeGenerated_IEnumerableObjectOfFibonacciNumbers
            (int numberOfElements,IEnumerable<int> expectedCollection)
        {
            List<int> result = new List<int>(FibonacciNumbers.FiboGenerate(numberOfElements));
            int index = 0;

            Assert.AreEqual(result.Count(),expectedCollection.Count());
            foreach (int i in expectedCollection)
            {
                Assert.AreEqual(result.ElementAt(index++),i);
            }
        }

        [TestCase(-5)]
        [TestCase(0)]
        [TestCase(int.MinValue)]
        public void FiboGenerated_NumberOfElementsLessThenZero_ArgumentOutOfRangeException(int numberOfElements)
        {
            var ex = Assert.Catch<ArgumentOutOfRangeException>(() =>
            {
                List<int> list=new List<int>(FibonacciNumbers.FiboGenerate(numberOfElements));
            }
            );

            StringAssert.Contains($"{nameof(numberOfElements)} must be a positive number", ex.Message);
        }
    }
}
