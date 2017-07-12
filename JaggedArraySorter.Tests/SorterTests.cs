using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JaggedArraySorter.Sorter;
using NUnit.Framework;

namespace JaggedArraySorter.Tests
{
    [TestFixture]
    public class SorterTests
    {
        private static IEnumerable<TestCaseData> BubbleSort_PositiveData
        {
            get
            {
                yield return new TestCaseData(new []{new []{1, 2, 5}, new [] { 1, 4, -1}, new [] { 10, 4, 11}}, new SumIncrease())
                    .Returns(new[] { new[] { 1, 4, -1 }, new[] { 1, 2, 5 } , new[] { 10, 4, 11 } });

                yield return new TestCaseData(new[] { new[] { 1, 2, 5 }, new[] { 1, 4, -1 }, new[] { 10, 4, 11 } }, new SumDecrease())
                    .Returns(new[] { new[] { 10, 4, 11 }, new[] { 1, 2, 5 }, new[] { 1, 4, -1 } });

                yield return new TestCaseData(new[] { new[] { 1, 4, -1 },  new[] { 1, 2, 5 }, new[] { 10, 4, 11 } }, new MaxElemIncrease())
                    .Returns(new[] { new[] { 1, 4, -1 }, new[] { 1, 2, 5 }, new[] { 10, 4, 11 } });

                yield return new TestCaseData(new[] { new[] { 10, 4, 11 }, new[] { 1, 2, 5 }, new[] { 1, 4, -1 } }, new MaxElemDecrease())
                    .Returns(new[] { new[] { 10, 4, 11 }, new[] { 1, 2, 5 }, new[] { 1, 4, -1 } });

                yield return new TestCaseData(new[] { new[] { 1, 4, -1 }, new[] { 1, 2, 5 }, new[] { 10, 4, 11 } }, new MinElemIncrease())
                    .Returns(new[] { new[] { 1, 4, -1 }, new[] { 1, 2, 5 }, new[] { 10, 4, 11 } });

                yield return new TestCaseData(new[] { new[] { 10, 4, 11 }, new[] { 1, 2, 5 }, new[] { 1, 4, -1 } }, new MinElemDecrease())
                    .Returns(new[] { new[] { 10, 4, 11 }, new[] { 1, 2, 5 }, new[] { 1, 4, -1 } });

            }
        }

        private static IEnumerable<TestCaseData> BubbleSort_ThrowsArgumentNullExceptionData
        {
            get
            {
                yield return new TestCaseData(null, new SumIncrease());

                yield return new TestCaseData(null, new SumDecrease());

                yield return new TestCaseData(new[] {null, new[] {1, 2, 5}, null}, new MaxElemIncrease());

                yield return new TestCaseData(new[] {new[] {10, 4, 11}, null, new[] {1, 4, -1}}, new MaxElemDecrease());

                yield return new TestCaseData(new[] {new[] {1, 4, -1}, new[] {1, 2, 5}, null}, new MinElemIncrease());

                yield return new TestCaseData(null, new MinElemDecrease());

            }
        }

        private static IEnumerable<TestCaseData> BubbleSort_ThrowsArgumentOutOfRangeExceptionData
        {
            get
            {
                yield return new TestCaseData(new int[0][], new SumIncrease());

                yield return new TestCaseData(new int[0][], new SumDecrease());

                yield return new TestCaseData(new[] {new int[0], new[] {1, 2, 5}, new int[0]}, new MaxElemIncrease());

                yield return new TestCaseData(new[] {new[] {10, 4, 11}, new int[0], new[] {1, 4, -1}}, new MaxElemDecrease());

                yield return new TestCaseData(new[] {new[] {1, 4, -1}, new[] {1, 2, 5}, new int[0]}, new MinElemIncrease());

                yield return new TestCaseData(new int[0][], new MinElemDecrease());

            }
        }


        [Test, TestCaseSource(nameof(BubbleSort_PositiveData))]
        public int[][] BubbleSort_PositiveTest(int[][] arr, IComparer comparer)
        {
            BubbleSort(arr, comparer);
            return arr;
        }


        [Test, TestCaseSource(nameof(BubbleSort_ThrowsArgumentNullExceptionData))]
        public void BubbleSort_ThrowsArgumentNullException(int[][] arr, IComparer comparer)
        {
            Assert.Throws<ArgumentNullException>(() => BubbleSort(arr, comparer));
        }

        [Test, TestCaseSource(nameof(BubbleSort_ThrowsArgumentOutOfRangeExceptionData))]
        public void BubbleSort_ThrowsArgumentOutOfRangeException(int[][] arr, IComparer comparer)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => BubbleSort(arr, comparer));
        }

    }
}
