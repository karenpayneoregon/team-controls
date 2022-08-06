using System;
using System.Windows.Forms;

// since DateTimeHelpers is a static class we can do this
using static TeamHelpers.DateTimeHelpers;

namespace TeamControls
{
    /// <summary>
    /// MonthComboBox modifer is public
    /// </summary>
    public partial class PanelControl : UserControl
    {
        public PanelControl()
        {
            InitializeComponent();
        }

        private void PanelControl_Load(object sender, EventArgs e)
        {
            MonthComboBox.DataSource = MonthsWithSelect();
        }
    }
}
