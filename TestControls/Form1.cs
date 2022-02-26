using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(integerTextBox1.Value);
            Debug.WriteLine("");
        }

        private void IncrementButton_Click(object sender, EventArgs e)
        {
            textBoxUpDown1.Increment();
        }

        private void DecrementButton_Click(object sender, EventArgs e)
        {
            textBoxUpDown1.Decrement();
        }

        private void ValueButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBoxUpDown1.Value.ToString());
        }
    }
}
