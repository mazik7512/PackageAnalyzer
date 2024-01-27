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
    public unsafe partial class CutForm : Form
    {
        private unsafe int* header;
        private unsafe int* footer;
        public CutForm(int* _header, int* _footer)
        {
            InitializeComponent();
            Icon = Resource.cut_ico;

            header = _header;
            footer = _footer;

            headerLengthTextBox.Text = Convert.ToString(*header);
            footerLengthTextBox.Text = Convert.ToString(*footer);
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            *header = Convert.ToInt32(headerLengthTextBox.Text);
            *footer = Convert.ToInt32(footerLengthTextBox.Text);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
