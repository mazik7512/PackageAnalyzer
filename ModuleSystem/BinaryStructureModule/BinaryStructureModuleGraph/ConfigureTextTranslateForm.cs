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
    public unsafe partial class ConfigureTextTranslateForm : Form
    {
        private int* startNBytes;
        private int* endNBytes;

        public ConfigureTextTranslateForm(int *start, int *end)
        {
            InitializeComponent();
            Icon = Resource.TextConfigure_ico;

            startNBytes = start;
            endNBytes = end;

            headerLengthTextBox.Text = Convert.ToString(*startNBytes);
            footerLengthTextBox.Text = Convert.ToString(*endNBytes);
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            *startNBytes = Convert.ToInt32(headerLengthTextBox.Text);
            *endNBytes = Convert.ToInt32(footerLengthTextBox.Text);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
