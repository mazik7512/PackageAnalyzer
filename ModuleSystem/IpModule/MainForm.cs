using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IpPackageParser;

namespace IpModule
{
    public partial class MainForm : Form
    {
        public List<IPHeader> IpHeadersArray { get; set; }
        public List<UDPHeader> udpHeadersArray { get; set; }
        public List<NMEAData> NMEAarray { get; set; }
        private byte[] data;
        private bool animated = false;

        public MainForm()
        {
            InitializeComponent();
            IpHeadersArray = new List<IPHeader>();
            SwipePanel.Size = new Size(SwipePanel.Parent.Size.Width - 50, SwipePanel.Parent.Height - 50);
        }


        public void setData(ref byte[] _data)
        {
            data = _data;
        }

        private void fillData()
        {
            IPPackageParser ipParser = new IPPackageParser(ref data);
            IpHeadersArray = ipParser.GetIPHeaders();
            udpHeadersArray = ipParser.GetUDPHeaders();
            NMEAarray = ipParser.GetNMEAData();
        }

        public void AnalyzeData()
        {
            Thread thread = new Thread(new ThreadStart(fillData));
            thread.Start();
            thread.Join();
            for (int i = 0; i < IpHeadersArray.Count; i++)
            {
                packagePicker.Items.Add("Пакет №" + (i + 1) + " {Чек-сумма: " + IpHeadersArray[i].IpCheckSum + "}");
            }
           
            if (packagePicker.Items.Count > 0)
            {
                packagePicker.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("IP-пакетов не обнаружено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AnalyzeMode.Checked = false;
            }

        }

        private void ClearAllControls(Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (control.Controls[i].GetType().Name.Equals("TextBox"))
                {
                    control.Controls[i].Text = "";
                }

            }
        }

        private void AnalyzeMode_CheckedChanged(object sender, EventArgs e)
        {
            if (AnalyzeMode.Checked)
            {
                IPgroupBox.Enabled = true;
                UDPGroupBox.Enabled = true;
                NmeaGroupBox.Enabled = true;
                DataGroupBox.Enabled = true;
                showMapButton.Enabled = true;
                savePackageButton.Enabled = true;
                AnalyzeData();
            }
            else
            {
                IPgroupBox.Enabled = false;
                UDPGroupBox.Enabled = false;
                NmeaGroupBox.Enabled = false;
                DataGroupBox.Enabled = false;
                showMapButton.Enabled = false;
                savePackageButton.Enabled = false;
                ClearAllControls(IPgroupBox);
                ClearAllControls(UDPGroupBox);
                ClearAllControls(DataGroupBox);
                ClearAllControls(NmeaGroupBox);
                IpHeadersArray.Clear();
                udpHeadersArray.Clear();
                NMEAarray.Clear();
                packagePicker.Items.Clear();
                packagePicker.Text = "";
            }
        }

        private void FillIpValues()
        {
            IPHeaderVersionTextBox.Text = IpHeadersArray.ElementAt(packagePicker.SelectedIndex).IpVersionNumber.ToString();
            IPHeaderLengthTextBox.Text = IpHeadersArray.ElementAt(packagePicker.SelectedIndex).IpHeaderLength.ToString();
            IPHeaderTosTextBox.Text = IpHeadersArray.ElementAt(packagePicker.SelectedIndex).IpTOS.ToString();
            IPHeaderTotalLengthTextBox.Text = IpHeadersArray.ElementAt(packagePicker.SelectedIndex).IpTotalLength.ToString();
            IPHeaderIDTextBox.Text = IpHeadersArray.ElementAt(packagePicker.SelectedIndex).IpPackageID.ToString();
            IPHeaderFlagsListBox.SetItemChecked(0, IpHeadersArray.ElementAt(packagePicker.SelectedIndex).IpDfFlag);
            IPHeaderFlagsListBox.SetItemChecked(1, IpHeadersArray.ElementAt(packagePicker.SelectedIndex).IpMfFlag);
            IPHeaderFragmentOffsetTextBox.Text = IpHeadersArray.ElementAt(packagePicker.SelectedIndex).IpFragmentOffset.ToString();
            IPHeaderTtlTextBox.Text = IpHeadersArray.ElementAt(packagePicker.SelectedIndex).IpTTL.ToString();
            IPHeaderProtocolTextBox.Text = (IpHeadersArray.ElementAt(packagePicker.SelectedIndex).IpProtocol == 17) ? "UDP" : (IpHeadersArray.ElementAt(packagePicker.SelectedIndex).IpProtocol == 6) ? "TCP" : "";
            IPHeaderCheckSumTextBox.Text = IpHeadersArray.ElementAt(packagePicker.SelectedIndex).IpCheckSum;
            IPHeaderSourceIPTextBox.Text = IpHeadersArray.ElementAt(packagePicker.SelectedIndex).IpSource;
            IPHeaderDestinationIPTextBox.Text = IpHeadersArray.ElementAt(packagePicker.SelectedIndex).IpDestination;
        }

        private void FillUDPValues()
        {
            UDPHeaderSourcePortTextBox.Text = udpHeadersArray.ElementAt(packagePicker.SelectedIndex).UdpSourcePort.ToString();
            UDPHeaderDestinationPortTextBox.Text = udpHeadersArray.ElementAt(packagePicker.SelectedIndex).UdpDestinationPort.ToString();
            UDPHeaderLengthTextBox.Text = udpHeadersArray.ElementAt(packagePicker.SelectedIndex).UdpLength.ToString();
            UDPHeaderCheckSumTextBox.Text = udpHeadersArray.ElementAt(packagePicker.SelectedIndex).UdpCheckSum;
        }

