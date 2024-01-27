using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BaseModule;

using System.Threading;

namespace PackageAnalyzerModule
{

    public partial class MainForm : Form, IHost
    {
        private class ArrayBorders
        {
            public string path;
            public long start;
            public long end;

            public ArrayBorders(string _path, long _start, long _end)
            {
                path = _path;
                start = _start;
                end = _end;
            }
        }

        private Bitmap bitmap;
        private byte[] showArray;
        private byte[] startArray;
        private byte[] proceseedArray;
        private byte[] syncArray;
        private int counter = 0;
        public int lStr = 1060;
        private byte[] marker = { 0, 1, 1, 1, 0, 0, 1, 1, 0, 1, 1, 1, 0, 0, 1, 1 };
        private Image currentImage = null;

        private static int ModuleCounter = 0;
        private ModuleManager mm = new ModuleManager();
        private bool showSwipe = true;

        public MainForm()
        {
            InitializeComponent();
            
            Icon = Resources.PackageAnalyzerIcon;
            mm.ScanModules(Directory.GetCurrentDirectory() + "\\Modules\\");
            string[] modules = new string[mm.modules.Count];
            modulesTabControl.TabPages.Clear();
            modulesTabControl.ImageList = PageIcons;
            TabPage tabPage = null;
            int i = 0;
            tabsTree.NodeMouseClick += TabsTree_NodeMouseClick;
            tabsTree.ImageList = PageIcons;
            foreach (var item in mm.modules)
            {
                modules.SetValue(item.moduleName, i);
                var node = tabsTree.Nodes.Add(item.moduleName, item.moduleName);
                node.ImageIndex = i;
                node.ContextMenuStrip = contextTreeMenu;
                if (!(item is Internal))
                {
                    tabPage = new TabPage(item.moduleName);
                    tabPage.Name = item.moduleName;
                    tabPage.AllowDrop = true;
                    tabPage.ImageIndex = ModuleCounter;
                    PageIcons.Images.Add(item.icon);
                    modulesTabControl.TabPages.Add(tabPage);
                    
                }
                else
                {
                    tabPage = null;
                }
                item.Run(this);
                if (item.moduleName == "Справка")
                {
                    byte[] temp = new byte[0];
                    item.Proceed(ref temp, modules);
                }
                try
                {
                    var panel = tabPage.Controls.Find("mainPanel", true)[0];
                    panel.DragEnter += Drag_Enter;
                    panel.DragDrop += Drag_Drop;
                    panel.DragLeave += Drag_Leave; ;
                }
                catch
                {

                }
                i++; 
            }

        }

        private void TabsTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tabsTree.SelectedNode = e.Node;
        }

        public MainForm(string[] args) : this()
        {
            if (args.Length > 0)
            {
                FileStream fileStream = new FileStream(args[0], FileMode.Open, FileAccess.Read);
                showArray = new byte[fileStream.Length * 8];
                readFile(fileStream);
                ProceedAllModules();
            }

        }


