using System.ComponentModel;
using System.Windows.Forms;

namespace TeamControls
{
    public class TextBoxUpDown : TextBox
    {
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
