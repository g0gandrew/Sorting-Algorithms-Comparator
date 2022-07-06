using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class InsertionSort
    {
        private int[] data;
        private ISortAlgorithmResult sortResult;

        public void setData(int[] data)
        {
            this.data = data;
        }

        public int[] getData()
        {
            return this.data;
        }

        public void sort(IMode mode)
        {
            sortResult = new ISortAlgorithmResult();
            int noComparisions = 0;
            int key, j;
            if (mode.ascending)
            {
                this.sortResult.sortMode.ascending = true;
                for (int i = 0; i < this.data.Length; ++i)
                {
                    key = this.data[i];
                    j = i - 1;
                    while (j >= 0 && this.data[j] > key)
                    {
                        ++noComparisions;
                        this.data[j + 1] = this.data[j];
                        j = j - 1;
                    }
                    this.data[j + 1] = key;
                }

            }
            else
            {
                this.sortResult.sortMode.descending = true;
                for (int i = 0; i < this.data.Length; ++i)
                {
                    key = this.data[i];
                    j = i - 1;
                    while (j >= 0 && this.data[j] < key)
                    {
                        ++noComparisions;
                        this.data[j + 1] = this.data[j];
                        j = j - 1;
                    }
                    this.data[j + 1] = key;
                }
            }
            // Remained Sort Result Construction
            this.sortResult.stepsMade = noComparisions;
            this.sortResult.complexity = 2;
            this.sortResult.sortedArray = this.data;
            //
        }

        public ISortAlgorithmResult getSortResult()
        {
            return this.sortResult;
        }

    }
}
