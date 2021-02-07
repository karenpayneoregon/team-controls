using System.Windows.Forms;

namespace TeamHelpers
{
    public static class Dialogs
    {
        /// <summary>
        /// Present a dialog prompting for yes/no response with no as the default response
        /// </summary>
        /// <param name="text">Text to display as a question</param>
        /// <returns>true if responded with yes else false</returns>
        public static bool Question(string text) => (MessageBox.Show(text, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes);
        /// <summary>
        /// Present a dialog prompting for yes/no response with no as the default response
        /// </summary>
        /// <param name="text">Text to display as a question</param>
        /// <param name="title">Dialog title</param>
        /// <returns>true if responded with yes else false</returns>
        public static bool Question(string text, string title) => (MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes);
        /// <summary>
        /// Display message with information icon
        /// </summary>
        /// <param name="text">Text to display</param>
        public static void InformationDialog(string text)
        {
            MessageBox.Show(text, @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Display message with information icon
        /// </summary>
        /// <param name="text">Text to display</param>
        /// <param name="title">Title/caption to display</param>
        public static void InformationDialog(string text, string title)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Display message with error icon
        /// </summary>
        /// <param name="text">Text to display</param>
        /// <param name="title">Title/caption to display</param>
        public static void ErrorDialog(string text, string title = "Error")
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}