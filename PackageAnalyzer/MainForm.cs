using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


/*
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
*/
using System.Threading;

namespace PackageAnalyzer
{
    public partial class MainForm : Form
    {
        private Bitmap bitmap;
        private byte[] showArray;
        private byte[] startArray;
        private byte[] proceseedArray;
        private byte[] syncArray;
        private int counter = 0;
        public int lStr = 1060;
        private byte[] marker = { 0, 1, 1, 1, 0, 0, 1, 1, 0, 1, 1, 1, 0, 0, 1, 1 };
        //private byte[] marker = { 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1, 1 };
        //private byte[] marker = { 1, 1, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 1, 1, 1 };
        //private byte[] marker = { 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 1, 1, 1, 0 };
        private int[] character;
        private int mode = 0;
        private int xSize = 1;
        private int ySize = 1;
        private int syncedCounter = 0;

        public MainForm()
        {
            InitializeComponent();

        }


        private delegate void myInvoker();

        


        private void chooseMode(int mode)
        {
            if (showArray!=null)
            {
                switch (mode)
                {
                    case 0:
                        //this.Invoke(new myInvoker(paintData));
                        paintData();
                        break;
                    case 1:
                        this.Invoke(new myInvoker(textData));
                        //textData();
                        break;
                    default:
                        break;
                }
                pictureBox1.Invalidate();
            }
           
        }

        private void paintOneLine(int line, int _i)
        {

            for (int i = 0; i < lStr; i++)
            {
                if (syncArray[_i] == 1)
                {
                    bitmap.SetPixel(i, line, Color.Lime);
                }
                else
                {
                    bitmap.SetPixel(i, line, Color.Black);
                }
                _i++;
            }
            pictureBox1.Image = bitmap;
        }


