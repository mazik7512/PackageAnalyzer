using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseModule
{
    public interface IHost
    {
        void AddControlToMainForm(Control ctrl);

        void AddMenuStripToMainForm(ToolStripMenuItem menuItem, string key);

        void AddNewMenuStripToMainForm(ToolStripMenuItem parentWithChildsItem);
    }
}
