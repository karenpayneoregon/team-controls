using System.ComponentModel;
using System.Windows.Forms;

namespace TeamControls
{
    public class TextBoxUpDown : TextBox
    {
        [Category("Behavior"), Description("Identifier")]
        public int Id { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public bool HasId => Id > -1;

        [Category("Behavior"), Description("Stash")]
        public string Stash { get; set; }

        public TextBoxUpDown()
        {
            Text = "0";
        }
        private int _value;
        
        public void Increment()
        {
            _value += 1;
            Text = _value.ToString();
        }

        public void Decrement()
        {
            _value -= 1;
            Text = _value.ToString();
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public int Value => _value;
    }
}
