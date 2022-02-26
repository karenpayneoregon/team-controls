using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamControls
{
    /// <summary>
    /// Provides an easy way to format .Text property as currency.
    /// </summary>
    public class CurrencyFormattedLabel : Label
    {

        [Category("Behavior"), Description("Identifier")]
        public int Id { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public bool HasId => Id > -1;

        [Category("Behavior"), Description("Stash")]
        public string Stash { get; set; }

        public CurrencyFormattedLabel()
        {
            DoubleFormat = "c";
        }

        public void SetDoubleValue(double value)
        {
            Text = value.ToString(DoubleFormat);
        }
        public void SetDoubleValue(string caption, double value)
        {
            Text = value.ToString(DoubleFormat);
            Text = $"{caption} {value.ToString(DoubleFormat)}";
        }
        public void SetDoubleValue(double value1, double value2)
        {
            Text = (value1 + value2).ToString(DoubleFormat);
        }
        public void SetDoubleValue(string caption, double value1, double value2)
        {
            Text = $"{caption} {(value1 + value2).ToString(DoubleFormat)}";
        }
        public void SetDoubleValue(string caption, params double[] args)
        {
            Text = $"{caption} {args.Sum().ToString(DoubleFormat)}";
        }
        public void SetDoubleValue(params double[] args)
        {
            Text = args.Sum().ToString(DoubleFormat);
        }

        [Category("Behavior"), Description("Format for SetDoubleValue")]
        public string DoubleFormat { get; set; }
    }

}
