using System;

namespace JaggedArraySorter
{
    public class Sorter
    {
        /// <summary>
        /// Method for bubble sort of jagged array of integers
        /// </summary>
        /// <param name="arr">Jagged array of integers</param>
        /// <param name="comparer">Type of compare</param>
        public static void BubbleSort(int[][] arr, IComparer comparer)
        {
            CheckArgument(arr);

            for (int i = 0; i < arr.Length; i++)
                for (int j = arr.Length - 1; j >= 1; j--)
                    if(comparer.Compare(arr[j - 1], arr[j]) < 0)
                        Swap(ref arr[j-1], ref arr[j]);
        }

        private static void CheckArgument(int[][] arr)
        {
            if(ReferenceEquals(arr, null))
                throw new ArgumentNullException();
            if(arr.Length == 0)
                throw new ArgumentOutOfRangeException();
            foreach (var inArr in arr)
            {
                if (ReferenceEquals(inArr, null))
                    throw new ArgumentNullException();
                if (inArr.Length == 0)
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static void Swap(ref int[] lhs, ref int[] rhs)
        {
            int[] temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}
