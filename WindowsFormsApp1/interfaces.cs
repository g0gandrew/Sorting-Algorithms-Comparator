using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class IMode
    {
        public Boolean ascending = false;
        public Boolean descending = false;
    }

    internal class ISortAlgorithmResult
    {
        public int complexity = 0;
        public int stepsMade = 0;
        public int[] sortedArray;
        public IMode sortMode = new IMode();
    }
}
