using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Reflection;


/*
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
*/
using System.Threading;
using System.Diagnostics;

namespace PackageAnalyzer
{
    public partial class MainForm : Form
    {

        public static int curIndex = 0;
        private Bitmap bitmap;

        private byte[] showArray;
        private byte[] startArray;
        private byte[] proceseedArray;
        private byte[] syncArray;
        private int counter = 0;
        public int lStr = 1060;
        private byte[] marker = { 0, 1, 1, 1, 0, 0, 1, 1, 0, 1, 1, 1, 0, 0, 1, 1 };
        private int mode = 0;
        private int xSize = 1;
        private int ySize = 1;
        private int syncedCounter = 0;
        private List<NMEAPackage> NMEAarray = new List<NMEAPackage>();
        private bool maxZoom = false;
        private bool minZoom = false;
        private int lastPixel = 0;

        public MainForm()
        {
            InitializeComponent();

            ///////////////////////////////////////////
            //справкаToolStripMenuItem.Visible = false;
            //////////////////////////////////////////
            ///

        }


        private delegate void myInvoker();




        private void chooseMode(int mode)
        {
            if (showArray != null)
            {
                switch (mode)
                {
                    case 0:
                        //this.Invoke(new myInvoker(paintData));
                        paintData();
                        //textData();
                        break;
                    case 1:
                        //this.Invoke(new myInvoker(textData));
                        textData();
                        break;
                    default:
                        break;
                }

                pictureBox1.Invalidate();
            }

        }

        private void writeOneLine(int _i)
        {
            for (int i = 0; i < lStr; i++)
            {
                syncArray[syncedCounter] = showArray[_i];
                syncedCounter++;
                _i++;
            }
        }

        private void paintData()
        {

            int width = lStr;
            int height = (showArray.Length / lStr) + 3;
            bitmap = new Bitmap(width, height);
            int bitCounter = 0;
            int i = 0;
            var t = DateTime.Now;

            for (i = 0; i < bitmap.Height; i++)
            {

                for (int j = 0; j < bitmap.Width; j++)
                {
                    if (bitCounter < showArray.Length)
                    {

                        if (showArray[bitCounter] == 1)
                        {
                            bitmap.SetPixel(j, i, Color.Lime);
                        }
                        else
                        {
                            bitmap.SetPixel(j, i, Color.Black);
                        }
                        bitCounter++;

                    }
                    else
                    {
                        bitmap.SetPixel(j, i, Color.Black);
                    }

                }

            }
            Console.WriteLine(t - DateTime.Now);
            lastPixel = i;
            pictureBox1.Image = bitmap;

        }

        private void textData()
        {

            Font font = new Font("Arial", 8, FontStyle.Regular);
            Brush greenBrush = new SolidBrush(Color.Green);
            Brush blackBrush = new SolidBrush(Color.Black);
            int bitCounter = 0;
            bitmap = new Bitmap(lStr * 10, (showArray.Length / lStr) * 10 + 20);
            Graphics graphics = Graphics.FromImage(bitmap);
            //graphics.DrawString("1", font, greenBrush, 10, 10);
            int c = 0;
            for (int i = 0; i < bitmap.Height; i+=10)
            {
                for (int j = 0; j < lStr * 10; j+=10)
                {
                    if (bitCounter < showArray.Length)
                    {
                        if (showArray[bitCounter] == 1)
                        {
                            graphics.DrawString("1", font, greenBrush, j, i);

                        }
                        else
                        {
                            graphics.DrawString("0", font, blackBrush, j, i);
                        }
                        bitCounter++;
                    }
                    else
                    {
                        break;
                    }
                    
                }
            }
            pictureBox1.Image = bitmap;

        }



