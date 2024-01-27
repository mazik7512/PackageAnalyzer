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
    public partial class ConfigureFilterForm : Form
    {
        
        private unsafe int* container;
        private unsafe int* data;
        private unsafe int* lStr;
        private StringBuilder startBits;
        private StringBuilder stopBits;

        public unsafe ConfigureFilterForm(int* _containerLength, int* _dataLength, int* _lStr, StringBuilder start, StringBuilder stop)
        {
            InitializeComponent();

            containerLength.Value = *_containerLength;
            dataLength.Value = *_dataLength;
            period.Value = *_lStr;
            startBitsTextBox.Text = start.ToString();
            stopBitsTextBox.Text = stop.ToString();

            container = _containerLength;
            data = _dataLength;
            lStr = _lStr;
            startBits = start;
            stopBits = stop;
            Icon = Resource.settings_wizard_ico;
        }

        private void containerLength_ValueChanged(object sender, EventArgs e)
        {
            dataLength.Value = (containerLength.Value > 3) ? (containerLength.Value - 2) : 0;
        }

        private unsafe void ExecuteButton_Click(object sender, EventArgs e)
        {
            *container = Convert.ToInt32(containerLength.Value);
            *data = Convert.ToInt32(dataLength.Value);
            *lStr = Convert.ToInt32(period.Value);
            //startBits.Clear();
            //stopBits.Clear();
            startBits.Remove(0, startBits.Length);
            stopBits.Remove(0, stopBits.Length);
            startBits.Append(startBitsTextBox.Text);
            stopBits.Append(stopBitsTextBox.Text);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
