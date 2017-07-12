using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySorter.Tests
{
    class SumIncrease : IComparer
    {
        public int Compare(int[] lhs, int[] rhs)
        {
            return rhs.Min() - lhs.Min();
        }
    }
}
