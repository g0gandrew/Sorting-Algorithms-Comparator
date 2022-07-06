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
    public partial class Warning : Form
    {
        public Warning(string message)
        {
            InitializeComponent();
            warningMessage.Text = message;
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