        private void FillNmeaValues()
        {
            DATABlockCallSign.Text = NMEAarray.ElementAt(packagePicker.SelectedIndex).DataCallSign;
            NMEAIDTextBox.Text = NMEAarray.ElementAt(packagePicker.SelectedIndex).NmeaId;
            NMEATimeTextBox.Text = NMEAarray.ElementAt(packagePicker.SelectedIndex).NmeaTime;
            NMEACheckTextBox.Text = NMEAarray.ElementAt(packagePicker.SelectedIndex).NmeaCheck;
            NMEALatitudeTextBox.Text = NMEAarray.ElementAt(packagePicker.SelectedIndex).Latitude.ToString();
            NMEADirectionTextBox.Text = NMEAarray.ElementAt(packagePicker.SelectedIndex).LatitudeDirection;
            NMEALongtitudeTextBox.Text = NMEAarray.ElementAt(packagePicker.SelectedIndex).Longitude.TrimStart('0');
            NMEADirectionTextBox1.Text = NMEAarray.ElementAt(packagePicker.SelectedIndex).LongitudeDirection;
            NMEASpeedTextBox.Text = NMEAarray.ElementAt(packagePicker.SelectedIndex).NmeaSpeed;
            NMEAFlowDirectionTextBox.Text = NMEAarray.ElementAt(packagePicker.SelectedIndex).NmeaFlowDirection;
            NMEADateTextBox.Text = NMEAarray.ElementAt(packagePicker.SelectedIndex).NmeaDate;
            NMEAModeTextBox.Text = NMEAarray.ElementAt(packagePicker.SelectedIndex).NmeaMode;
        }
        private void packagePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (packagePicker.Items.Count > 0)
            {
                FillIpValues();
                FillUDPValues();
                FillNmeaValues();
            }
            
        }

        private void showMapButton_Click(object sender, EventArgs e)
        {
            MapForm mapForm = new MapForm(NMEAarray);
            mapForm.ShowDialog();
        }

        private void savePackageButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Текстовые файлы(*.txt)|*.txt|RedSun-файлы|*.redsun|Все файлы|*.*";
            sfd.FileName = "checksum-" + IPHeaderCheckSumTextBox.Text + ".txt";
            if (sfd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                StreamWriter writer = new StreamWriter(sfd.FileName, false, Encoding.GetEncoding("Windows-1251"));
                writer.WriteLine(@"------------------------------Блок метаданных---------------------------");
                writer.WriteLine();
                writer.WriteLine("\t\tКонтрольная сумма IP-заголовка: " + IPHeaderCheckSumTextBox.Text);
                writer.WriteLine("\t\tПротокол: " + IPHeaderProtocolTextBox.Text);
                writer.WriteLine("\t\tКонтрольная сумма " + IPHeaderProtocolTextBox.Text + ": " + UDPHeaderCheckSumTextBox.Text);
                writer.WriteLine("\t\tАдрес отправителя: " + IPHeaderSourceIPTextBox.Text + ":" + UDPHeaderSourcePortTextBox.Text);
                writer.WriteLine("\t\tАдрес получателя: " + IPHeaderDestinationIPTextBox.Text + ":" + UDPHeaderDestinationPortTextBox.Text);
                writer.WriteLine();
                writer.WriteLine(@"-----------------------------/Блок метаданных---------------------------");
                writer.WriteLine();
                writer.WriteLine();
                writer.WriteLine(@"--------------------------------Блок данных-----------------------------");
                writer.WriteLine();
                writer.WriteLine("\t\tПозывной: " + DATABlockCallSign.Text);
                writer.WriteLine("\t\tИдентификатор NMEA: " + NMEAIDTextBox.Text);
                writer.WriteLine("\t\tДата и время фиксации: " + NMEADateTextBox.Text + " " + NMEATimeTextBox.Text);
                writer.WriteLine("\t\tШирота: " + NMEALatitudeTextBox.Text);
                writer.WriteLine("\t\tДолгота: " + NMEALongtitudeTextBox.Text);
                writer.WriteLine("\t\tСкорость: " + NMEASpeedTextBox.Text + " узлов");
                writer.WriteLine("\t\tНаправление движения: " + NMEAFlowDirectionTextBox.Text + " градусов");
                writer.WriteLine();
                writer.WriteLine(@"-------------------------------/Блок данных-----------------------------");
                writer.Close();
            }
        }

        private void SwipePanel_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private async void SwipePanel_MouseEnter(object sender, EventArgs e)
        {
            
            


        }

        private void label30_Click(object sender, EventArgs e)
        {
            
            
        }

        private void animationThread_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }




        private async void showSwipePanel()
        {
            while (SwipePanel.Location.X > (SwipePanel.Parent.Location.X + 10))
            {
                await Task.Delay(1);
                SwipePanel.Location = new Point(SwipePanel.Location.X - (SwipePanel.Location.X / 8), SwipePanel.Location.Y);
            }
            HoverMapButton.Text = ">>";
        }


        private async void hideSwipePanel()
        {
            while (SwipePanel.Location.X < (SwipePanel.Width - 10))
            {
                await Task.Delay(1);
                SwipePanel.Location = new Point(SwipePanel.Location.X + (SwipePanel.Width - SwipePanel.Location.X) / 8, SwipePanel.Location.Y);
            }
            HoverMapButton.Text = "<<";
        }

        private void HoverMapButton_MouseEnter(object sender, EventArgs e)
        {
            if (!animated)
            {
                animated = true;
                int side = SwipePanel.Location.X > (SwipePanel.Parent.Location.X + 10) ? 1 : -1;
                switch (side)
                {
                    case -1:
                        hideSwipePanel();
                        break;
                    case 1:
                        showSwipePanel();
                        break;
                    default:
                        break;
                }
                animated = false;
            }
            
        }
    }
}
