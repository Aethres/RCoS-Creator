using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Components
{
    public class TextBoxR : TextBox
    {
        List<string> list;
        int index;
        public TextBoxR(List<string> list, int index)
        {
            this.list = list;
            this.index = index;
            this.Text = list[index];
        }
        public override string Text
        {
            get => base.Text;
            set
            {
                list.ElementAt(index).Replace(list.ElementAt(index), value);
                base.Text = value;
            }
        }

    }
}
