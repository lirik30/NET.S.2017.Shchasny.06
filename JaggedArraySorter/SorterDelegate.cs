using System;

namespace JaggedArraySorter
{
    public class SorterDelegate
    {
        /// <summary>
        /// Method for bubble sort of jagged array of integers by comparer
        /// </summary>
        /// <param name="arr">Jagged array of integers</param>
        /// <param name="comparer">Type of compare</param>
        public static void BubbleSort(int[][] arr, IComparer comparer) => BubbleSort(arr, comparer.Compare);


        /// <summary>
        /// Method for bubble sort of jagged array of integers by delegate
        /// </summary>
        /// <param name="arr">Jagged array to sort</param>
        /// <param name="comparison">Method of comparison</param>
        public static void BubbleSort(int[][] arr, Comparison<int[]> comparison)
        {
            CheckArgument(arr);

            for (int i = 0; i < arr.Length; i++)
            for (int j = arr.Length - 1; j >= 1; j--)
                if (comparison(arr[j - 1], arr[j]) < 0)
                    Swap(ref arr[j - 1], ref arr[j]);
        }


        /// <summary>
        /// Method check the argument of BubbleSort method for null or zero-length
        /// </summary>
        /// <param name="arr">Jagged array - argument of BubbleSort method</param>
        private static void CheckArgument(int[][] arr)
        {
            if (ReferenceEquals(arr, null))
                throw new ArgumentNullException();
            if (arr.Length == 0)
                throw new ArgumentOutOfRangeException();
            foreach (var inArr in arr)
            {
                if (ReferenceEquals(inArr, null))
                    throw new ArgumentNullException();
                if (inArr.Length == 0)
                    throw new ArgumentOutOfRangeException();
            }
        }


        /// <summary>
        /// Method swap 2 array in the jagged array
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        private static void Swap(ref int[] lhs, ref int[] rhs)
        {
            int[] temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}
