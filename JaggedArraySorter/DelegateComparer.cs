using System;

namespace JaggedArraySorter
{
    /// <summary>
    /// Class that provides us with way to "turn" delegate into interface
    /// </summary>
    class DelegateComparer : IComparer
    {
        /// <summary>
        /// Delegate to compare
        /// </summary>
        private Comparison<int[]> _comparison;

        public DelegateComparer(Comparison<int[]> comparison) => _comparison = comparison;

        public int Compare(int[] lhs, int[] rhs) => _comparison(lhs, rhs);
    }
}
