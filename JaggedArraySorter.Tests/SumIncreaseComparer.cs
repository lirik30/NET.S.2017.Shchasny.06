using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySorter.Tests
{
    /// <summary>
    /// Class that provides us with method of compare ascending the sum of elements
    /// </summary>
    class SumIncreaseComparer : IComparer
    {
        /// <summary>
        /// Method that allows us to compare ascending the sum of elements
        /// </summary>
        /// <param name="lhs">Left array</param>
        /// <param name="rhs">Right array</param>
        /// <returns> Integer that less than 0 if sum of right array elements if less than sum of left array elements, 
        /// more than 0 if more, 0 if they equal</returns>
        public int Compare(int[] lhs, int[] rhs) => rhs.Sum() - lhs.Sum();
    }
}
