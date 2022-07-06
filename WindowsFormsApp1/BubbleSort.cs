using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    internal class BubbleSort
    {

        private int[] data;
        private ISortAlgorithmResult sortResult;

        public void setData(int[] data) {
            this.data = data;
        }

        public int[] getData() {
            return this.data;
        }

        public void sort(IMode mode) {
            sortResult = new ISortAlgorithmResult();
            int noComparisions = 0;
            if (mode.ascending)
            {
                this.sortResult.sortMode.ascending = true;
                for (int i = 0; i < this.data.Length; ++i)
                    for (int j = i + 1; j < this.data.Length; ++j)
                    {
                        int holder;
                        if (this.data[i] > this.data[j])
                        {
                            holder = this.data[i];
                            this.data[i] = this.data[j];
                            this.data[j] = holder;
                            ++noComparisions;
                        }
                    }
            }
            else
            {
                this.sortResult.sortMode.descending = true;
                for (int i = 0; i < this.data.Length; ++i)
                    for (int j = i + 1; j < this.data.Length; ++j)
                    {
                        int holder;
                        if (this.data[i] < this.data[j])
                        {
                            holder = this.data[i];
                            this.data[i] = this.data[j];
                            this.data[j] = holder;
                            ++noComparisions;
                        }
                    }
            }

            // Remained Sort Result Construction
            this.sortResult.stepsMade = noComparisions;
            this.sortResult.complexity = 2;
            this.sortResult.sortedArray = this.data;
            //
        }

        public ISortAlgorithmResult getSortResult() {
            return this.sortResult;
        }

    }
}
