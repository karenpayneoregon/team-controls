using System;
using System.Windows.Forms;

// for Repeater
using static TeamHelpers.StringHelpers;
// using alias
using D = WindowsFormsLibrary.Classes.Dialogs;

namespace PanelControlTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Text = Repeater('_', 30);
        }

        private void GetSelectedMonthButton_Click(object sender, EventArgs e)
        {
            D.Information(this,MonthsPanel.MonthComboBox.Text == @"Select" ?
                "Please select a month" :
                MonthsPanel.MonthComboBox.Text);
        }
    }
}
