using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PackageAnalyzer
{
    public partial class PeriodForm : Form
    {
        private unsafe int* lStr;
        
        public unsafe PeriodForm(int* lStr)
        {
            InitializeComponent();
  
            this.lStr = lStr;
        }


        private void setPeriod()
        {
            unsafe
            {
                *lStr = Convert.ToInt32(maskedTextBox1.Text);
            }

            Close();
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            setPeriod();
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                setPeriod();
            }
            
        }
    }
}
