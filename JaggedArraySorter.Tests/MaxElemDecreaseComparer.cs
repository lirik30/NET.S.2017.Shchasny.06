using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySorter.Tests
{
    /// <summary>
    /// Class that provides us with method of compare descending the max element
    /// </summary>
    class MaxElemDecreaseComparer : IComparer
    {
        /// <summary>
        /// Method that allows us to compare descending the the max element
        /// </summary>
        /// <param name="lhs">Left array</param>
        /// <param name="rhs">Right</param>
        /// <returns>Integer that less than 0 if max element of left array if less than max element of right array, 
        /// more than 0 if more, 0 if they equal</returns>
        public int Compare(int[] lhs, int[] rhs) => lhs.Max() - rhs.Max();
    }
}
