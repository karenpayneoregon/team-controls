using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamHelpers;

namespace TestFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBoxListButton_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = groupBox1
                .TextBoxList()
                .Select(textBox => textBox.Name)
                .OrderBy(name => name)
                .ToList();
        }

        private void GetStashButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(noBeepTextBox1.Stash);
        }

        private void RemoveSpacesButton_Click(object sender, EventArgs e)
        {
            MultipleSpacesTextBox.Text = MultipleSpacesTextBox.Text.RemoveMultipleSpaces();
        }

        private void SaveImageButton_Click(object sender, EventArgs e)
        {
            pictureBoxCustom1.ExportToFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Miata.png"));
        }

        private void GetIntValueButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(integerTextBox1.Value.ToString());
        }
    }
}
