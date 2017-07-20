using System.Linq;

namespace JaggedArraySorter.Tests
{
    /// <summary>
    /// Class that provides us with method of compare ascending the max element
    /// </summary>
    class MaxElemIncreaseComparer : IComparer
    {
        /// <summary>
        /// Method that allows us to compare ascending the the max element
        /// </summary>
        /// <param name="lhs">Left array</param>
        /// <param name="rhs">Right</param>
        /// <returns>Integer that less than 0 if max element of right array if less than max element of left array, 
        /// more than 0 if more, 0 if they equal</returns>
        public int Compare(int[] lhs, int[] rhs) => rhs.Max() - lhs.Max();
    }
}
