using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace TeamControls
{
    public class IntegerTextBox : TextBox
    {
        [Category("Behavior"), Description("Identifier")]
        public int Id { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public bool HasId => Id > -1;

        [Category("Behavior"), Description("Stash")]
        public string Stash { get; set; }

        private int WM_KEYDOWN = 0x0100;
        int WM_PASTE = 0x0302;
        /// <summary>
        /// The last Text of the control.
        /// </summary>
        private string _defaultText;
        /// <summary>
        /// Gets or sets the default value for the control.
        /// </summary>
        [DefaultValue("0"),
         Category("Appearance"),
         Browsable(true)]
        public string DefaultText
        {
            get => _defaultText;
            set
            {
                var oldValue = _defaultText;
                if (_defaultText != value)
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        _defaultText = value;
                        if (Text == oldValue)
                            Text = _defaultText;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("value", "The default text cannot be empty.");
                    }
                }
            }
        }

        public IntegerTextBox()
        {
            TextAlign = HorizontalAlignment.Right;
            _defaultText = "0";
            Text = _defaultText;
        }
        // New HorizontalAlignment property to enable a new default value.
        /// <summary>
        /// Gets or sets the horizontal alignment of the text.
        /// </summary>
        [DefaultValue(typeof(HorizontalAlignment), "Right"), Category("Appearance")]
        public new HorizontalAlignment TextAlign
        {
            get => base.TextAlign;
            set => base.TextAlign = value;
        }

        /// <summary>
        /// Handle key presses for non numeric data
        /// </summary>
        /// <param name="msg">Window message</param>
        /// <returns>bool from base</returns>
        public override bool PreProcessMessage(ref Message msg)
        {
            if (msg.Msg == WM_KEYDOWN)
            {
                var keys = (Keys)msg.WParam.ToInt32();

                bool numbersCheck = ((keys >= Keys.D0 && keys <= Keys.D9) || (keys >= Keys.NumPad0 && keys <= Keys.NumPad9)) && ModifierKeys != Keys.Shift;

                bool ctrlCheck = keys == Keys.Control;

                bool ctrlZ = keys == Keys.Z && ModifierKeys == Keys.Control,
                    ctrlX = keys == Keys.X && ModifierKeys == Keys.Control,
                    ctrlC = keys == Keys.C && ModifierKeys == Keys.Control,
                    ctrlV = keys == Keys.V && ModifierKeys == Keys.Control,
                    del = keys == Keys.Delete,
                    bksp = keys == Keys.Back,
                    arrows = (keys == Keys.Up)
                    | (keys == Keys.Down)
                    | (keys == Keys.Left)
                    | (keys == Keys.Right);

                if (numbersCheck | ctrlCheck | del | bksp | arrows | ctrlC | ctrlX | ctrlZ)
                {
                    return false;
                }

                else if (ctrlV)
                {
                    // handle pasting from clipboard
                    var clipboardData = Clipboard.GetDataObject();
                    var input = (string)clipboardData?.GetData(typeof(string));
                    if (input != null)
                        foreach (var character in input)
                        {
                            if (!char.IsDigit(character)) return true;
                        }

                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return base.PreProcessMessage(ref msg);
            }
        }
        /// <summary>
        /// Get int value
        /// </summary>
        [Browsable(false)]
        public int Value => int.TryParse(Text, out var value) ? value : 0;
        /// <summary>
        /// Monitor for non-numeric pasted from clipboard
        /// </summary>
        /// <param name="m">Windows message <see cref="Message"/></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_PASTE)
            {
                var clipboardData = Clipboard.GetDataObject();
                var input = (string)clipboardData?.GetData(typeof(string));
                if (input != null)
                    foreach (var character in input)
                    {
                        if (!char.IsDigit(character))
                        {
                            m.Result = (IntPtr) 0;
                            return;
                        }
                    }
            }

            base.WndProc(ref m);

        }
    }
}