        private void paintSyncedArray()
        {
            bitmap = new Bitmap(lStr, showArray.Length / lStr);
            int c = 0;
            for (int i = 0; i < lStr; i++)
            {
                for (int j = 0; j < showArray.Length / lStr; j++)
                {
                    if (syncArray[c] == 1)
                    {
                        bitmap.SetPixel(i, j, Color.Lime);
                    }
                    else
                    {
                        bitmap.SetPixel(i, j, Color.Black);
                    }
                    c++;
                }
            }
            pictureBox1.Image = bitmap;
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

            
            bitmap = new Bitmap(lStr, (showArray.Length) / (lStr));
            int bitCounter = 0;
            
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < lStr; j++)
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
                       return;
                    }
                    
                }
            }
 
            pictureBox1.Image = bitmap;
        }

        private void textData()
        {
            Font font = new Font("Segoe UI", 10, FontStyle.Bold);
            Brush greenBrush = new SolidBrush(Color.Green);
            Brush blackBrush = new SolidBrush(Color.Black);
            int bitCounter = 0;
            bitmap = new Bitmap(lStr, showArray.Length / lStr);
            Graphics graphics = Graphics.FromImage(bitmap);
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < lStr; j++)
                {
                    if (bitCounter < showArray.Length)
                    {
                        if (showArray[bitCounter] == 1)
                        {
                            graphics.DrawString("1", font, greenBrush, j * 2, i * 2);
                        }
                        else
                        {
                            graphics.DrawString("0", font, blackBrush, j * 2, i * 2);
                        }
                        bitCounter++;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            pictureBox1.Image = bitmap;
       
        }

        private void gmap_Load(object sender, EventArgs e)
        {
            /*
            // Настройки для компонента GMap
            gmap.Bearing = 0;
            // Перетаскивание левой кнопки мыши
            gmap.CanDragMap = true;
            // Перетаскивание карты левой кнопкой мыши
            gmap.DragButton = MouseButtons.Left;
            gmap.GrayScaleMode = true;
            // Все маркеры будут показаны
            gmap.MarkersEnabled = true;
            // Максимальное приближение
            gmap.MaxZoom = 18;
            // Минимальное приближение
            gmap.MinZoom = 2;
            // Курсор мыши в центр карты
            gmap.MouseWheelZoomType = MouseWheelZoomType.MousePositionWithoutCenter;
            // Отключение нигативного режима
            gmap.NegativeMode = false;
            // Разрешение полигонов
            gmap.PolygonsEnabled = true;
            // Разрешение маршрутов
            gmap.RoutesEnabled = true;
            // Скрытие внешней сетки карты
            gmap.ShowTileGridLines = false;
            // При загрузке 10-кратное увеличение
            gmap.Zoom = 10;
            // Убрать красный крестик по центру
            gmap.ShowCenter = false;
            // Чья карта используется

            gmap.MapProvider = GMapProviders.GoogleMap;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            //GMaps.Instance.ImportFromGMDB("MapData\\Data.gmdb");
            */
        }


        private void readFile(Object _fileStream)
        {
            int c = 0;
            int temp;
            //BinaryReader reader = new BinaryReader(fileStream);
            startArray = new byte[showArray.Length];
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
            Array.Copy(showArray,startArray,showArray.Length);
            chooseMode(mode);
            toolStripStatusLabel3.Text = String.Format("Прочитано - {0} бит", counter);
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
                //Task.Run(() => readFile(ofd.OpenFile()));
                readFile(ofd.OpenFile());
            }
            ofd.Dispose();
            NMEAPackage nMEA = new NMEAPackage();
            nMEA.SetData(showArray);
            IPHeaderVersionTextBox.Text = nMEA.IpVersionNumber.ToString();
            IPHeaderLengthTextBox.Text = nMEA.IpHeaderLength.ToString();
            IPHeaderTosTextBox.Text = nMEA.IpTOS.ToString();
            IPHeaderTotalLengthTextBox.Text = nMEA.IpTotalLength.ToString();
            IPHeaderIDTextBox.Text = nMEA.IpPackageID.ToString();
            IPHeaderFlagsListBox.SetItemChecked(0, nMEA.IpDfFlag);
            IPHeaderFlagsListBox.SetItemChecked(1, nMEA.IpMfFlag);
            IPHeaderFragmentOffsetTextBox.Text = nMEA.IpFragmentOffset.ToString();
            IPHeaderTtlTextBox.Text = nMEA.IpTTL.ToString();
            IPHeaderProtocolTextBox.Text = (nMEA.IpProtocol == 17) ? "UDP" : (nMEA.IpProtocol == 6) ? "TCP" : "";
            IPHeaderCheckSumTextBox.Text = nMEA.IpCheckSum;
            IPHeaderSourceIPTextBox.Text = nMEA.IpSource;
            IPHeaderDestinationIPTextBox.Text = nMEA.IpDestination;
            UDPHeaderSourcePortTextBox.Text = nMEA.UdpSourcePort.ToString();
            UDPHeaderDestinationPortTextBox.Text = nMEA.UdpDestinationPort.ToString();
            UDPHeaderLengthTextBox.Text = nMEA.UdpLength.ToString();
            UDPHeaderCheckSumTextBox.Text = nMEA.UdpCheckSum;
            DATABlockCallSign.Text = nMEA.DataCallSign;
            NMEAIDTextBox.Text = nMEA.NmeaId;
            NMEALatitudeTextBox.Text = nMEA.Latitude.ToString();
            //ofd.OpenFile().Close();


        }

        private void pcapрежимToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void графическийРежимToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (графическийРежимToolStripMenuItem.Checked)
            {
                графическийРежимToolStripMenuItem.Image = Resources.GraphMode;
                графическийРежимToolStripMenuItem.Text = "Графический режим";
                mode = 0;
                chooseMode(mode);
            }
            else
            {
                графическийРежимToolStripMenuItem.Image = Resources.TextMode;
                графическийРежимToolStripMenuItem.Text = "Текстовый режим";
                mode = 1;
                chooseMode(mode);
            }
        }

        private void обработка10ст8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c = 0;
            int k = 1;
            proceseedArray = new byte[showArray.Length];
            for (int i = 0; i < showArray.Length - 9; i++)
            {

                if (showArray[i] == 0 && showArray[i+9] == 1)
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
            toolStripStatusLabel4.Text = String.Format("Осталось после 10ст8 - {0} бит", c);
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
            imageList1.Images.Add(Resources.Structure);
            imageList1.Images.Add(Resources.Analyze);
            imageList1.Images.Add(Resources.ASCII);

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bitmap!=null)
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

        private void увеличитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Size nSize = new Size(pictureBox1.Image.Width * 2, pictureBox1.Image.Height * 2);
            Image gdi = new Bitmap(nSize.Width, nSize.Height);
            Graphics ZoomInGraphics = Graphics.FromImage(gdi);
            ZoomInGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            ZoomInGraphics.DrawImage(pictureBox1.Image, new Rectangle(new Point(0, 0), nSize), new Rectangle(new Point(0, 0), pictureBox1.Image.Size), GraphicsUnit.Pixel);
            ZoomInGraphics.Dispose();//
            pictureBox1.Image = gdi;
            pictureBox1.Size = gdi.Size;
  
            pictureBox1.Invalidate();
        }

        private void уменьшитьToolStripMenuItem_Click(object sender, EventArgs e)
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
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            xSize = pictureBox1.Size.Width;
            ySize = pictureBox1.Size.Height;
            toolStripStatusLabel2.Text = String.Format("{0}x{1}", xSize, ySize);
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
            byte temp = 0;
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
                StreamWriter writer = new StreamWriter(sfd.FileName, false, Encoding.GetEncoding(1252));
                for (int i = 0; i < showArray.Length; i++)
                {
                    
                    temp = Convert.ToByte(showArray[i + 7] << 7);
                    bits.Clear();
                    
                    for (int j = 6; j >= 0; j--)
                    {
                        //bits.Append(showArray[i + j]);
                        temp |= Convert.ToByte(showArray[i + j] << j);
                    }
                    //writer.Write(Convert.ToChar(Convert.ToByte(bits.ToString().PadLeft(8,'0'), 2)));
                    writer.Write(Convert.ToChar(temp));
                    i+=7;
                }
                writer.Close();
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
                    byte[] asciiBytes = new byte[showArray.Length / 8];
                    int c = 0;
                    byte temp = 0;
                    int codePage = 1252;
                    StringBuilder bits = new StringBuilder();
                    StreamWriter writer = new StreamWriter(sfd.FileName, false, Encoding.GetEncoding("Windows-1252"));

                    int k = 0;

                    for (int i = 0; i < showArray.Length; i++)
                    {
                        //temp = Convert.ToByte(showArray[i] << 0);
                        if (k > 151 && k < 791)
                        {
                            bits.Clear();
                            temp = Convert.ToByte(showArray[i + 7] << 7);
                            for (int j = 6; j >= 0; j--)
                            {
                                //bits.Append(showArray[i + j]);
                                temp = Convert.ToByte(showArray[i + j] << j);
                            }
                            //writer.Write(Convert.ToChar(Convert.ToByte(bits.ToString().PadLeft(8, '0'), 2)));
                            writer.Write(Convert.ToChar(temp));
                            i += 7;
                        }
                        if (k == 799)
                        {
                            k = 0;
                        }
                        k++;
                        
                    }
                    /*
                    for (int i = 0; i < showArray.Length - 8; i++)
                    {
                        bits.Clear();
                        for (int j = 0; j < 8; j++)
                        {
                            bits.Append(showArray[k]);
                            //if (showArray[k] == 1)
                            //{
                                //asciiBytes[i] |= Convert.ToByte(Math.Pow(2, j));
                                //asciiBytes[i] |= Convert.ToByte(showArray[k] << j);
                            //}
                            k++;
                        }
                        //Console.WriteLine(asciiBytes[c]);
                        //bytes[c] = Convert.ToByte(bits, 2);
                        //res.Append(bits.ToString());
                        //writer.Write(Convert.ToChar(Convert.ToByte(bits.ToString(), 2)));
                        //asciiBytes[c] = Convert.ToByte(bits.ToString(), 2);
                        //writer.Write(asciiBytes[i]);
                        //writer.Write(" ");
                        //c++;

                    }
                    writer.Write(Encoding.GetEncoding(codePage).GetString(asciiBytes));
                    */
                    writer.Close();
                    //textBox1.Text = res.ToString();
                    //Console.WriteLine(c);
                }
                
            }

        }


        private void оПрограммеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowInTaskbar = false;
            about.ShowDialog();
        }
    }
}