        private void readFile(Object _fileStream)
        {
            var t = DateTime.Now;
            int c = 0;
            int temp;
            //BinaryReader reader = new BinaryReader(fileStream);
            startArray = new byte[showArray.Length];
            Console.WriteLine(showArray.Length);
            counter = 0;
            FileStream fileStream = (FileStream)_fileStream;

            for (int i = 0; i < fileStream.Length; i++)
            {
                temp = fileStream.ReadByte();

                for (int j = 0; j < 8; j++)
                {
                    showArray[counter] = Convert.ToByte((temp >> j) & 0x01);
                    //if (counter == showArray.Length - 1)
                    //{
                    //   break;
                    //}
                    counter++;

                }
                //this.Invoke(new ThreadStart(delegate { toolStripProgressBar1.PerformStep(); })); //Очень долго(переключение между потоками)
                //this.Invoke(new myInvoker(toolStripProgressBar1.PerformStep)); //Побыстрее, но без отрисовки все еще куда быстрее
            }
            Array.Copy(showArray, startArray, showArray.Length);
            var t1 = DateTime.Now;
            Console.WriteLine("Файл считан за " + (t1 - t));
            chooseMode(mode);
            //toolStripStatusLabel3.Text = String.Format("Прочитано - {0} бит", counter);
            //reader.Close();

        }

        private void бинарныйРежимToolStripMenuItem_Click(object sender, EventArgs Exception)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Бинарные данные(*.bin)|*.bin|Все файлы|*.*";
            if (ofd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {

                showArray = new byte[new FileInfo(ofd.FileName).Length * 8];
                readFile(ofd.OpenFile());
            }

            ofd.Dispose();
        }

        private void fillNMEA()
        {
            try
            {
                while (curIndex < showArray.Length)
                {

                    NMEAarray.Add(new NMEAPackage());
                    if (!NMEAarray.ElementAt(NMEAarray.Count - 1).SetData(showArray, curIndex))
                    {
                        NMEAarray.Remove(NMEAarray.Last());
                    }
                    if (!NMEAarray.ElementAt(NMEAarray.Count - 1).verified)
                    {
                        NMEAarray.Remove(NMEAarray.Last());
                    }
                    curIndex += NMEAarray.ElementAt(NMEAarray.Count - 1).IpTotalLength * 8 + 1;
                }
                for (int i = 0; i < NMEAarray.Count; i++)
                {
                    NMEAarrayComboBox.Items.Add((i + 1).ToString() + "  {Чек-сумма: " + NMEAarray.ElementAt(i).IpCheckSum + "}");
                }
                if (NMEAarray.Count > 0)
                {
                    NMEAarrayComboBox.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("IP-пакетов не обнаружено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                

            }
            catch
            {

            }

        }

        private void графическийРежимToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (графическийРежимToolStripMenuItem.Checked)
            {
                графическийРежимToolStripMenuItem.Image = Resources.GraphMode;
                графическийРежимToolStripMenuItem.Text = "Графический режим";
                mode = 0;
                chooseMode(mode);
                tabControl.SelectedIndex = 0;
            }
            else
            {
                графическийРежимToolStripMenuItem.Image = Resources.TextMode;
                графическийРежимToolStripMenuItem.Text = "Текстовый режим";
                mode = 1;
                chooseMode(mode);
                tabControl.SelectedIndex = 0;
            }
        }

        private void обработка10ст8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            int c = 0;
            int k = 1;
            proceseedArray = new byte[showArray.Length];
            for (int i = 0; i < showArray.Length - 9; i++)
            {

                if (showArray[i] == 0 && showArray[i + 9] == 1)
                {
                    for (int j = i + 1; j < i + 9; j++)
                    {
                        proceseedArray[c] = showArray[j];
                        c++;

                    }
                    i += 9;
                }
            }
            showArray = proceseedArray;
            lStr = 816;
            chooseMode(mode);
            //toolStripStatusLabel4.Text = String.Format("Осталось после 10ст8 - {0} бит", c);
        }

        private void кадроваяСинхронизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lStr = 800;
            syncedCounter = 0;

            bitmap = new Bitmap(lStr, (showArray.Length) / (lStr));
            syncArray = new byte[showArray.Length];

            for (int i = 0; i < showArray.Length - lStr; i++)
            {
                if (showArray[i] == marker[0])
                {
                    for (int j = 1; j < marker.Length; j++)
                    {
                        if (showArray[i + j] != marker[j])
                        {
                            break;
                        }
                        else if (j == marker.Length - 1 && showArray[i + j] == marker[j])
                        {
                            writeOneLine(i + j + 1);
                            i += lStr + marker.Length - 1;
                        }
                    }
                }
            }
            showArray = syncArray;
            chooseMode(mode);
        }

