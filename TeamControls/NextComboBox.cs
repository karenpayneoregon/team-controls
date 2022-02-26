using System.ComponentModel;
using System.Windows.Forms;

namespace TeamControls
{
    public class NextComboBox : ComboBox
    {

        [Category("Behavior"), Description("Identifier")]
        public int Id { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public bool HasId => Id > -1;

        [Category("Behavior"), Description("Stash")]
        public string Stash { get; set; }

        [Category("Behavior"), Description("When set to true move to next control")]
        public bool NextControlOnEnter { get; set; } = true;


        public delegate void TriggerDelegate();
        /// <summary>
        /// Subscribe to be notified when ENTER was pressed.
        /// </summary>
        public event TriggerDelegate TriggerEvent;
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Return))
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                TriggerEvent?.Invoke();

                if (NextControlOnEnter)
                {
                    SendKeys.Send("{TAB}");
                }

                return;
            }

            base.OnKeyDown(e);
        }
    }
}