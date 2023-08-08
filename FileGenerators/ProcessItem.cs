using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.FileGenerators
{
    public class ProcessItem
    {
        bool isActive;
        string name;

        public ProcessItem()
        {
            IsActive = true;
        }

        public ProcessItem(string name)
        {
            IsActive = true;
            this.Name = name;
        }

        public bool IsActive { get => isActive; set => isActive = value; }
        public string Name { get => name; set => name = value; }
    }
}