        private void сбросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            обработка10ст8ToolStripMenuItem.Checked = false;
            кадроваяСинхронизацияToolStripMenuItem.Checked = false;
            showArray = startArray;
            lStr = 1060;
            chooseMode(mode);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Icon = Resources.PackageAnalyzerIcon;
            imageList1.Images.Add(Resources.GraphMode);
            imageList1.Images.Add(Resources.Analyze);
            imageList1.Images.Add(Resources.TextMode);

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bitmap != null)
            {
                bitmap.Dispose();
            }

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    break;
            }
        }

        private void PlusSize()
        {
            //if (!maxZoom)
            {

                Size nSize = new Size(pictureBox1.Image.Width * 2, pictureBox1.Image.Height * 2);
                Image gdi = new Bitmap(nSize.Width, nSize.Height);
                Graphics ZoomInGraphics = Graphics.FromImage(gdi);
                ZoomInGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                ZoomInGraphics.DrawImage(pictureBox1.Image, new Rectangle(new Point(0, 0), nSize), new Rectangle(new Point(0, 0), pictureBox1.Image.Size), GraphicsUnit.Pixel);
                ZoomInGraphics.Dispose();//
                pictureBox1.Image = gdi;
                pictureBox1.Size = gdi.Size;
                pictureBox1.Invalidate();
                minZoom = false;
                maxZoom = true;
            }
        }

        private void MinusSize()
        {
            if (!minZoom)
            {
                Size nSize = new Size(pictureBox1.Image.Width / 2, pictureBox1.Image.Height / 2);
                Image gdi = new Bitmap(nSize.Width, nSize.Height);
                Graphics ZoomInGraphics = Graphics.FromImage(gdi);
                ZoomInGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                ZoomInGraphics.DrawImage(pictureBox1.Image, new Rectangle(new Point(0, 0), nSize), new Rectangle(new Point(0, 0), pictureBox1.Image.Size), GraphicsUnit.Pixel);
                ZoomInGraphics.Dispose();//
                pictureBox1.Image = gdi;
                pictureBox1.Size = gdi.Size;

                pictureBox1.Invalidate();
                minZoom = true;
                maxZoom = false;
            }
        }
        private void увеличитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlusSize();
        }

        private void уменьшитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MinusSize();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {



            xSize = pictureBox1.Size.Width;
            ySize = pictureBox1.Size.Height;
            //toolStripStatusLabel2.Text = String.Format("{0}x{1}", xSize, ySize);
        }


        private void обработка9ст7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c = 0;
            proceseedArray = new byte[showArray.Length];
            for (int i = 0; i < showArray.Length - 8; i++)
            {

                if (showArray[i] == 0 && showArray[i + 8] == 1)
                {
                    for (int j = i + 1; j < i + 8; j++)
                    {
                        proceseedArray[c] = showArray[j];
                        c++;

                    }
                    i += 8;
                }
            }
            showArray = proceseedArray;
            lStr = 816;
            chooseMode(mode);
        }

        private void обработка11ст8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c = 0;
            proceseedArray = new byte[showArray.Length];
            for (int i = 0; i < showArray.Length - 10; i++)
            {

                if (showArray[i] == 0 && showArray[i + 9] == 1 && showArray[i + 10] == 1)
                {
                    for (int j = i + 1; j < i + 9; j++)
                    {
                        proceseedArray[c] = showArray[j];
                        c++;

                    }
                    i += 10;
                }
            }
            showArray = proceseedArray;
            lStr = 816;
            chooseMode(mode);
        }

        private void сохранитьПотокКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int temp = 0;
            StringBuilder bits = new StringBuilder();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Бинарные данные(*.bin)|*.bin|Все файлы|*.*";
            sfd.FileName = String.Format("BinaryData_{0}_period.bin", lStr);
            if (sfd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                //StreamWriter writer = new StreamWriter(sfd.FileName, false, Encoding.GetEncoding(1252));
                for (int i = 0; i < showArray.Length; i+=8)
                {

                    //temp = Convert.ToByte(showArray[i + 7] << 7);
                    bits.Clear();
                    temp = 0;
                    for (int j = 0; j < 8; j++)
                    {
                        //bits.Append(showArray[i + j]);
                        temp = Convert.ToByte(showArray[i + j] << j) | temp;
                    }
                    //writer.Write(Convert.ToChar(Convert.ToByte(bits.ToString().PadLeft(8,'0'), 2)));
                    fs.WriteByte(Convert.ToByte(temp));
                    //writer.Write(temp);
                }
                fs.Close();
                //writer.Close();
            }
        }

        private void периодСтрокиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unsafe
            {
                fixed (int* _lStr = &lStr)
                {
                    PeriodForm form = new PeriodForm(_lStr);

                    form.ShowDialog();
                }
                chooseMode(mode);
            }
        }

        private void перевестиВТекстИСохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showArray.Length > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Текстовые файлы(*.txt)|*.txt|RedSun-файлы|*.redsun|Все файлы|*.*";
                sfd.FileName = "TextData.txt";
                if (sfd.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                else
                {

                    StreamWriter writer = new StreamWriter(sfd.FileName, false, Encoding.GetEncoding("Windows-1252"));

                    int k = 0;
                    byte temp = 0;
                    for (int i = 0; i < showArray.Length; i++)
                    {
                        if (k > 151 && k < 791)
                        {
                            temp = Convert.ToByte(showArray[i + 7] << 7);
                            for (int j = 6; j >= 0; j--)
                            {
                                temp |= Convert.ToByte(showArray[i + j] << j);
                            }
                            writer.Write(Convert.ToChar(temp));
                            i += 7;
                        }
                        if (k == 799)
                        {
                            k = 0;
                        }
                        k++;

                    }
                    writer.Close();
                }

            }

        }


        private void оПрограммеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowInTaskbar = false;
            about.ShowDialog();
        }

        private void ClearAllControls(Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (control.Controls[i].GetType().Name == "TextBox")
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
                DataGroupBox.Enabled = true;
                showMapButton.Enabled = true;
                fillNMEA();

            }
            else
            {
                IPgroupBox.Enabled = false;
                UDPGroupBox.Enabled = false;
                DataGroupBox.Enabled = false;
                showMapButton.Enabled = false;
                ClearAllControls(IPgroupBox);
                ClearAllControls(UDPGroupBox);
                ClearAllControls(DataGroupBox);
                ClearAllControls(NmeaGroupBox);
                curIndex = 0;
                NMEAarray.Clear();
                NMEAarrayComboBox.Items.Clear();
                NMEAarrayComboBox.Text = "";
            }



        }

        private void синхрогруппаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unsafe
            {
                fixed (byte* ptr = marker)
                {
                    SyncGroupForm form = new SyncGroupForm(ptr);
                    form.ShowDialog();
                }
            }

        }

        private void showMapButton_Click(object sender, EventArgs e)
        {
            MapForm form = new MapForm(NMEAarray);
            form.ShowDialog();

        }

        private void NMEAarrayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).IpVersionNumber != 0)
            {
                IPHeaderVersionTextBox.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).IpVersionNumber.ToString();
                IPHeaderLengthTextBox.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).IpHeaderLength.ToString();
                IPHeaderTosTextBox.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).IpTOS.ToString();
                IPHeaderTotalLengthTextBox.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).IpTotalLength.ToString();
                IPHeaderIDTextBox.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).IpPackageID.ToString();
                IPHeaderFlagsListBox.SetItemChecked(0, NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).IpDfFlag);
                IPHeaderFlagsListBox.SetItemChecked(1, NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).IpMfFlag);
                IPHeaderFragmentOffsetTextBox.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).IpFragmentOffset.ToString();
                IPHeaderTtlTextBox.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).IpTTL.ToString();
                IPHeaderProtocolTextBox.Text = (NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).IpProtocol == 17) ? "UDP" : (NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).IpProtocol == 6) ? "TCP" : "";
                IPHeaderCheckSumTextBox.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).IpCheckSum;
                IPHeaderSourceIPTextBox.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).IpSource;
                IPHeaderDestinationIPTextBox.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).IpDestination;
                UDPHeaderSourcePortTextBox.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).UdpSourcePort.ToString();
                UDPHeaderDestinationPortTextBox.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).UdpDestinationPort.ToString();
                UDPHeaderLengthTextBox.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).UdpLength.ToString();
                UDPHeaderCheckSumTextBox.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).UdpCheckSum;
                DATABlockCallSign.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).DataCallSign;
                NMEAIDTextBox.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).NmeaId;
                NMEATimeTextBox.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).NmeaTime;
                NMEACheckTextBox.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).NmeaCheck;
                NMEALatitudeTextBox.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).Latitude.ToString();
                NMEADirectionTextBox.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).LatitudeDirection;
                NMEALongtitudeTextBox.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).Longitude.TrimStart('0');
                NMEADirectionTextBox1.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).LongitudeDirection;
                NMEASpeedTextBox.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).NmeaSpeed;
                NMEAFlowDirectionTextBox.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).NmeaFlowDirection;
                NMEADateTextBox.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).NmeaDate;
                NMEAModeTextBox.Text = NMEAarray.ElementAt(NMEAarrayComboBox.SelectedIndex).NmeaMode;
            }
            else
            {
                MessageBox.Show("Ошибка: Данные не найдены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void printBinaryDataInTextBox(byte[] array)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (j == lStr - 1)
                {
                    stringBuilder.Append(Environment.NewLine);
                    j = 0;
                }
                stringBuilder.Append(array[i]);
                j++;
            }
            DataTextBox.Text = stringBuilder.ToString();
            stringBuilder.Clear();
        }

        private void printDecDataInTextBox(byte[] array)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (j == (lStr / 8) - 1)
                {
                    stringBuilder.Append(Environment.NewLine);
                    j = 0;
                }
                stringBuilder.Append(array[i]).Append(' ');
                j++;
            }
            DataTextBox.Text = stringBuilder.ToString();
            stringBuilder.Clear();
        }

        private void printHexDataInTextBox(byte[] array)
        {
            char[] symbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            StringBuilder stringBuilder = new StringBuilder();
            int j = 0;
            for (int i = 0; i < array.Length - 1; i += 2)
            {
                if (j == (lStr / 8) - 1)
                {
                    stringBuilder.Append(Environment.NewLine);
                    j = 0;
                }
                stringBuilder.Append(symbols[array[i + 1] % 16]).Append(symbols[array[i] % 16]);
                j++;
            }
            DataTextBox.Text = stringBuilder.ToString();
            stringBuilder.Clear();
        }

        private void BinaryArrayButton_Click(object sender, EventArgs e)
        {
            if (showArray != null)
            {
                printBinaryDataInTextBox(showArray);
            }

        }

        private void DecimalArrayButton_Click(object sender, EventArgs e)
        {
            if (showArray != null)
            {
                printDecDataInTextBox(ConverterBits.ToDecArray(showArray));
            }

        }

        private void HexArrayButton_Click(object sender, EventArgs e)
        {
            if (showArray != null)
            {
                printHexDataInTextBox(ConverterBits.ToHexArray(showArray));
            }

        }


        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Insert:
                    lStr++;
                    chooseMode(mode);
                    break;
                case Keys.Delete:
                    lStr--;
                    chooseMode(mode);
                    break;
                case Keys.Add:
                    PlusSize();
                    Invalidate();
                    break;
                case Keys.Subtract:
                    MinusSize();
                    Invalidate();
                    break;
                default:
                    break;
            }

        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            Console.WriteLine("test");
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
                var fileName = (string[])e.Data.GetData(DataFormats.FileDrop);
                Console.WriteLine("Вы хотите загрузить файл " + fileName[0]);
            }
        }

        private void BinaryStructure_DragEnter(object sender, DragEventArgs e)
        {
            Console.WriteLine("tabpage");
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
                var fileName = (string[])e.Data.GetData(DataFormats.FileDrop);
                Console.WriteLine("Вы хотите загрузить файл " + fileName[0]);
            }
        }
    }
}
