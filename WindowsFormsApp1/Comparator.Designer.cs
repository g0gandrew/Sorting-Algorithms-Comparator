namespace WindowsFormsApp1
{
    partial class comparator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(comparator));
            this.insertionSortChosed = new System.Windows.Forms.CheckBox();
            this.bubbleSortChosed = new System.Windows.Forms.CheckBox();
            this.compare = new System.Windows.Forms.Button();
            this.addElement = new System.Windows.Forms.Button();
            this.inputtedElement = new System.Windows.Forms.TextBox();
            this.dataList = new System.Windows.Forms.ListBox();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sortMode = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // insertionSortChosed
            // 
            this.insertionSortChosed.AutoSize = true;
            this.insertionSortChosed.Location = new System.Drawing.Point(6, 28);
            this.insertionSortChosed.Name = "insertionSortChosed";
            this.insertionSortChosed.Size = new System.Drawing.Size(88, 17);
            this.insertionSortChosed.TabIndex = 2;
            this.insertionSortChosed.Text = "Insertion Sort";
            this.insertionSortChosed.UseVisualStyleBackColor = true;
            // 
            // bubbleSortChosed
            // 
            this.bubbleSortChosed.AutoSize = true;
            this.bubbleSortChosed.Location = new System.Drawing.Point(110, 28);
            this.bubbleSortChosed.Name = "bubbleSortChosed";
            this.bubbleSortChosed.Size = new System.Drawing.Size(81, 17);
            this.bubbleSortChosed.TabIndex = 3;
            this.bubbleSortChosed.Text = "Bubble Sort";
            this.bubbleSortChosed.UseVisualStyleBackColor = true;
            // 
            // compare
            // 
            this.compare.Location = new System.Drawing.Point(438, 390);
            this.compare.Name = "compare";
            this.compare.Size = new System.Drawing.Size(167, 58);
            this.compare.TabIndex = 4;
            this.compare.Text = "Compare";
            this.compare.UseVisualStyleBackColor = true;
            this.compare.Click += new System.EventHandler(this.button1_Click);
            // 
            // addElement
            // 
            this.addElement.Location = new System.Drawing.Point(79, 373);
            this.addElement.Name = "addElement";
            this.addElement.Size = new System.Drawing.Size(75, 23);
            this.addElement.TabIndex = 7;
            this.addElement.Text = "Add";
            this.addElement.UseVisualStyleBackColor = true;
            this.addElement.Click += new System.EventHandler(this.addElement_Click);
            // 
            // inputtedElement
            // 
            this.inputtedElement.Location = new System.Drawing.Point(171, 376);
            this.inputtedElement.Name = "inputtedElement";
            this.inputtedElement.Size = new System.Drawing.Size(88, 20);
            this.inputtedElement.TabIndex = 8;
            // 
            // dataList
            // 
            this.dataList.FormattingEnabled = true;
            this.dataList.Location = new System.Drawing.Point(17, 19);
            this.dataList.Name = "dataList";
            this.dataList.Size = new System.Drawing.Size(261, 134);
            this.dataList.TabIndex = 10;
            // 
            // graph
            // 
            chartArea3.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.graph.Legends.Add(legend3);
            this.graph.Location = new System.Drawing.Point(480, 100);
            this.graph.Name = "graph";
            this.graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.graph.Series.Add(series3);
            this.graph.Size = new System.Drawing.Size(462, 258);
            this.graph.TabIndex = 11;
            this.graph.Text = "chart1";
            // 
            // sortMode
            // 
            this.sortMode.BackColor = System.Drawing.Color.Silver;
            this.sortMode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sortMode.FormattingEnabled = true;
            this.sortMode.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.sortMode.Location = new System.Drawing.Point(12, 28);
            this.sortMode.Name = "sortMode";
            this.sortMode.Size = new System.Drawing.Size(94, 30);
            this.sortMode.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(728, 414);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bubbleSortChosed);
            this.groupBox1.Controls.Add(this.insertionSortChosed);
            this.groupBox1.Location = new System.Drawing.Point(79, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 82);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithms";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataList);
            this.groupBox2.Location = new System.Drawing.Point(79, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 168);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sortMode);
            this.groupBox3.Location = new System.Drawing.Point(292, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(112, 82);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sorting Mode";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(354, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 35);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Cascadia Code", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.title.Location = new System.Drawing.Point(138, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(750, 57);
            this.title.TabIndex = 0;
            this.title.Text = "Sorting Algorithms Comparator";
            // 
            // comparator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1008, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.inputtedElement);
            this.Controls.Add(this.addElement);
            this.Controls.Add(this.compare);
            this.Controls.Add(this.title);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "comparator";
            this.Text = "Sorting Algorithms Comparator";
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox insertionSortChosed;
        private System.Windows.Forms.CheckBox bubbleSortChosed;
        private System.Windows.Forms.Button compare;
        private System.Windows.Forms.Button addElement;
        private System.Windows.Forms.TextBox inputtedElement;
        private System.Windows.Forms.ListBox dataList;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.CheckedListBox sortMode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label title;
    }
}

