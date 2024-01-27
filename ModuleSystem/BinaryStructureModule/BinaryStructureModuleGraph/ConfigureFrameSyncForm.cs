using System;
using System.Text;
using System.Windows.Forms;

namespace BinaryStructureModuleGraph
{
    public unsafe partial class ConfigureFrameSyncForm : Form
    {
        private int* lStr;
        private StringBuilder marker;
        public ConfigureFrameSyncForm(int *_lStr, StringBuilder _marker)
        {
            InitializeComponent();
            Icon = Resource.frameSyncConfigure_ico;
            lStr = _lStr;
            marker = _marker;

            lStrTextBox.Text = Convert.ToString(*lStr);
            frameMarkerTextBox.Text = marker.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            *lStr = Convert.ToInt32(lStrTextBox.Text);
            marker.Remove(0, marker.Length);
            //marker.Clear();
            marker.Append(frameMarkerTextBox.Text);
        }
    }
}
