using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BinaryStructureModuleGraph
{
    public partial class MainForm : Form
    {
        private int containerLength;
        private int dataLength;
        private byte[] showArray;
        private Bitmap bitmap;
        private int syncedCounter = 0;
        private int lStr = 1060;
        private byte[] marker = { 0, 1, 1, 1, 0, 0, 1, 1, 0, 1, 1, 1, 0, 0, 1, 1 };
        private byte[] startBits = { 0 };
        private byte[] stopBits = { 1 };
        private int header = 0;
        private int footer = 0;
        private bool mode = true;
        private Font font = new Font("Arial", 8, FontStyle.Regular);

        private DataContainer currentBlocks;

        private DataContainer dataBlocks;
        private DataContainer filtratedBlocks;
        private DataContainer syncBlocks;
        private DataContainer cutBlocks;

        private delegate void FunctionPointer();
        private FunctionPointer lastFunction;

        private int size = 1;
        private DataGridView dataGridView;

        public MainForm()
        {
            InitializeComponent();
            currentPeriod.Text = "Текущий период: " + lStr;
            
            /*dataGridView = new DataGridView();
            dataGridView.Location = new Point(30, 30);
            dataGridView.Parent = dataTable;
            dataGridView.Size = new Size(500, 500);
            dataGridView.VirtualMode = true;
            dataGridView.CellValueNeeded += DataGridView_CellValueNeeded;
            dataGridView.Show();*/
        }

        private void DataGridView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            e.Value = showArray[e.RowIndex + e.ColumnIndex];
        }

        public void setStartData(ref byte[] data)
        {
            initializeData(ref dataBlocks, ref data);
            lastFunction = paintDataByMode;
        }

        public void initializeData(ref DataContainer _dataBlocks, ref byte[] data)
        {
            _dataBlocks = new DataContainer(ref data, lStr);
            _dataBlocks.proceedData();
            framePicker.Items.Clear();
            for (int i = 0; i < _dataBlocks.DataBlocks.Length; i++)
            {
                framePicker.Items.Add("Кадр №" + (i + 1));
            }
            currentBlocks = _dataBlocks;

            framePicker.SelectedIndex = 0;

        }


        public ComboBox getFramePicker()
        {
            return framePicker;
        }

        public PictureBox getPaintBox()
        {
            return paintBox;
        }


        public void textData()
        {
            var t = DateTime.Now;
            Brush greenBrush = new SolidBrush(Color.Green);
            Brush blackBrush = new SolidBrush(Color.Black);
            int bitCounter = 0;
            int fontSize = Convert.ToInt32(font.Size) + 2;
            showArray = currentBlocks.getBlockData(framePicker.SelectedIndex);
            //if (fontSize == 1)
            //{
                bitmap = new Bitmap(lStr * fontSize, (showArray.Length / lStr) * fontSize + (fontSize * 2));
                Graphics graphics = Graphics.FromImage(bitmap);
                for (int i = 0; i < bitmap.Height; i += fontSize)
                {
                    for (int j = 0; j < lStr * fontSize; j += fontSize)
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
            //}
            //else
            //{
                //bitmap = new Bitmap(paintBox.Image, paintBox.Image.Width * 2, paintBox.Image.Height * 2);
            //}
            paintBox.Image = bitmap;
            paintBox.Invalidate();
            Console.WriteLine("Отрисовано за " + (DateTime.Now - t));
        }

        public void paintDataToTable()
        {
            showArray = currentBlocks.getBlockData(framePicker.SelectedIndex);
            dataTable.Clear();
            //dataGridView.ClearSelection();
            for (int i = 0; i < lStr; i++)
            {
                dataTable.Columns.Add(i.ToString(), "Col#" + i.ToString());
                //dataGridView.Columns[i].FillWeight = 1;
            }

            /*for (int i = 0; i < showArray.Length / lStr + 3; i++)
            {
                dataGridView.Rows.Add();
            }*/
            dataTable.VirtualListSize = showArray.Length;
            
            /*
            for (int i = 0; i < showArray.Length / lStr + 3; i++)
            {
                dataTable.Items.Add("");
            }*/
            /*for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    //dataTable[j, i].Value = showArray[i + j];
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.BackColor = showArray[i * j + j] == 1 ? Color.Green : Color.Black;
                    dataTable[j, i].Style = style;
                }
            }*/
        }

        public void paintData()
        {
            paintDataToTable();
            /*
            var t = DateTime.Now;
            showArray = currentBlocks.getBlockData(framePicker.SelectedIndex);
            int width = lStr;
            int height = (showArray.Length / lStr) + 3;
            //if (size == 1)
            //{
                bitmap = new Bitmap(width * size, height * size);

                int bitCounter = 0;

                for (int i = 0; i < bitmap.Height; i += size)
                {
                    for (int j = 0; j < bitmap.Width; j += size)
                    {
                        if (bitCounter < showArray.Length)
                        {
                            if (showArray[bitCounter] == 1)
                            {
                                for (int k = 0; k < size; k++)
                                {
                                    for (int l = 0; l < size; l++)
                                    {
                                        bitmap.SetPixel(j + k, i + l, Color.Lime);
                                    }
                                }

                            }
                            else
                            {
                                for (int k = 0; k < size; k++)
                                {
                                    for (int l = 0; l < size; l++)
                                    {
                                        bitmap.SetPixel(j + l, i + k, Color.Black);
                                    }

                                }
                            }
                            bitCounter++;

                        }
                        else
                        {
                            for (int k = 0; k < size; k++)
                            {
                                for (int l = 0; l < size; l++)
                                {
                                    bitmap.SetPixel(j + l, i + k, Color.Black);
                                }

                            }
                        }

                    }
                }
            //}
            //else
            //{
                //bitmap = new Bitmap(paintBox.Image, width * size, height * size);
            //}
            Console.WriteLine("Отрисовано за " + (DateTime.Now - t));
            paintBox.Image = bitmap;
            paintBox.Invalidate();*/
        }

        public void setPeriod()
        {
            unsafe
            {
                fixed (int* period = &lStr)
                {
                    DialogResult result = new PeriodForm(period).ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        if (bitmap != null)
                        {
                            if (lastFunction == FrameSync)
                            {
                                lastFunction.Invoke();
                            }
                            currentPeriod.Text = "Текущий период: " + lStr;
                            paintDataByMode();
                        }
                    }
                }
            }
        }

        public void paintDataByMode()
        {
            currentPeriod.Text = "Текущий период: " + lStr;
            if (mode == true)
            {
                paintData();
            }
            else if (mode == false)
            {
                textData();
            }
        }


        public bool changeMode()
        {
            mode = !mode;
            switch (mode)
            {
                case true:
                    current_mode_picture.Image = Resource.GraphMode;
                    current_mode_label.Text = "Графический";
                    break;
                case false:
                    current_mode_picture.Image = Resource.TextMode;
                    current_mode_label.Text = "Текстовый";
                    break;
                default:
                    break;
            }
            paintDataByMode();
            return mode;
        }

        public void ConfigureCustomFilter()
        {
            StringBuilder startBitsStr = new StringBuilder(ParamParser.ParseMarker(ref startBits));
            StringBuilder stopBitsStr = new StringBuilder(ParamParser.ParseMarker(ref stopBits));
            unsafe
            {
                fixed (int* _contL = &containerLength, _dataL = &dataLength, _period = &lStr)
                {
                    DialogResult configCustomFilter = new ConfigureFilterForm(_contL, _dataL, _period, startBitsStr, stopBitsStr).ShowDialog();
                    if (configCustomFilter == DialogResult.OK)
                    {
                        startBits = ParamParser.StringToMarker(startBitsStr.ToString());
                        stopBits = ParamParser.StringToMarker(stopBitsStr.ToString());
                        CustomFilter();
                    }
                }
            }

        }


        public void CustomFilter()
        {
            lastFunction = new FunctionPointer(CustomFilter);
            _CustomFilter(containerLength, dataLength);
        }

        private bool checkStartStopBits(ref byte[] arr, int index, int contLength)
        {
            int startCheck = 0;
            int stopCheck = 0;
            for (int i = 0; i < startBits.Length; i++)
            {
                if (arr[index + i] == startBits[i])
                {
                    startCheck++;
                }
            }
            for (int i = 0; i < stopBits.Length; i++)
            {
                if (arr[index + contLength - 1 - i] == stopBits[stopBits.Length - 1 - i])
                {
                    stopCheck++;
                }
            }
            if (startCheck == startBits.Length && stopCheck == stopBits.Length)
            {
                return true;
            }
            return false;
        }

        private void _CustomFilter(int _contLength, int _dataLength)
        {
            int c = 0;
            ref byte[] temp_arr = ref currentBlocks.getData();
            byte[] proceseedArray = new byte[temp_arr.Length];
            for (int i = 0; i < temp_arr.Length - _contLength - 1; i++)
            {
                if (checkStartStopBits(ref temp_arr, i, _contLength)) //temp_arr[i] == 0 && temp_arr[i + _contLength - 1] == 1
                {
                    for (int j = i + 1; j < i + _dataLength + 1; j++)
                    {
                        proceseedArray[c] = temp_arr[j];
                        c++;

                    }
                    i += _contLength - 1;
                }
            }
            Array.Resize(ref proceseedArray, c);
            initializeData(ref filtratedBlocks, ref proceseedArray);
        }

        public void Filter10st8()
        {
            lastFunction = new FunctionPointer(Filter10st8);
            _CustomFilter(10, 8);
        }

        public void Filter11st8()
        {
            lastFunction = new FunctionPointer(Filter11st8);
            _CustomFilter(11, 8);
        }

        public void Filter9st7()
        {
            lastFunction = new FunctionPointer(Filter9st7);
            _CustomFilter(9, 7);
        }


        public void Reset()
        {
            lastFunction = null;
            currentBlocks = dataBlocks;
            paintData();
        }

        private void writeOneLine(ref byte[] syncArray, ref byte[] temp_arr, int _i)
        {
            for (int i = 0; i < lStr; i++)
            {
                syncArray[syncedCounter] = temp_arr[_i];
                syncedCounter++;
                _i++;
            }
        }

        public void ConfigureSyncMarker()
        {
            StringBuilder temp_marker = new StringBuilder(ParamParser.ParseMarker(ref marker));
            DialogResult result = new SyncGroupForm(temp_marker).ShowDialog();
            if (result == DialogResult.OK)
            {
                marker = ParamParser.StringToMarker(temp_marker.ToString());
            }
        }

        public void ConfigureFrameSync()
        {
            StringBuilder temp_marker = new StringBuilder(ParamParser.ParseMarker(ref marker));
            unsafe
            {
                fixed (int* _lStr = &lStr)
                {

                    DialogResult result = new ConfigureFrameSyncForm(_lStr, temp_marker).ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        marker = ParamParser.StringToMarker(temp_marker.ToString());
                        FrameSync();
                    }

                }
            }
        }


        public void FrameSync()
        {
            lastFunction = new FunctionPointer(FrameSync);
            syncedCounter = 0;
            ref byte[] temp_arr = ref currentBlocks.getData();
            byte[] syncArray = new byte[temp_arr.Length];
            for (int i = 0; i < temp_arr.Length - lStr; i++)
            {
                if (temp_arr[i] == marker[0])
                {
                    for (int j = 1; j < marker.Length; j++)
                    {
                        if (temp_arr[i + j] != marker[j])
                        {
                            break;
                        }
                        else if (j == marker.Length - 1 && temp_arr[i + j] == marker[j])
                        {

                            writeOneLine(ref syncArray, ref temp_arr, i + j + 1);
                            i += lStr + marker.Length - 1;
                        }
                    }
                }
            }
            Array.Resize(ref syncArray, syncedCounter);
            initializeData(ref syncBlocks, ref syncArray);
        }


        public void PlusSize()
        {
            if (mode == true)
            {
                GraphPlusSize();
            }
            else
            {
                TextPlusSize();
            }
        }

        public void MinusSize()
        {
            if (mode == true)
            {
                GraphMinusSize();
            }
            else
            {
                TextMinusSize();
            }
        }


        private void GraphPlusSize()
        {
            size++;
            paintData();
            //_PlusGraphSize(2, 2);
        }

        private void GraphMinusSize()
        {
            if (size > 1)
            {
                size--;
                paintData();
            }
            //_MinusGraphSize(2, 2);
        }

        private void _PlusGraphSize(double xScale, double yScale)
        {
            Size nSize = new Size(Convert.ToInt32(paintBox.Image.Width * xScale), Convert.ToInt32(paintBox.Image.Height * yScale));
            Image gdi = new Bitmap(nSize.Width, nSize.Height);
            Graphics ZoomInGraphics = Graphics.FromImage(gdi);
            ZoomInGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            ZoomInGraphics.DrawImage(paintBox.Image, new Rectangle(new Point(0, 0), nSize), new Rectangle(new Point(0, 0), paintBox.Image.Size), GraphicsUnit.Pixel);
            ZoomInGraphics.Dispose();//
            paintBox.Image = gdi;
            paintBox.Size = gdi.Size;
            paintBox.Invalidate();
        }

        private void _MinusGraphSize(double xScale, double yScale)
        {
            Size nSize = new Size(Convert.ToInt32(paintBox.Image.Width / xScale), Convert.ToInt32(paintBox.Image.Height / yScale));
            Image gdi = new Bitmap(nSize.Width, nSize.Height);
            Graphics ZoomInGraphics = Graphics.FromImage(gdi);
            ZoomInGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            ZoomInGraphics.DrawImage(paintBox.Image, new Rectangle(new Point(0, 0), nSize), new Rectangle(new Point(0, 0), paintBox.Image.Size), GraphicsUnit.Pixel);
            ZoomInGraphics.Dispose();//
            paintBox.Image = gdi;
            paintBox.Size = gdi.Size;
            paintBox.Invalidate();
        }

        private void TextPlusSize()
        {
            ChangeTextSize(1.0f);
        }

        private void TextMinusSize()
        {
            ChangeTextSize(-1.0f);
        }

        private void ChangeTextSize(float step)
        {
            float fontSize = font.Size;
            fontSize += step;
            font = new Font("Arial", fontSize, FontStyle.Regular);
            textData();
        }


        public void SaveStreamToFile()
        {
            int temp = 0;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Бинарные данные(*.bin)|*.bin|Все файлы|*.*";
            sfd.FileName = String.Format("BinaryData_{0}_period.bin", lStr);
            if (sfd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                byte[] data = currentBlocks.getData();
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                for (int i = 0; i < data.Length - 8; i += 8)
                {
                    temp = 0;
                    for (int j = 0; j < 8; j++)
                    {
                        temp = Convert.ToByte(data[i + j] << j) | temp;
                    }
                    fs.WriteByte(Convert.ToByte(temp));
                }
                fs.Close();
            }
        }

        public void ConfigureTranslateToText()
        {
            int headerLength = 0;
            int footerLength = 0;
            unsafe
            {
                int* header = &headerLength, footer = &footerLength;
                DialogResult result = new ConfigureTextTranslateForm(header, footer).ShowDialog();
                if (result == DialogResult.OK)
                {
                    TranslateStreamToTextAndSave(*header, *footer);
                }
            }
        }

        private void TranslateStreamToTextAndSave(int startNBytes, int endNBytes)
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
                byte[] data = currentBlocks.getData();
                StreamWriter writer = new StreamWriter(sfd.FileName, false, Encoding.GetEncoding("Windows-1252"));
                int k = 0;
                byte temp = 0;
                for (int i = 0; i < data.Length; i++)
                {
                    if (k > (startNBytes * 8 - 1) && k < (lStr - 1 - (endNBytes * 8)))
                    {
                        temp = Convert.ToByte(data[i + 7] << 7);
                        for (int j = 6; j >= 0; j--)
                        {
                            temp |= Convert.ToByte(data[i + j] << j);
                        }
                        writer.Write(Convert.ToChar(temp));
                        i += 7;
                    }
                    if (k == lStr - 1)
                    {
                        k = 0;
                    }
                    k++;

                }
                writer.Close();
            }
        }

        public void Configure_Cut_Data()
        {
            lastFunction = new FunctionPointer(Configure_Cut_Data);
            _Cut_Data();
        }

        private void _Cut_Data()
        {
            unsafe
            {
                fixed(int* _pHeader = &header, _pFooter = &footer)
                {
                    DialogResult res = new CutForm(_pHeader, _pFooter).ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        _Cut_Array();
                    }
                }
            }
        }

        private void _Cut_Array()
        {
            int k = 0;
            int counter = 0;
            byte[] arr = currentBlocks.getData();
            byte[] new_arr = new byte[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (k > (header * 8 - 1) && k < (lStr - 1 - (footer * 8)))
                {
                    new_arr[counter] = arr[i];
                    counter++;
                }
                if (k == lStr - 1)
                {
                    k = 0;
                }
                k++;

            }
            Array.Resize(ref new_arr, counter);
            initializeData(ref cutBlocks, ref new_arr);
        }

        private void paintBox_Paint(object sender, PaintEventArgs e)
        {
            if (bitmap != null)
            {

            }
        }

        private void panel1_Resize(object sender, EventArgs e)
        {

        }

        private void MainForm_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void paintBox_Resize(object sender, EventArgs e)
        {

        }

        private void paintBox_SizeChanged(object sender, EventArgs e)
        {

        }

        private void framePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            paintDataByMode();
            int start = currentBlocks.DataBlocks[framePicker.SelectedIndex].StartIndex / 8;
            int end = (currentBlocks.DataBlocks[framePicker.SelectedIndex].StartIndex / 8) + (currentBlocks.DataBlocks[framePicker.SelectedIndex].Length / 8 - 1);
            bordersLabel.Text = String.Format("Вывод: с {0} по {1} байт", start, end);
        }

        private void Change_Frame(int change)
        {
            if (!framePicker.Focused)
            {
                if (framePicker.SelectedIndex + change < 0)
                {
                    framePicker.SelectedIndex = framePicker.Items.Count - 1;
                    return;
                }
                else if (framePicker.SelectedIndex + change >= framePicker.Items.Count - 1)
                {
                    framePicker.SelectedIndex = 0;
                    return;
                }
                framePicker.SelectedIndex = framePicker.SelectedIndex + change;
            }

        }

        public void keyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Insert:
                    lStr++;
                    paintDataByMode();
                    break;
                case Keys.Delete:
                    lStr--;
                    paintDataByMode();
                    break;
                case Keys.Add:
                    PlusSize();
                    break;
                case Keys.Subtract:
                    MinusSize();
                    break;
                case Keys.Down:
                    Change_Frame(1);
                    break;
                case Keys.Up:
                    Change_Frame(-1);
                    break;
                default:
                    break;
            }
        }



        private void mainPanel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Insert:
                    lStr++;
                    paintDataByMode();
                    break;
                case Keys.Delete:
                    lStr--;
                    paintDataByMode();
                    break;
                case Keys.Add:
                    PlusSize();
                    break;
                case Keys.Subtract:
                    MinusSize();
                    break;
                default:
                    break;
            }

        }


        private void mainPanel_DragEnter(object sender, DragEventArgs e)
        {
            /*
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
                var fileName = (string[])e.Data.GetData(DataFormats.FileDrop);
                Console.WriteLine("Вы хотите загрузить файл " + fileName[0] + "?");
            }*/
        }

        private void mainPanel_DragDrop(object sender, DragEventArgs e)
        {

        }


        private void dataTable_SearchForVirtualItem(object sender, SearchForVirtualItemEventArgs e)
        {
            
        }

        private void dataTable_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            var item = new ListViewItem();
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                item.SubItems.Add(showArray[e.ItemIndex].ToString());
            }
            
            e.Item = item;
        }

        
    }
}