        private void TabPage_DragEnter(object sender, DragEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void AddControlToMainForm(Control ctrl)
        {
            this.modulesTabControl.TabPages[ModuleCounter++].Controls.Add(ctrl);
        }


        private void readFile(Object _fileStream)
        {
            var t = DateTime.Now;
            FileStream fileStream = (FileStream)_fileStream;
            string fileName = fileStream.Name;
            int proccesorsCount = Environment.ProcessorCount;
            long start = 0;
            long end = fileStream.Length / proccesorsCount;
            fileStream.Close();
            ThreadPool.SetMaxThreads(proccesorsCount, proccesorsCount);

            Thread[] threads = new Thread[proccesorsCount];

            long _end = end;
            
            for (int i = 0; i < proccesorsCount; i++)
            {
                start = end * i;
                _end = end * (i + 1);
                ArrayBorders borders = new ArrayBorders(fileName, start, _end);
                ThreadPool.QueueUserWorkItem(_readFile, borders);
            }
            

            /*
            for (int i = 0; i < proccesorsCount; i++)
            {
                start = end * i;
                _end = end * (i + 1);
                ArrayBorders borders = new ArrayBorders(fileName, start, _end);
                threads[i] = new Thread(() => _readFile(borders));
                threads[i].Name = "Поток №" + i;
                threads[i].Start();
                //Thread.Sleep(10);
            }

            for (int i = 0; i < proccesorsCount; i++)
            {
                threads[i].Join();
            }
            */
            /*
            Thread readThread = new Thread(() => _readFile(fileName, 0, fileStream.Length));
            readThread.Start();
            readThread.Join();
            fileStream.Close();*/
            Console.WriteLine("Файл считан за: " + (DateTime.Now - t));

        }

        private void _readFile(string path, long start, long end)
        {
            long _start = start;
            long _end = end;
            /*Console.WriteLine(Thread.CurrentThread.Name);
            Console.WriteLine("start index: " + start);
            Console.WriteLine("end index: " + end);*/
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            fileStream.Seek(_start, SeekOrigin.Current);
            int temp;
            long _counter = _start * 8;
            //fileStream.Seek(start, SeekOrigin.Current);

            for (long i = _start; i < _end; i++)
            {
                temp = fileStream.ReadByte();
                for (int j = 0; j < 8; j++)
                {
                    //byte _b = (byte)((temp >> j) & 1);
                    showArray[_counter] =  Convert.ToByte((temp >> j) & 0b1);
                    _counter++;
                }
            }
            fileStream.Close();
        }

        private void _readFile(object borders)
        {
            ArrayBorders _borders = (ArrayBorders)borders;
            _readFile(_borders.path, _borders.start, _borders.end);
        }

        private void ProceedAllModules()
        {
            for (int i = 0; i < mm.modules.Count - 1; i++)
            {
                mm.modules[i].Proceed(ref showArray, "1060");
            }
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
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
            ProceedAllModules();
            ofd.Dispose();

        }

        public void AddMenuStripToMainForm(ToolStripMenuItem menuItem, string key)
        {
            ToolStripMenuItem item = null;
            try
            {
                item = menuStrip1.Items.Find(key, true)[0] as ToolStripMenuItem;
            }
            catch
            {

            }

            if (item != null)
            {
                item.DropDownItems.Add(menuItem);
            }
            else
            {
                menuStrip1.Items.Add(menuItem);
            }
        }



        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void AddNewMenuStripToMainForm(ToolStripMenuItem parentWithChildsItem)
        {
            menuStrip1.Items.Add(parentWithChildsItem);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("keydown");
        }

        private void modulesTabControl_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void modulesTabControl_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void modulesTabControl_DragDrop(object sender, DragEventArgs e)
        {

        }


        public void Drag_Enter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                Panel panel = (Panel)sender;
                PictureBox img = (PictureBox)panel.Controls.Find("paintBox", true)[0];
                img.Size = new Size(Convert.ToInt32(Size.Width * 0.8), Convert.ToInt32(Size.Height * 0.8));
                img.SizeMode = PictureBoxSizeMode.Zoom;
                if (img.Image != null)
                {
                    currentImage = (Image)img.Image.Clone();
                }
                img.Image = Resources.DropFilesHere;
                e.Effect = DragDropEffects.All;
                var fileData = (string[])e.Data.GetData(DataFormats.FileDrop);
            }
        }

        public void Drag_Drop(object sender, DragEventArgs e)
        {
            Panel panel = (Panel)sender;
            PictureBox img = (PictureBox)panel.Controls.Find("paintBox", true)[0];
            img.SizeMode = PictureBoxSizeMode.AutoSize;
            img.Image = null;
            string[] fileData = (string[])e.Data.GetData(DataFormats.FileDrop);
            FileStream fileStream = new FileStream(fileData[0], FileMode.Open, FileAccess.Read);
            showArray = new byte[fileStream.Length * 8];
            readFile(fileStream);
            ProceedAllModules();
        }

        public void Drag_Leave(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            PictureBox img = (PictureBox)panel.Controls.Find("paintBox", true)[0];
            img.Image = (currentImage != null) ? currentImage : null;
            img.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
        }

        private void tabPage_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void showSwipePanel()
        {
            showTimer.Start();
            SwipeButton.Text = "<<";
        }

        private void hideSwipePanel()
        {
            hideTimer.Start();
            SwipeButton.Text = ">>";
        }

        private void ShowHideSwipePanel()
        {
            if (showSwipe)
            {
                showSwipePanel();
            }
            else
            {
                hideSwipePanel();
            }
        }

        private void SwipeButton_Click(object sender, EventArgs e)
        {
            ShowHideSwipePanel();
        }



        private void showTimer_Tick(object sender, EventArgs e)
        {
            if (SwipePanel.Width <= 300)
            {
                SwipePanel.Width += SwipePanel.Width / 8;
            }
            else
            {
                if (showTimer.Enabled)
                {
                    showSwipe = false;
                    showTimer.Stop();
                    modulesTabControl.Enabled = false;
                    tabsPanel.Visible = true;
                }
            }
        }

        private void hideTimer_Tick(object sender, EventArgs e)
        {
           
            if (SwipePanel.Width > 96)
            {
                SwipePanel.Width -= SwipePanel.Width / 8;
            }
            else
            {
                if (hideTimer.Enabled)
                {
                    showSwipe = true;
                    hideTimer.Stop();
                    modulesTabControl.Enabled = true;
                    tabsPanel.Visible = false;
                }
            }
        }

        private void tabsTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void moduleInfo_Click(object sender, EventArgs e)
        {
            IModule _moduleData = mm.modules.Find(x => x.moduleName.Equals(tabsTree.SelectedNode.Name));
            MessageBox.Show(this, _moduleData.moduleName, 
                _moduleData.moduleDesc + Environment.NewLine + _moduleData.moduleVersion, 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
