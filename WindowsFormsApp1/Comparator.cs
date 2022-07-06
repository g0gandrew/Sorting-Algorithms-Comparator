using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class comparator : Form
    {
        BubbleSort bubbleSort;
        InsertionSort insertionSort;
        IMode sortingMode;
        public comparator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
         {
            if(dataList.Items.Count == 0)
            {
                Warning warning = new Warning("You must enter data!");
                warning.ShowDialog();
                return;
            }

            if(!insertionSortChosed.Checked && !bubbleSortChosed.Checked)
            {
                Warning warning = new Warning("You must choose at least one algorithm!");
                warning.ShowDialog();
                return;
            }

            if(sortMode.GetItemChecked(0) && sortMode.GetItemChecked(1))
            {
                Warning warning = new Warning("Select only one sorting mode!");
                warning.ShowDialog();
                sortMode.ClearSelected();
                return;
            }

            if (!sortMode.GetItemChecked(0) && !sortMode.GetItemChecked(1))
            {
                Warning warning = new Warning("Select at least one sorting mode!");
                warning.ShowDialog();
                return;
            }

            // Setting sorting mode
            this.sortingMode = new IMode();
            if (sortMode.GetItemChecked(0))
                this.sortingMode.ascending = true;
            else
                this.sortingMode.descending = true;
            //


            if (bubbleSortChosed.Checked && insertionSortChosed.Checked)
            {
                this.configureBubbleSort();
                this.configureInsertionSort();
                this.graphResult();
            }

            else if(bubbleSortChosed.Checked)
            {
                this.configureBubbleSort();
                this.graphResult();
            }
            else if(insertionSortChosed.Checked)
            {
                this.configureInsertionSort();
                this.graphResult();
            }
        }

        private int[] extractElements()
        {
            int[] elements = new int[dataList.Items.Count];

            for(int i = 0; i < dataList.Items.Count; i++)
            {
                int parsedElement = int.Parse(dataList.Items[i].ToString());
                elements[i] = parsedElement;
            }

            return elements;
        }
        private void graphResult()
        {
            foreach (var series in graph.Series)
            {
                series.Points.Clear();
            }
            graph.Series.Clear();
            if (this.bubbleSortChosed.Checked)
            {
                graph.Series.Add("Bubble Sort");
                graph.Series["Bubble Sort"].Points.AddXY("Bubble Sort", bubbleSort.getSortResult().stepsMade);
            }
            if(this.insertionSortChosed.Checked)
            {
                graph.Series.Add("Insertion Sort");
                graph.Series["Insertion Sort"].Points.AddXY("Insertion Sort", insertionSort.getSortResult().stepsMade);
            }
        }
        private void addElement_Click(object sender, EventArgs e)
        {
            int inputtedParsedElement;
            if(int.TryParse(inputtedElement.Text, out inputtedParsedElement)) {
                dataList.Items.Add(inputtedParsedElement.ToString());
            }
        }

        private void configureBubbleSort()
        {
            this.bubbleSort = new BubbleSort();
            this.bubbleSort.setData(extractElements());
            this.bubbleSort.sort(this.sortingMode);
        }
        private void configureInsertionSort()
        {
            this.insertionSort = new InsertionSort();
            this.insertionSort.setData(extractElements());
            this.insertionSort.sort(this.sortingMode);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.dataList.Items.Clear();
        }
    }
}
