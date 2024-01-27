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
    public partial class SyncGroupForm : Form
    {
        private StringBuilder marker;
        public SyncGroupForm(StringBuilder _marker)
        {
            InitializeComponent();
            Icon = BinaryStructureModuleGraph.Resource.SyncGroup_ico;

            marker = _marker;
            frameMarkerTextBox.Text = marker.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            marker.Remove(0, marker.Length);
            //marker.Clear();
            marker.Append(frameMarkerTextBox.Text);
        }
    }
}
