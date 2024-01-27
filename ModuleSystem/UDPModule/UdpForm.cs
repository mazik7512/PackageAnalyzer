using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IpPackageParser;

namespace UDPModule
{
    public partial class UdpForm : Form
    {
        private byte[] data;
        private List<UDPHeader> udpHeaders;
        public UdpForm()
        {
            InitializeComponent();
        }
        public void setData(ref byte[] _data)
        {
            data = _data;
        }
        
        public void AnalyzeUdpData()
        {
            IPPackageParser iPPackageParser = new IPPackageParser(ref data);
            iPPackageParser.GetIPHeaders();
            udpHeaders = iPPackageParser.GetUDPHeaders();
        }
    }
}
