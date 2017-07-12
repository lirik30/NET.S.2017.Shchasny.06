using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySorter.Tests
{
    class MaxElemDecrease : IComparer
    {
        public int Compare(int[] lhs, int[] rhs)
        {
            return lhs.Max() - rhs.Max();
        }
    }
}
