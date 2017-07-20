using System.Linq;

namespace JaggedArraySorter.Tests
{
    /// <summary>
    /// Class that provides us with method of compare ascending the min element
    /// </summary>
    class MinElemIncreaseComparer : IComparer
    {
        /// <summary>
        /// Method that allows us to compare ascending the the max element
        /// </summary>
        /// <param name="lhs">Left array</param>
        /// <param name="rhs">Right</param>
        /// <returns>Integer that less than 0 if min element of right array if less than min element of left array, 
        /// more than 0 if more, 0 if they equal</returns>
        public int Compare(int[] lhs, int[] rhs) => rhs.Min() - lhs.Min();
    }
}
