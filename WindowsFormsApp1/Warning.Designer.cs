namespace WindowsFormsApp1
{
    partial class Warning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warning));
            this.close = new System.Windows.Forms.Button();
            this.warningMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(138, 208);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(108, 54);
            this.close.TabIndex = 1;
            this.close.Text = "Understood";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // warningMessage
            // 
            this.warningMessage.Location = new System.Drawing.Point(74, 55);
            this.warningMessage.Name = "warningMessage";
            this.warningMessage.ReadOnly = true;
            this.warningMessage.Size = new System.Drawing.Size(221, 124);
            this.warningMessage.TabIndex = 2;
            this.warningMessage.Text = "";
            // 
            // Warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 294);
            this.Controls.Add(this.warningMessage);
            this.Controls.Add(this.close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Warning";
            this.Text = "Warning";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.RichTextBox warningMessage;
    }
}