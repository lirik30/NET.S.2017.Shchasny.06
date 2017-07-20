using System.Linq;

namespace JaggedArraySorter.Tests
{
    /// <summary>
    /// Class that provides us with method of compare descending the sum of elements
    /// </summary>
    class SumDecreaseComparer : IComparer
    {
        /// <summary>
        /// Method that allows us to compare descending the sum of elements
        /// </summary>
        /// <param name="lhs">Left array</param>
        /// <param name="rhs">Right array</param>
        /// <returns>Integer that less than 0 if sum of left array elements if less than sum of right array elements, 
        /// more than 0 if more, 0 if they equal</returns>
        public int Compare(int[] lhs, int[] rhs) => lhs.Sum() - rhs.Sum();
    }
}
