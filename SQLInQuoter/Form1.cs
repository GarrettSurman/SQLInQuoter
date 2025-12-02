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

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            String[] words =  input.Split(new[] { ' ', '\r', '\n', '\t', ',', ';', '|' },StringSplitOptions.RemoveEmptyEntries);
            string output = "";
            
            
               

            for (int i = 0; i < words.Length; i++)
            {
                output += "'" + words[i] + "'";
                if (i < words.Length - 1)
                {
                    if(checkBoxOneLineOutput.Checked){

                        output += ", ";
                    }
                    else
                    {
                        output += ",\r\n";
                    }

             
                }
                else
                {
                    output += "\n";
                }
            }

            if (checkBoxAddSQLIn.Checked)
            {
                output = "IN (" + output.TrimEnd() + ");";
            }

            textBoxOutput.Text = output;
        }
    }
}
