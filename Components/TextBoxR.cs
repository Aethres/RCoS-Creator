using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.FileGenerators;

namespace WindowsFormsApp1.Components
{
    public class TextBoxR : TextBox
    {
        ProcessItem processItem;
        public TextBoxR(ProcessItem processItem)
        {
            this.processItem = processItem;
            Text = processItem.Name;
            TextChanged += (bs, be) =>
            {
                Text = Text;
            };
        }
        public override string Text
        {
            get => base.Text;
            set
            {
                processItem.Name = value;
                base.Text = value;
            }
        }

    }
}
