using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BinaryStructureModuleGraph
{
    public unsafe partial class PeriodForm : Form
    {

        private int* lStr;
        public PeriodForm(int *_lStr)
        {
            InitializeComponent();
            Icon = Resource.period_ico;
            lStr = _lStr;
            periodValue.Value = *lStr;
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            *lStr = Convert.ToInt32(periodValue.Value);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
