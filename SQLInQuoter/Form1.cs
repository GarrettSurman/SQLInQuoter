using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLInQuoter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClearInput_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();   
        }

        private void buttonClearOutput_Click(object sender, EventArgs e)
        {
            textBoxOutput.Clear();  
        }

        private void buttonCopyOutput_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxOutput.Text);
        }
    }
}
