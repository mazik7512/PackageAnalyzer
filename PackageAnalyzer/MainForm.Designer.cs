namespace PackageAnalyzer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бинарныйРежимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графическийРежимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обработка10ст8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обработка9ст7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обработка11ст8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кадроваяСинхронизацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сбросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уменьшитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.периодСтрокиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синхрогруппаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.потокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьПотокКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перевестиВТекстИСохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.BinaryStructure = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextBinaryStructure = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HexArrayButton = new System.Windows.Forms.Button();
            this.DecimalArrayButton = new System.Windows.Forms.Button();
            this.BinaryArrayButton = new System.Windows.Forms.Button();
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.PackageAnalyze = new System.Windows.Forms.TabPage();
            this.NMEAarrayComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AnalyzeMode = new System.Windows.Forms.CheckBox();
            this.showMapButton = new System.Windows.Forms.Button();
            this.DataGroupBox = new System.Windows.Forms.GroupBox();
            this.NmeaGroupBox = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.NMEACheckTextBox = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.NMEAModeTextBox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.NMEADateTextBox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.NMEAFlowDirectionTextBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.NMEASpeedTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.NMEATimeTextBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.NMEADirectionTextBox1 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.NMEALongtitudeTextBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.NMEADirectionTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.NMEALatitudeTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.NMEAIDTextBox = new System.Windows.Forms.TextBox();
            this.DATABlockCallSign = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.UDPGroupBox = new System.Windows.Forms.GroupBox();
            this.UDPHeaderCheckSumTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.UDPHeaderLengthTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.UDPHeaderDestinationPortTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.UDPHeaderSourcePortTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.IPgroupBox = new System.Windows.Forms.GroupBox();
            this.IPHeaderDestinationIPTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.IPHeaderSourceIPTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.IPHeaderCheckSumTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.IPHeaderProtocolTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.IPHeaderTtlTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.IPHeaderFragmentOffsetTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.IPHeaderFlagsListBox = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IPHeaderIDTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IPHeaderTotalLengthTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IPHeaderTosTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IPHeaderLengthTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IPHeaderVersionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.BinaryStructure.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TextBinaryStructure.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PackageAnalyze.SuspendLayout();
            this.DataGroupBox.SuspendLayout();
            this.NmeaGroupBox.SuspendLayout();
            this.UDPGroupBox.SuspendLayout();
            this.IPgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.потокToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФайлToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Image = global::PackageAnalyzer.Resources.FileOpen;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бинарныйРежимToolStripMenuItem});
            this.открытьФайлToolStripMenuItem.Image = global::PackageAnalyzer.Resources.FileOpen1;
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.открытьФайлToolStripMenuItem.Text = "Открыть файл...";
            // 
            // бинарныйРежимToolStripMenuItem
            // 
            this.бинарныйРежимToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("бинарныйРежимToolStripMenuItem.Image")));
            this.бинарныйРежимToolStripMenuItem.Name = "бинарныйРежимToolStripMenuItem";
            this.бинарныйРежимToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.бинарныйРежимToolStripMenuItem.Text = "Бинарный режим";
            this.бинарныйРежимToolStripMenuItem.Click += new System.EventHandler(this.бинарныйРежимToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = global::PackageAnalyzer.Resources.Exit;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.графическийРежимToolStripMenuItem,
            this.фильтрацияToolStripMenuItem,
            this.размерыToolStripMenuItem,
            this.периодСтрокиToolStripMenuItem,
            this.синхрогруппаToolStripMenuItem});
            this.настройкиToolStripMenuItem.Image = global::PackageAnalyzer.Resources.Settings;
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // графическийРежимToolStripMenuItem
            // 
            this.графическийРежимToolStripMenuItem.Checked = true;
            this.графическийРежимToolStripMenuItem.CheckOnClick = true;
            this.графическийРежимToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.графическийРежимToolStripMenuItem.Image = global::PackageAnalyzer.Resources.GraphMode;
            this.графическийРежимToolStripMenuItem.Name = "графическийРежимToolStripMenuItem";
            this.графическийРежимToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.графическийРежимToolStripMenuItem.Text = "Графический режим";
            this.графическийРежимToolStripMenuItem.ToolTipText = "Переключатель (графический/текстовый режимы)";
            this.графическийРежимToolStripMenuItem.Click += new System.EventHandler(this.графическийРежимToolStripMenuItem_Click);
            // 
            // фильтрацияToolStripMenuItem
            // 
            this.фильтрацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обработка10ст8ToolStripMenuItem,
            this.обработка9ст7ToolStripMenuItem,
            this.обработка11ст8ToolStripMenuItem,
            this.кадроваяСинхронизацияToolStripMenuItem,
            this.сбросToolStripMenuItem});
            this.фильтрацияToolStripMenuItem.Image = global::PackageAnalyzer.Resources.Filter;
            this.фильтрацияToolStripMenuItem.Name = "фильтрацияToolStripMenuItem";
            this.фильтрацияToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.фильтрацияToolStripMenuItem.Text = "Фильтрация";
            // 
            // обработка10ст8ToolStripMenuItem
            // 
            this.обработка10ст8ToolStripMenuItem.CheckOnClick = true;
            this.обработка10ст8ToolStripMenuItem.Image = global::PackageAnalyzer.Resources._10_8;
            this.обработка10ст8ToolStripMenuItem.Name = "обработка10ст8ToolStripMenuItem";
            this.обработка10ст8ToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.обработка10ст8ToolStripMenuItem.Text = "Обработка 10ст8";
            this.обработка10ст8ToolStripMenuItem.Click += new System.EventHandler(this.обработка10ст8ToolStripMenuItem_Click);
            // 
            // обработка9ст7ToolStripMenuItem
            // 
            this.обработка9ст7ToolStripMenuItem.Image = global::PackageAnalyzer.Resources._9_7;
            this.обработка9ст7ToolStripMenuItem.Name = "обработка9ст7ToolStripMenuItem";
            this.обработка9ст7ToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.обработка9ст7ToolStripMenuItem.Text = "Обработка 9ст7";
            this.обработка9ст7ToolStripMenuItem.Click += new System.EventHandler(this.обработка9ст7ToolStripMenuItem_Click);
            // 
            // обработка11ст8ToolStripMenuItem
            // 
            this.обработка11ст8ToolStripMenuItem.Image = global::PackageAnalyzer.Resources._11;
            this.обработка11ст8ToolStripMenuItem.Name = "обработка11ст8ToolStripMenuItem";
            this.обработка11ст8ToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.обработка11ст8ToolStripMenuItem.Text = "Обработка 11ст8";
            this.обработка11ст8ToolStripMenuItem.Click += new System.EventHandler(this.обработка11ст8ToolStripMenuItem_Click);
            // 
            // кадроваяСинхронизацияToolStripMenuItem
            // 
            this.кадроваяСинхронизацияToolStripMenuItem.CheckOnClick = true;
            this.кадроваяСинхронизацияToolStripMenuItem.Image = global::PackageAnalyzer.Resources.FrameSync;
            this.кадроваяСинхронизацияToolStripMenuItem.Name = "кадроваяСинхронизацияToolStripMenuItem";
            this.кадроваяСинхронизацияToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.кадроваяСинхронизацияToolStripMenuItem.Text = "Кадровая синхронизация";
            this.кадроваяСинхронизацияToolStripMenuItem.Click += new System.EventHandler(this.кадроваяСинхронизацияToolStripMenuItem_Click);
            // 
            // сбросToolStripMenuItem
            // 
            this.сбросToolStripMenuItem.Image = global::PackageAnalyzer.Resources.Reset;
            this.сбросToolStripMenuItem.Name = "сбросToolStripMenuItem";
            this.сбросToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.сбросToolStripMenuItem.Text = "Сброс";
            this.сбросToolStripMenuItem.Click += new System.EventHandler(this.сбросToolStripMenuItem_Click);
            // 
            // размерыToolStripMenuItem
            // 
            this.размерыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.увеличитьToolStripMenuItem,
            this.уменьшитьToolStripMenuItem});
            this.размерыToolStripMenuItem.Image = global::PackageAnalyzer.Resources.Size;
            this.размерыToolStripMenuItem.Name = "размерыToolStripMenuItem";
            this.размерыToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.размерыToolStripMenuItem.Text = "Размеры";
            // 
            // увеличитьToolStripMenuItem
            // 
            this.увеличитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("увеличитьToolStripMenuItem.Image")));
            this.увеличитьToolStripMenuItem.Name = "увеличитьToolStripMenuItem";
            this.увеличитьToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.увеличитьToolStripMenuItem.Text = "Увеличить";
            this.увеличитьToolStripMenuItem.Click += new System.EventHandler(this.увеличитьToolStripMenuItem_Click);
            // 
            // уменьшитьToolStripMenuItem
            // 
            this.уменьшитьToolStripMenuItem.Image = global::PackageAnalyzer.Resources.MinusSize;
            this.уменьшитьToolStripMenuItem.Name = "уменьшитьToolStripMenuItem";
            this.уменьшитьToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.уменьшитьToolStripMenuItem.Text = "Уменьшить";
            this.уменьшитьToolStripMenuItem.Click += new System.EventHandler(this.уменьшитьToolStripMenuItem_Click);
            // 
            // периодСтрокиToolStripMenuItem
            // 
            this.периодСтрокиToolStripMenuItem.Image = global::PackageAnalyzer.Resources.Period;
            this.периодСтрокиToolStripMenuItem.Name = "периодСтрокиToolStripMenuItem";
            this.периодСтрокиToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.периодСтрокиToolStripMenuItem.Text = "Период строки";
            this.периодСтрокиToolStripMenuItem.Click += new System.EventHandler(this.периодСтрокиToolStripMenuItem_Click);
            // 
            // синхрогруппаToolStripMenuItem
            // 
            this.синхрогруппаToolStripMenuItem.Image = global::PackageAnalyzer.Resources.SyncGroup;
            this.синхрогруппаToolStripMenuItem.Name = "синхрогруппаToolStripMenuItem";
            this.синхрогруппаToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.синхрогруппаToolStripMenuItem.Text = "Синхрогруппа";
            this.синхрогруппаToolStripMenuItem.Click += new System.EventHandler(this.синхрогруппаToolStripMenuItem_Click);
            // 
            // потокToolStripMenuItem
            // 
            this.потокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьПотокКакToolStripMenuItem,
            this.перевестиВТекстИСохранитьToolStripMenuItem});
            this.потокToolStripMenuItem.Image = global::PackageAnalyzer.Resources.Stream;
            this.потокToolStripMenuItem.Name = "потокToolStripMenuItem";
            this.потокToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.потокToolStripMenuItem.Text = "Поток";
            // 
            // сохранитьПотокКакToolStripMenuItem
            // 
            this.сохранитьПотокКакToolStripMenuItem.Image = global::PackageAnalyzer.Resources.SaveStream;
            this.сохранитьПотокКакToolStripMenuItem.Name = "сохранитьПотокКакToolStripMenuItem";
            this.сохранитьПотокКакToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.сохранитьПотокКакToolStripMenuItem.Text = "Сохранить поток как...";
            this.сохранитьПотокКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьПотокКакToolStripMenuItem_Click);
            // 
            // перевестиВТекстИСохранитьToolStripMenuItem
            // 
            this.перевестиВТекстИСохранитьToolStripMenuItem.Image = global::PackageAnalyzer.Resources.SaveText;
            this.перевестиВТекстИСохранитьToolStripMenuItem.Name = "перевестиВТекстИСохранитьToolStripMenuItem";
            this.перевестиВТекстИСохранитьToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.перевестиВТекстИСохранитьToolStripMenuItem.Text = "Перевести в текст и сохранить...";
            this.перевестиВТекстИСохранитьToolStripMenuItem.Click += new System.EventHandler(this.перевестиВТекстИСохранитьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Image = global::PackageAnalyzer.Resources.Info;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::PackageAnalyzer.Resources.About;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click_1);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.BinaryStructure);
            this.tabControl.Controls.Add(this.TextBinaryStructure);
            this.tabControl.Controls.Add(this.PackageAnalyze);
            this.tabControl.HotTrack = true;
            this.tabControl.ImageList = this.imageList1;
            this.tabControl.Location = new System.Drawing.Point(13, 33);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(871, 563);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // BinaryStructure
            // 
            this.BinaryStructure.AllowDrop = true;
            this.BinaryStructure.Controls.Add(this.panel1);
            this.BinaryStructure.ImageIndex = 0;
            this.BinaryStructure.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BinaryStructure.Location = new System.Drawing.Point(4, 23);
            this.BinaryStructure.Name = "BinaryStructure";
            this.BinaryStructure.Padding = new System.Windows.Forms.Padding(3);
            this.BinaryStructure.Size = new System.Drawing.Size(863, 536);
            this.BinaryStructure.TabIndex = 0;
            this.BinaryStructure.Text = "Графическое отображение";
            this.BinaryStructure.ToolTipText = "Структура пакета";
            this.BinaryStructure.UseVisualStyleBackColor = true;
            this.BinaryStructure.DragEnter += new System.Windows.Forms.DragEventHandler(this.BinaryStructure_DragEnter);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 523);
            this.panel1.TabIndex = 1;
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(827, 509);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // TextBinaryStructure
            // 
            this.TextBinaryStructure.Controls.Add(this.panel2);
            this.TextBinaryStructure.ImageIndex = 2;
            this.TextBinaryStructure.Location = new System.Drawing.Point(4, 23);
            this.TextBinaryStructure.Name = "TextBinaryStructure";
            this.TextBinaryStructure.Size = new System.Drawing.Size(863, 536);
            this.TextBinaryStructure.TabIndex = 2;
            this.TextBinaryStructure.Text = "Текстовое отображение";
            this.TextBinaryStructure.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.DataTextBox);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 508);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HexArrayButton);
            this.groupBox1.Controls.Add(this.DecimalArrayButton);
            this.groupBox1.Controls.Add(this.BinaryArrayButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отображение";
            // 
            // HexArrayButton
            // 
            this.HexArrayButton.Location = new System.Drawing.Point(75, 19);
            this.HexArrayButton.Name = "HexArrayButton";
            this.HexArrayButton.Size = new System.Drawing.Size(161, 23);
            this.HexArrayButton.TabIndex = 2;
            this.HexArrayButton.Text = "Шестнадцетеричные данные";
            this.HexArrayButton.UseVisualStyleBackColor = true;
            this.HexArrayButton.Click += new System.EventHandler(this.HexArrayButton_Click);
            // 
            // DecimalArrayButton
            // 
            this.DecimalArrayButton.Location = new System.Drawing.Point(167, 48);
            this.DecimalArrayButton.Name = "DecimalArrayButton";
            this.DecimalArrayButton.Size = new System.Drawing.Size(133, 23);
            this.DecimalArrayButton.TabIndex = 1;
            this.DecimalArrayButton.Text = "Десятичные данные";
            this.DecimalArrayButton.UseVisualStyleBackColor = true;
            this.DecimalArrayButton.Click += new System.EventHandler(this.DecimalArrayButton_Click);
            // 
            // BinaryArrayButton
            // 
            this.BinaryArrayButton.BackColor = System.Drawing.Color.Transparent;
            this.BinaryArrayButton.FlatAppearance.BorderSize = 0;
            this.BinaryArrayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BinaryArrayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orchid;
            this.BinaryArrayButton.Location = new System.Drawing.Point(6, 48);
            this.BinaryArrayButton.Name = "BinaryArrayButton";
            this.BinaryArrayButton.Size = new System.Drawing.Size(133, 23);
            this.BinaryArrayButton.TabIndex = 0;
            this.BinaryArrayButton.Text = "Двоиные данные";
            this.BinaryArrayButton.UseVisualStyleBackColor = false;
            this.BinaryArrayButton.Click += new System.EventHandler(this.BinaryArrayButton_Click);
            // 
            // DataTextBox
            // 
            this.DataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataTextBox.Location = new System.Drawing.Point(3, 93);
            this.DataTextBox.MaxLength = 999999;
            this.DataTextBox.Multiline = true;
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.ReadOnly = true;
            this.DataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DataTextBox.Size = new System.Drawing.Size(850, 398);
            this.DataTextBox.TabIndex = 0;
            // 
            // PackageAnalyze
            // 
            this.PackageAnalyze.Controls.Add(this.NMEAarrayComboBox);
            this.PackageAnalyze.Controls.Add(this.label1);
            this.PackageAnalyze.Controls.Add(this.AnalyzeMode);
            this.PackageAnalyze.Controls.Add(this.showMapButton);
            this.PackageAnalyze.Controls.Add(this.DataGroupBox);
            this.PackageAnalyze.Controls.Add(this.UDPGroupBox);
            this.PackageAnalyze.Controls.Add(this.IPgroupBox);
            this.PackageAnalyze.ImageIndex = 1;
            this.PackageAnalyze.Location = new System.Drawing.Point(4, 23);
            this.PackageAnalyze.Name = "PackageAnalyze";
            this.PackageAnalyze.Padding = new System.Windows.Forms.Padding(3);
            this.PackageAnalyze.Size = new System.Drawing.Size(863, 536);
            this.PackageAnalyze.TabIndex = 1;
            this.PackageAnalyze.Text = "NMEA-Анализ";
            this.PackageAnalyze.UseVisualStyleBackColor = true;
            // 
            // NMEAarrayComboBox
            // 
            this.NMEAarrayComboBox.FormattingEnabled = true;
            this.NMEAarrayComboBox.Location = new System.Drawing.Point(299, 17);
            this.NMEAarrayComboBox.Name = "NMEAarrayComboBox";
            this.NMEAarrayComboBox.Size = new System.Drawing.Size(205, 21);
            this.NMEAarrayComboBox.TabIndex = 8;
            this.NMEAarrayComboBox.SelectedIndexChanged += new System.EventHandler(this.NMEAarrayComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Найденные пакеты:";
            // 
            // AnalyzeMode
            // 
            this.AnalyzeMode.AutoSize = true;
            this.AnalyzeMode.Location = new System.Drawing.Point(21, 21);
            this.AnalyzeMode.Name = "AnalyzeMode";
            this.AnalyzeMode.Size = new System.Drawing.Size(114, 17);
            this.AnalyzeMode.TabIndex = 6;
            this.AnalyzeMode.Text = "Включить анализ";
            this.AnalyzeMode.UseVisualStyleBackColor = true;
            this.AnalyzeMode.CheckedChanged += new System.EventHandler(this.AnalyzeMode_CheckedChanged);
            // 
            // showMapButton
            // 
            this.showMapButton.Enabled = false;
            this.showMapButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showMapButton.Location = new System.Drawing.Point(707, 21);
            this.showMapButton.Name = "showMapButton";
            this.showMapButton.Size = new System.Drawing.Size(139, 23);
            this.showMapButton.TabIndex = 5;
            this.showMapButton.Text = "Показать на карте";
            this.showMapButton.UseVisualStyleBackColor = true;
            this.showMapButton.Click += new System.EventHandler(this.showMapButton_Click);
            // 
            // DataGroupBox
            // 
            this.DataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGroupBox.Controls.Add(this.NmeaGroupBox);
            this.DataGroupBox.Controls.Add(this.DATABlockCallSign);
            this.DataGroupBox.Controls.Add(this.label19);
            this.DataGroupBox.Enabled = false;
            this.DataGroupBox.Location = new System.Drawing.Point(21, 281);
            this.DataGroupBox.Name = "DataGroupBox";
            this.DataGroupBox.Size = new System.Drawing.Size(825, 222);
            this.DataGroupBox.TabIndex = 4;
            this.DataGroupBox.TabStop = false;
            this.DataGroupBox.Text = "Блок данных";
            // 
            // NmeaGroupBox
            // 
            this.NmeaGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NmeaGroupBox.Controls.Add(this.label29);
            this.NmeaGroupBox.Controls.Add(this.NMEACheckTextBox);
            this.NmeaGroupBox.Controls.Add(this.label28);
            this.NmeaGroupBox.Controls.Add(this.NMEAModeTextBox);
            this.NmeaGroupBox.Controls.Add(this.label26);
            this.NmeaGroupBox.Controls.Add(this.NMEADateTextBox);
            this.NmeaGroupBox.Controls.Add(this.label25);
            this.NmeaGroupBox.Controls.Add(this.NMEAFlowDirectionTextBox);
            this.NmeaGroupBox.Controls.Add(this.label22);
            this.NmeaGroupBox.Controls.Add(this.NMEASpeedTextBox);
            this.NmeaGroupBox.Controls.Add(this.label21);
            this.NmeaGroupBox.Controls.Add(this.NMEATimeTextBox);
            this.NmeaGroupBox.Controls.Add(this.label24);
            this.NmeaGroupBox.Controls.Add(this.NMEADirectionTextBox1);
            this.NmeaGroupBox.Controls.Add(this.label27);
            this.NmeaGroupBox.Controls.Add(this.NMEALongtitudeTextBox);
            this.NmeaGroupBox.Controls.Add(this.label23);
            this.NmeaGroupBox.Controls.Add(this.NMEADirectionTextBox);
            this.NmeaGroupBox.Controls.Add(this.label20);
            this.NmeaGroupBox.Controls.Add(this.NMEALatitudeTextBox);
            this.NmeaGroupBox.Controls.Add(this.label18);
            this.NmeaGroupBox.Controls.Add(this.NMEAIDTextBox);
            this.NmeaGroupBox.Location = new System.Drawing.Point(10, 58);
            this.NmeaGroupBox.Name = "NmeaGroupBox";
            this.NmeaGroupBox.Size = new System.Drawing.Size(809, 158);
            this.NmeaGroupBox.TabIndex = 36;
            this.NmeaGroupBox.TabStop = false;
            this.NmeaGroupBox.Text = "Протокол NMEA";
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(541, 132);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(129, 13);
            this.label29.TabIndex = 60;
            this.label29.Text = "Достоверность данных:";
            // 
            // NMEACheckTextBox
            // 
            this.NMEACheckTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NMEACheckTextBox.Location = new System.Drawing.Point(676, 129);
            this.NMEACheckTextBox.Name = "NMEACheckTextBox";
            this.NMEACheckTextBox.ReadOnly = true;
            this.NMEACheckTextBox.Size = new System.Drawing.Size(127, 20);
            this.NMEACheckTextBox.TabIndex = 61;
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(541, 104);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(108, 13);
            this.label28.TabIndex = 58;
            this.label28.Text = "Индикатор режима:";
            // 
            // NMEAModeTextBox
            // 
            this.NMEAModeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NMEAModeTextBox.Location = new System.Drawing.Point(655, 101);
            this.NMEAModeTextBox.Name = "NMEAModeTextBox";
            this.NMEAModeTextBox.ReadOnly = true;
            this.NMEAModeTextBox.Size = new System.Drawing.Size(148, 20);
            this.NMEAModeTextBox.TabIndex = 59;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(125, 72);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(89, 13);
            this.label26.TabIndex = 56;
            this.label26.Text = "Дата фиксации:";
            // 
            // NMEADateTextBox
            // 
            this.NMEADateTextBox.Location = new System.Drawing.Point(227, 69);
            this.NMEADateTextBox.Name = "NMEADateTextBox";
            this.NMEADateTextBox.ReadOnly = true;
            this.NMEADateTextBox.Size = new System.Drawing.Size(165, 20);
            this.NMEADateTextBox.TabIndex = 57;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(413, 46);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(125, 13);
            this.label25.TabIndex = 54;
            this.label25.Text = "Напраление движения:";
            // 
            // NMEAFlowDirectionTextBox
            // 
            this.NMEAFlowDirectionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NMEAFlowDirectionTextBox.Location = new System.Drawing.Point(544, 43);
            this.NMEAFlowDirectionTextBox.Name = "NMEAFlowDirectionTextBox";
            this.NMEAFlowDirectionTextBox.ReadOnly = true;
            this.NMEAFlowDirectionTextBox.Size = new System.Drawing.Size(112, 20);
            this.NMEAFlowDirectionTextBox.TabIndex = 55;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(125, 46);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 13);
            this.label22.TabIndex = 52;
            this.label22.Text = "Скорость(узлов):";
            // 
            // NMEASpeedTextBox
            // 
            this.NMEASpeedTextBox.Location = new System.Drawing.Point(227, 43);
            this.NMEASpeedTextBox.Name = "NMEASpeedTextBox";
            this.NMEASpeedTextBox.ReadOnly = true;
            this.NMEASpeedTextBox.Size = new System.Drawing.Size(86, 20);
            this.NMEASpeedTextBox.TabIndex = 53;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(413, 72);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 13);
            this.label21.TabIndex = 50;
            this.label21.Text = "Время фиксации:";
            // 
            // NMEATimeTextBox
            // 
            this.NMEATimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NMEATimeTextBox.Location = new System.Drawing.Point(515, 69);
            this.NMEATimeTextBox.Name = "NMEATimeTextBox";
            this.NMEATimeTextBox.ReadOnly = true;
            this.NMEATimeTextBox.Size = new System.Drawing.Size(165, 20);
            this.NMEATimeTextBox.TabIndex = 51;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(253, 138);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(84, 13);
            this.label24.TabIndex = 48;
            this.label24.Text = "Сторона света:";
            // 
            // NMEADirectionTextBox1
            // 
            this.NMEADirectionTextBox1.Location = new System.Drawing.Point(343, 135);
            this.NMEADirectionTextBox1.Name = "NMEADirectionTextBox1";
            this.NMEADirectionTextBox1.ReadOnly = true;
            this.NMEADirectionTextBox1.Size = new System.Drawing.Size(68, 20);
            this.NMEADirectionTextBox1.TabIndex = 49;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(253, 104);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 13);
            this.label27.TabIndex = 42;
            this.label27.Text = "Долгота:";
            // 
            // NMEALongtitudeTextBox
            // 
            this.NMEALongtitudeTextBox.Location = new System.Drawing.Point(307, 101);
            this.NMEALongtitudeTextBox.Name = "NMEALongtitudeTextBox";
            this.NMEALongtitudeTextBox.ReadOnly = true;
            this.NMEALongtitudeTextBox.Size = new System.Drawing.Size(174, 20);
            this.NMEALongtitudeTextBox.TabIndex = 43;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 135);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(84, 13);
            this.label23.TabIndex = 40;
            this.label23.Text = "Сторона света:";
            // 
            // NMEADirectionTextBox
            // 
            this.NMEADirectionTextBox.Location = new System.Drawing.Point(98, 132);
            this.NMEADirectionTextBox.Name = "NMEADirectionTextBox";
            this.NMEADirectionTextBox.ReadOnly = true;
            this.NMEADirectionTextBox.Size = new System.Drawing.Size(68, 20);
            this.NMEADirectionTextBox.TabIndex = 41;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 104);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 13);
            this.label20.TabIndex = 34;
            this.label20.Text = "Широта:";
            // 
            // NMEALatitudeTextBox
            // 
            this.NMEALatitudeTextBox.Location = new System.Drawing.Point(62, 101);
            this.NMEALatitudeTextBox.Name = "NMEALatitudeTextBox";
            this.NMEALatitudeTextBox.ReadOnly = true;
            this.NMEALatitudeTextBox.Size = new System.Drawing.Size(165, 20);
            this.NMEALatitudeTextBox.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(265, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "Идентификатор NMEA:";
            // 
            // NMEAIDTextBox
            // 
            this.NMEAIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NMEAIDTextBox.Location = new System.Drawing.Point(397, 13);
            this.NMEAIDTextBox.Name = "NMEAIDTextBox";
            this.NMEAIDTextBox.ReadOnly = true;
            this.NMEAIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.NMEAIDTextBox.TabIndex = 33;
            // 
            // DATABlockCallSign
            // 
            this.DATABlockCallSign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DATABlockCallSign.Location = new System.Drawing.Point(343, 22);
            this.DATABlockCallSign.Name = "DATABlockCallSign";
            this.DATABlockCallSign.ReadOnly = true;
            this.DATABlockCallSign.Size = new System.Drawing.Size(168, 20);
            this.DATABlockCallSign.TabIndex = 35;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(275, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "Позывной:";
            // 
            // UDPGroupBox
            // 
            this.UDPGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UDPGroupBox.Controls.Add(this.UDPHeaderCheckSumTextBox);
            this.UDPGroupBox.Controls.Add(this.label17);
            this.UDPGroupBox.Controls.Add(this.UDPHeaderLengthTextBox);
            this.UDPGroupBox.Controls.Add(this.label16);
            this.UDPGroupBox.Controls.Add(this.UDPHeaderDestinationPortTextBox);
            this.UDPGroupBox.Controls.Add(this.label15);
            this.UDPGroupBox.Controls.Add(this.UDPHeaderSourcePortTextBox);
            this.UDPGroupBox.Controls.Add(this.label14);
            this.UDPGroupBox.Enabled = false;
            this.UDPGroupBox.Location = new System.Drawing.Point(610, 50);
            this.UDPGroupBox.Name = "UDPGroupBox";
            this.UDPGroupBox.Size = new System.Drawing.Size(236, 215);
            this.UDPGroupBox.TabIndex = 3;
            this.UDPGroupBox.TabStop = false;
            this.UDPGroupBox.Text = "UDP-заголовок";
            // 
            // UDPHeaderCheckSumTextBox
            // 
            this.UDPHeaderCheckSumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UDPHeaderCheckSumTextBox.Location = new System.Drawing.Point(78, 171);
            this.UDPHeaderCheckSumTextBox.Name = "UDPHeaderCheckSumTextBox";
            this.UDPHeaderCheckSumTextBox.ReadOnly = true;
            this.UDPHeaderCheckSumTextBox.Size = new System.Drawing.Size(152, 20);
            this.UDPHeaderCheckSumTextBox.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 174);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Чек-сумма:";
            // 
            // UDPHeaderLengthTextBox
            // 
            this.UDPHeaderLengthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UDPHeaderLengthTextBox.Location = new System.Drawing.Point(145, 133);
            this.UDPHeaderLengthTextBox.Name = "UDPHeaderLengthTextBox";
            this.UDPHeaderLengthTextBox.ReadOnly = true;
            this.UDPHeaderLengthTextBox.Size = new System.Drawing.Size(85, 20);
            this.UDPHeaderLengthTextBox.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Длина без IP-заголовка:";
            // 
            // UDPHeaderDestinationPortTextBox
            // 
            this.UDPHeaderDestinationPortTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UDPHeaderDestinationPortTextBox.Location = new System.Drawing.Point(114, 66);
            this.UDPHeaderDestinationPortTextBox.Name = "UDPHeaderDestinationPortTextBox";
            this.UDPHeaderDestinationPortTextBox.ReadOnly = true;
            this.UDPHeaderDestinationPortTextBox.Size = new System.Drawing.Size(116, 20);
            this.UDPHeaderDestinationPortTextBox.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Порт получателя:";
            // 
            // UDPHeaderSourcePortTextBox
            // 
            this.UDPHeaderSourcePortTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UDPHeaderSourcePortTextBox.Location = new System.Drawing.Point(114, 29);
            this.UDPHeaderSourcePortTextBox.Name = "UDPHeaderSourcePortTextBox";
            this.UDPHeaderSourcePortTextBox.ReadOnly = true;
            this.UDPHeaderSourcePortTextBox.Size = new System.Drawing.Size(116, 20);
            this.UDPHeaderSourcePortTextBox.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Порт отправителя:";
            // 
            // IPgroupBox
            // 
            this.IPgroupBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IPgroupBox.Controls.Add(this.IPHeaderDestinationIPTextBox);
            this.IPgroupBox.Controls.Add(this.label13);
            this.IPgroupBox.Controls.Add(this.IPHeaderSourceIPTextBox);
            this.IPgroupBox.Controls.Add(this.label12);
            this.IPgroupBox.Controls.Add(this.IPHeaderCheckSumTextBox);
            this.IPgroupBox.Controls.Add(this.label11);
            this.IPgroupBox.Controls.Add(this.IPHeaderProtocolTextBox);
            this.IPgroupBox.Controls.Add(this.label10);
            this.IPgroupBox.Controls.Add(this.IPHeaderTtlTextBox);
            this.IPgroupBox.Controls.Add(this.label9);
            this.IPgroupBox.Controls.Add(this.IPHeaderFragmentOffsetTextBox);
            this.IPgroupBox.Controls.Add(this.label8);
            this.IPgroupBox.Controls.Add(this.IPHeaderFlagsListBox);
            this.IPgroupBox.Controls.Add(this.label7);
            this.IPgroupBox.Controls.Add(this.IPHeaderIDTextBox);
            this.IPgroupBox.Controls.Add(this.label6);
            this.IPgroupBox.Controls.Add(this.IPHeaderTotalLengthTextBox);
            this.IPgroupBox.Controls.Add(this.label5);
            this.IPgroupBox.Controls.Add(this.IPHeaderTosTextBox);
            this.IPgroupBox.Controls.Add(this.label4);
            this.IPgroupBox.Controls.Add(this.IPHeaderLengthTextBox);
            this.IPgroupBox.Controls.Add(this.label3);
            this.IPgroupBox.Controls.Add(this.IPHeaderVersionTextBox);
            this.IPgroupBox.Controls.Add(this.label2);
            this.IPgroupBox.Enabled = false;
            this.IPgroupBox.Location = new System.Drawing.Point(21, 49);
            this.IPgroupBox.Name = "IPgroupBox";
            this.IPgroupBox.Size = new System.Drawing.Size(561, 216);
            this.IPgroupBox.TabIndex = 2;
            this.IPgroupBox.TabStop = false;
            this.IPgroupBox.Text = "IP-заголовок";
            // 
            // IPHeaderDestinationIPTextBox
            // 
            this.IPHeaderDestinationIPTextBox.Location = new System.Drawing.Point(125, 186);
            this.IPHeaderDestinationIPTextBox.Name = "IPHeaderDestinationIPTextBox";
            this.IPHeaderDestinationIPTextBox.ReadOnly = true;
            this.IPHeaderDestinationIPTextBox.Size = new System.Drawing.Size(420, 20);
            this.IPHeaderDestinationIPTextBox.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "IP-адрес назначения:";
            // 
            // IPHeaderSourceIPTextBox
            // 
            this.IPHeaderSourceIPTextBox.Location = new System.Drawing.Point(125, 154);
            this.IPHeaderSourceIPTextBox.Name = "IPHeaderSourceIPTextBox";
            this.IPHeaderSourceIPTextBox.ReadOnly = true;
            this.IPHeaderSourceIPTextBox.Size = new System.Drawing.Size(420, 20);
            this.IPHeaderSourceIPTextBox.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "IP-адрес источника:";
            // 
            // IPHeaderCheckSumTextBox
            // 
            this.IPHeaderCheckSumTextBox.Location = new System.Drawing.Point(352, 117);
            this.IPHeaderCheckSumTextBox.Name = "IPHeaderCheckSumTextBox";
            this.IPHeaderCheckSumTextBox.ReadOnly = true;
            this.IPHeaderCheckSumTextBox.Size = new System.Drawing.Size(193, 20);
            this.IPHeaderCheckSumTextBox.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(234, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Контрольная сумма:";
            // 
            // IPHeaderProtocolTextBox
            // 
            this.IPHeaderProtocolTextBox.Location = new System.Drawing.Point(162, 117);
            this.IPHeaderProtocolTextBox.Name = "IPHeaderProtocolTextBox";
            this.IPHeaderProtocolTextBox.ReadOnly = true;
            this.IPHeaderProtocolTextBox.Size = new System.Drawing.Size(66, 20);
            this.IPHeaderProtocolTextBox.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(99, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Протокол:";
            // 
            // IPHeaderTtlTextBox
            // 
            this.IPHeaderTtlTextBox.Location = new System.Drawing.Point(43, 117);
            this.IPHeaderTtlTextBox.Name = "IPHeaderTtlTextBox";
            this.IPHeaderTtlTextBox.ReadOnly = true;
            this.IPHeaderTtlTextBox.Size = new System.Drawing.Size(56, 20);
            this.IPHeaderTtlTextBox.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "TTL:";
            // 
            // IPHeaderFragmentOffsetTextBox
            // 
            this.IPHeaderFragmentOffsetTextBox.Location = new System.Drawing.Point(469, 67);
            this.IPHeaderFragmentOffsetTextBox.Name = "IPHeaderFragmentOffsetTextBox";
            this.IPHeaderFragmentOffsetTextBox.ReadOnly = true;
            this.IPHeaderFragmentOffsetTextBox.Size = new System.Drawing.Size(76, 20);
            this.IPHeaderFragmentOffsetTextBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Смещение фрагмента:";
            // 
            // IPHeaderFlagsListBox
            // 
            this.IPHeaderFlagsListBox.FormattingEnabled = true;
            this.IPHeaderFlagsListBox.Items.AddRange(new object[] {
            "DF-флаг",
            "MF-флаг"});
            this.IPHeaderFlagsListBox.Location = new System.Drawing.Point(185, 67);
            this.IPHeaderFlagsListBox.Name = "IPHeaderFlagsListBox";
            this.IPHeaderFlagsListBox.Size = new System.Drawing.Size(152, 34);
            this.IPHeaderFlagsListBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Флаги:";
            // 
            // IPHeaderIDTextBox
            // 
            this.IPHeaderIDTextBox.Location = new System.Drawing.Point(72, 67);
            this.IPHeaderIDTextBox.Name = "IPHeaderIDTextBox";
            this.IPHeaderIDTextBox.ReadOnly = true;
            this.IPHeaderIDTextBox.Size = new System.Drawing.Size(57, 20);
            this.IPHeaderIDTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "ID пакета:";
            // 
            // IPHeaderTotalLengthTextBox
            // 
            this.IPHeaderTotalLengthTextBox.Location = new System.Drawing.Point(489, 30);
            this.IPHeaderTotalLengthTextBox.Name = "IPHeaderTotalLengthTextBox";
            this.IPHeaderTotalLengthTextBox.ReadOnly = true;
            this.IPHeaderTotalLengthTextBox.Size = new System.Drawing.Size(56, 20);
            this.IPHeaderTotalLengthTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Общая длина:";
            // 
            // IPHeaderTosTextBox
            // 
            this.IPHeaderTosTextBox.Location = new System.Drawing.Point(343, 30);
            this.IPHeaderTosTextBox.Name = "IPHeaderTosTextBox";
            this.IPHeaderTosTextBox.ReadOnly = true;
            this.IPHeaderTosTextBox.Size = new System.Drawing.Size(56, 20);
            this.IPHeaderTosTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Тип сервиса:";
            // 
            // IPHeaderLengthTextBox
            // 
            this.IPHeaderLengthTextBox.Location = new System.Drawing.Point(201, 30);
            this.IPHeaderLengthTextBox.Name = "IPHeaderLengthTextBox";
            this.IPHeaderLengthTextBox.ReadOnly = true;
            this.IPHeaderLengthTextBox.Size = new System.Drawing.Size(56, 20);
            this.IPHeaderLengthTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Длина заголовка:";
            // 
            // IPHeaderVersionTextBox
            // 
            this.IPHeaderVersionTextBox.Location = new System.Drawing.Point(60, 30);
            this.IPHeaderVersionTextBox.Name = "IPHeaderVersionTextBox";
            this.IPHeaderVersionTextBox.ReadOnly = true;
            this.IPHeaderVersionTextBox.Size = new System.Drawing.Size(32, 20);
            this.IPHeaderVersionTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Версия:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(899, 605);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анализатор пакетов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.BinaryStructure.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TextBinaryStructure.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.PackageAnalyze.ResumeLayout(false);
            this.PackageAnalyze.PerformLayout();
            this.DataGroupBox.ResumeLayout(false);
            this.DataGroupBox.PerformLayout();
            this.NmeaGroupBox.ResumeLayout(false);
            this.NmeaGroupBox.PerformLayout();
            this.UDPGroupBox.ResumeLayout(false);
            this.UDPGroupBox.PerformLayout();
            this.IPgroupBox.ResumeLayout(false);
            this.IPgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бинарныйРежимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графическийРежимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обработка10ст8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кадроваяСинхронизацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сбросToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem потокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьПотокКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уменьшитьToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage BinaryStructure;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage PackageAnalyze;
        private System.Windows.Forms.ToolStripMenuItem обработка9ст7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обработка11ст8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem периодСтрокиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перевестиВТекстИСохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.GroupBox IPgroupBox;
        private System.Windows.Forms.CheckedListBox IPHeaderFlagsListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IPHeaderIDTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IPHeaderTotalLengthTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IPHeaderTosTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IPHeaderLengthTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IPHeaderVersionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IPHeaderDestinationIPTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox IPHeaderSourceIPTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox IPHeaderCheckSumTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox IPHeaderProtocolTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IPHeaderTtlTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox IPHeaderFragmentOffsetTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox DataGroupBox;
        private System.Windows.Forms.GroupBox NmeaGroupBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox NMEADirectionTextBox1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox NMEALongtitudeTextBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox NMEADirectionTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox NMEALatitudeTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox NMEAIDTextBox;
        private System.Windows.Forms.TextBox DATABlockCallSign;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox UDPGroupBox;
        private System.Windows.Forms.TextBox UDPHeaderCheckSumTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox UDPHeaderLengthTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox UDPHeaderDestinationPortTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox UDPHeaderSourcePortTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox NMEACheckTextBox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox NMEAModeTextBox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox NMEADateTextBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox NMEAFlowDirectionTextBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox NMEASpeedTextBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox NMEATimeTextBox;
        private System.Windows.Forms.Button showMapButton;
        private System.Windows.Forms.CheckBox AnalyzeMode;
        private System.Windows.Forms.ToolStripMenuItem синхрогруппаToolStripMenuItem;
        private System.Windows.Forms.TabPage TextBinaryStructure;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox DataTextBox;
        private System.Windows.Forms.ComboBox NMEAarrayComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button HexArrayButton;
        private System.Windows.Forms.Button DecimalArrayButton;
        private System.Windows.Forms.Button BinaryArrayButton;
    }
}

