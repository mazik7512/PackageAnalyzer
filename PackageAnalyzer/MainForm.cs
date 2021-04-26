using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.Threading;

namespace PackageAnalyzer
{
    public partial class MainForm : Form
    {
        private Bitmap bitmap;
        private byte[] showArray;
        private byte[] startArray;
        private byte[] proceseedArray;
        private byte[,] syncArray;
        private int counter = 0;
        private int lStr = 1060;
        private byte[] marker = { 0, 1, 1, 1, 0, 0, 1, 1, 0, 1, 1, 1, 0, 0, 1, 1 };
        private int[] character;
        private int mode = 0;
        private int xSize = 1;
        private int ySize = 1;

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
                        this.Invoke(new myInvoker(paintData));
                        //paintData();
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
                if (showArray[_i] == 1)
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
            for (int i = 0; i < lStr; i++)
            {
                for (int j = 0; j < showArray.Length / lStr; j++)
                {
                    if (syncArray[i,j] == 1)
                    {
                        bitmap.SetPixel(i, j, Color.Lime);
                    }
                    else
                    {
                        bitmap.SetPixel(i, j, Color.Black);
                    }
                }
            }
            pictureBox1.Image = bitmap;
        }


        private void writeOneLine(int _i, int _j)
        {
            for (int i = 0; i < lStr; i++)
            {
                syncArray[i, _j] = showArray[_i];
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
            
            Font font = new Font("Segoe UI", 5, FontStyle.Bold);
            Brush greenBrush = new SolidBrush(Color.Green);
            Brush blackBrush = new SolidBrush(Color.Black);
            int bitCounter = 0;
            bitmap = new Bitmap(lStr, showArray.Length / lStr);
            Graphics graphics = Graphics.FromImage(bitmap);
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
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


        private void readFile(Stream fileStream)
        {
            int c = 0;
            int temp;
            //BinaryReader reader = new BinaryReader(fileStream);
            startArray = new byte[showArray.Length];
            for (int i = 0; i < fileStream.Length; i++)
            {
                temp = fileStream.ReadByte();
                for (int j = 0; j < 8; j++)
                {
                    showArray[counter] = Convert.ToByte((temp >> j) & 0x01);
                    if (counter + 1 == showArray.Length - 1)
                    {
                        break;
                    }
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
                //pictureBox1.Width = 1060;
                //pictureBox1.Height = showArray.Length / 1060;
                //toolStripProgressBar1.Maximum = (showArray.Length - 1);
                //Task.Run(() => readFile(ofd.OpenFile()));
                readFile(ofd.OpenFile());
       
            }
            ofd.Dispose();
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
                pictureBox1.Invalidate();
            }
            else
            {
                графическийРежимToolStripMenuItem.Image = Resources.TextMode;
                графическийРежимToolStripMenuItem.Text = "Текстовый режим";
                mode = 1;
                pictureBox1.Invalidate();
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
            bitmap = new Bitmap(lStr, (showArray.Length) / (lStr));
            syncArray = new byte[lStr, showArray.Length / lStr];
            int line = 0;
            for (int i = 0; i < showArray.Length - (marker.Length); i++)
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
                            //writeOneLine(i + j + 1, line);
                            paintOneLine(line, i + j + 1);
                            line++;
                            i += marker.Length;
                        }
                    }
                }
            }
            //paintSyncedArray();
            pictureBox1.Invalidate();
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

        private void перевестиВТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            character = new int[showArray.Length / 8];
            //ВРОДЕ КАК РАБОТАЕТ ПОПРОБОВАТЬ ВЫВЕСТИ В ФАЙЛ
            int c = 0;
            string bits = "";
            string res = "";
            byte[] bytes = new byte[showArray.Length / 8];
            int k = 0;

            for (int i = 0; i < showArray.Length / 8; i++)
            {
                bits = "";
                for (int j = 0; j < 8; j++)
                {
                    bits += showArray[k];
                    k++;
                }
                //bytes[c] = Convert.ToByte(bits, 2);
                res += Convert.ToString(Convert.ToByte(bits, 2));
                c++;
                
            }
            textBox1.Text = res;
            //Console.WriteLine(c);
            //textBox1.Text += Encoding.ASCII.GetString(character);//Encoding.ASCII.GetString(character);
            tabControl.SelectedIndex = tabControl.TabPages.IndexOf(ASCIIText);
        }

        private void сохранитьТекстКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Текстовый файл(*.txt)|*.txt|Все файлы|*.*";
            sfd.FileName = "save.txt";
            
            if (sfd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                StreamWriter streamWriter = new StreamWriter(sfd.FileName, false, Encoding.ASCII);
                for (int i = 0; i < character.Length; i++)
                {
                    streamWriter.Write(character[i]);
                    streamWriter.Write(" ");
                }
                streamWriter.Close();
            }
        }
    }
}
