using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PackageAnalyzer
{
    public partial class SyncGroupForm : Form
    {
        private unsafe byte *marker;
        public unsafe SyncGroupForm(byte *m)
        {
            InitializeComponent();
            marker = m;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            setMarker();
            Close();
        }

        private unsafe void setMarker()
        {
            char[] temp = SyncGroupTextBox.Text.ToCharArray();
           
            if (invertedOrderCheckBox.Checked)
            {
                for (int i = 0; i < SyncGroupTextBox.Text.Length; i++)
                {
                    marker[i] = Byte.Parse(temp[i].ToString());
                    Console.Write(marker[i] + " ");
                }
            }
            else
            {
                for (int i = SyncGroupTextBox.Text.Length - 1, j = 0; i >= 0; i--, j++)
                {
                    marker[j] = Byte.Parse(temp[i].ToString());
                }
            }

        }
    }
}
