using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace TeamControls
{
    /// <summary>
    /// See https://github.com/karenpayneoregon/csharp-features/tree/master/RadioButtonBinding for usage
    /// (Note the link above uses a regular RadioButton while this code uses <see cref="RadioButtonCustom"/> which is a simple change in the implementation)
    /// </summary>
    [DefaultBindingProperty("Selected")]
    public class RadioGroupBox : GroupBox
    {
        [Description("Occurs when the selected value changes.")]
        public event SelectedChangedEventHandler SelectedChanged;

        public class SelectedChangedEventArgs : EventArgs
        {
            public int Selected { get; private set; }

            internal SelectedChangedEventArgs(int selected)
            {
                Selected = selected;
            }
        }

        public delegate void SelectedChangedEventHandler(object sender, SelectedChangedEventArgs e);


        private int _selected;

        [Browsable(false)]
        [Bindable(BindableSupport.Yes, BindingDirection.TwoWay)]
        [Description("The selected value associated with this control."), Category("Data")]
        public int Selected
        {
            get => _selected;
            set
            {

                var radioButton = this.Controls.OfType<RadioButtonCustom>()
                    .FirstOrDefault(radio => radio.HasId);

                if (radioButton == null) return;
                radioButton.Checked = true;
                _selected = radioButton.Id;
            }
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);

            if (e.Control is RadioButton radioButton)
            {
                radioButton.CheckedChanged += radioButton_CheckedChanged;
            }
        }

        protected void OnSelectedChanged(SelectedChangedEventArgs e)
        {
            SelectedChanged?.Invoke(this, e);
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radio = (RadioButtonCustom)sender;

            if (radio.Checked && radio.Tag != null && int.TryParse(radio.Tag.ToString(), out var val))
            {
                _selected = val;
                OnSelectedChanged(new SelectedChangedEventArgs(_selected));
            }
        }
    }
}
