using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySorter
{
    public interface IComparer
    {
        int Compare(int[] lhs, int[] rhs);
    }
}
