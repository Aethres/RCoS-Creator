using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Components
{
    public class ComboBoxR : ComboBox
    {
        List<Process> processList;
        Process process;
        public ComboBoxR(List<Process> processList, Process process)
        {
            this.processList = processList;
            this.process = process;
            Text = "Process is not choosen";
            SelectedIndexChanged += ComboBoxR_SelectedIndexChanged;

            foreach (var item in processList)
            {
                if (item != process && !process.GoingEvents.Contains(item))
                {
                    Items.Add(item.ProcessName);
                }
                
            }
        }

        private void ComboBoxR_SelectedIndexChanged(object sender, EventArgs e)
        {
            process.GoingEvents.Add((Process)Items[SelectedIndex]);
        }
    }
}
