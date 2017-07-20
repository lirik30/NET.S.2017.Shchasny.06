using System;
using System.Collections.Generic;
using NUnit.Framework;
using static JaggedArraySorter.SorterDelegate;

namespace JaggedArraySorter.Tests
{
    [TestFixture]
    class SorterDelegateTests
    {
        private static IEnumerable<TestCaseData> BubbleSort_PositiveData
        {
            get
            {
                yield return new TestCaseData(new[] { new[] { 1, 2, 5 }, new[] { 1, 4, -1 }, new[] { 10, 4, 11 } }, new SumIncreaseComparer())
                    .Returns(new[] { new[] { 1, 4, -1 }, new[] { 1, 2, 5 }, new[] { 10, 4, 11 } });

                yield return new TestCaseData(new[] { new[] { 1, 2, 5 }, new[] { 1, 4, -1 }, new[] { 10, 4, 11 } }, new SumDecreaseComparer())
                    .Returns(new[] { new[] { 10, 4, 11 }, new[] { 1, 2, 5 }, new[] { 1, 4, -1 } });

                yield return new TestCaseData(new[] { new[] { 1, 4, -1 }, new[] { 1, 2, 5 }, new[] { 10, 4, 11 } }, new MaxElemIncreaseComparer())
                    .Returns(new[] { new[] { 1, 4, -1 }, new[] { 1, 2, 5 }, new[] { 10, 4, 11 } });

                yield return new TestCaseData(new[] { new[] { 10, 4, 11 }, new[] { 1, 2, 5 }, new[] { 1, 4, -1 } }, new MaxElemDecreaseComparer())
                    .Returns(new[] { new[] { 10, 4, 11 }, new[] { 1, 2, 5 }, new[] { 1, 4, -1 } });

                yield return new TestCaseData(new[] { new[] { 1, 4, -1 }, new[] { 1, 2, 5 }, new[] { 10, 4, 11 } }, new MinElemIncreaseComparer())
                    .Returns(new[] { new[] { 1, 4, -1 }, new[] { 1, 2, 5 }, new[] { 10, 4, 11 } });

                yield return new TestCaseData(new[] { new[] { 10, 4, 11 }, new[] { 1, 2, 5 }, new[] { 1, 4, -1 } }, new MinElemDecreaseCompararer())
                    .Returns(new[] { new[] { 10, 4, 11 }, new[] { 1, 2, 5 }, new[] { 1, 4, -1 } });
            }
        }

        private static IEnumerable<TestCaseData> BubbleSort_ThrowsArgumentNullExceptionData
        {
            get
            {
                yield return new TestCaseData(null, new SumIncreaseComparer());

                yield return new TestCaseData(null, new SumDecreaseComparer());

                yield return new TestCaseData(new[] { null, new[] { 1, 2, 5 }, null }, new MaxElemIncreaseComparer());

                yield return new TestCaseData(new[] { new[] { 10, 4, 11 }, null, new[] { 1, 4, -1 } }, new MaxElemDecreaseComparer());

                yield return new TestCaseData(new[] { new[] { 1, 4, -1 }, new[] { 1, 2, 5 }, null }, new MinElemIncreaseComparer());

                yield return new TestCaseData(null, new MinElemDecreaseCompararer());
            }
        }

        private static IEnumerable<TestCaseData> BubbleSort_ThrowsArgumentOutOfRangeExceptionData
        {
            get
            {
                yield return new TestCaseData(new int[0][], new SumIncreaseComparer());

                yield return new TestCaseData(new int[0][], new SumDecreaseComparer());

                yield return new TestCaseData(new[] { new int[0], new[] { 1, 2, 5 }, new int[0] }, new MaxElemIncreaseComparer());

                yield return new TestCaseData(new[] { new[] { 10, 4, 11 }, new int[0], new[] { 1, 4, -1 } }, new MaxElemDecreaseComparer());

                yield return new TestCaseData(new[] { new[] { 1, 4, -1 }, new[] { 1, 2, 5 }, new int[0] }, new MinElemIncreaseComparer());

                yield return new TestCaseData(new int[0][], new MinElemDecreaseCompararer());
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


        [Test, TestCaseSource(nameof(BubbleSort_PositiveData))]
        public int[][] BubbleSort_PositiveTestOfDelegate(int[][] arr, IComparer comparer)
        {
            BubbleSort(arr, comparer.Compare);
            return arr;
        }


        [Test, TestCaseSource(nameof(BubbleSort_ThrowsArgumentNullExceptionData))]
        public void BubbleSort_ThrowsArgumentNullExceptionOfDelegate(int[][] arr, IComparer comparer)
        {
            Assert.Throws<ArgumentNullException>(() => BubbleSort(arr, comparer.Compare));
        }

        [Test, TestCaseSource(nameof(BubbleSort_ThrowsArgumentOutOfRangeExceptionData))]
        public void BubbleSort_ThrowsArgumentOutOfRangeExceptionOfDelegate(int[][] arr, IComparer comparer)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => BubbleSort(arr, comparer.Compare));
        }
    }
}
