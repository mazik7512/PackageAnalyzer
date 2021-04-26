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
            this.pcapрежимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.потокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьПотокКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перевестиВТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьТекстКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.BinaryStructure = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ASCIIText = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PackageAnalyze = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.BinaryStructure.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ASCIIText.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.потокToolStripMenuItem});
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
            this.бинарныйРежимToolStripMenuItem,
            this.pcapрежимToolStripMenuItem});
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
            // pcapрежимToolStripMenuItem
            // 
            this.pcapрежимToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pcapрежимToolStripMenuItem.Image")));
            this.pcapрежимToolStripMenuItem.Name = "pcapрежимToolStripMenuItem";
            this.pcapрежимToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.pcapрежимToolStripMenuItem.Text = "Pcap-режим";
            this.pcapрежимToolStripMenuItem.Click += new System.EventHandler(this.pcapрежимToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = global::PackageAnalyzer.Resources.Exit;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.графическийРежимToolStripMenuItem,
            this.фильтрацияToolStripMenuItem,
            this.размерыToolStripMenuItem});
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
            this.обработка9ст7ToolStripMenuItem.Name = "обработка9ст7ToolStripMenuItem";
            this.обработка9ст7ToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.обработка9ст7ToolStripMenuItem.Text = "Обработка 9ст7";
            // 
            // обработка11ст8ToolStripMenuItem
            // 
            this.обработка11ст8ToolStripMenuItem.Name = "обработка11ст8ToolStripMenuItem";
            this.обработка11ст8ToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.обработка11ст8ToolStripMenuItem.Text = "Обработка 11ст8";
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
            // потокToolStripMenuItem
            // 
            this.потокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьПотокКакToolStripMenuItem,
            this.текстToolStripMenuItem});
            this.потокToolStripMenuItem.Image = global::PackageAnalyzer.Resources.Stream;
            this.потокToolStripMenuItem.Name = "потокToolStripMenuItem";
            this.потокToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.потокToolStripMenuItem.Text = "Поток";
            // 
            // сохранитьПотокКакToolStripMenuItem
            // 
            this.сохранитьПотокКакToolStripMenuItem.Image = global::PackageAnalyzer.Resources.SaveStream;
            this.сохранитьПотокКакToolStripMenuItem.Name = "сохранитьПотокКакToolStripMenuItem";
            this.сохранитьПотокКакToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.сохранитьПотокКакToolStripMenuItem.Text = "Сохранить поток как...";
            // 
            // текстToolStripMenuItem
            // 
            this.текстToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перевестиВТекстToolStripMenuItem,
            this.сохранитьТекстКакToolStripMenuItem});
            this.текстToolStripMenuItem.Image = global::PackageAnalyzer.Resources.Text;
            this.текстToolStripMenuItem.Name = "текстToolStripMenuItem";
            this.текстToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.текстToolStripMenuItem.Text = "Текст";
            // 
            // перевестиВТекстToolStripMenuItem
            // 
            this.перевестиВТекстToolStripMenuItem.Image = global::PackageAnalyzer.Resources.TranslateToText;
            this.перевестиВТекстToolStripMenuItem.Name = "перевестиВТекстToolStripMenuItem";
            this.перевестиВТекстToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.перевестиВТекстToolStripMenuItem.Text = "Перевести в текст";
            this.перевестиВТекстToolStripMenuItem.Click += new System.EventHandler(this.перевестиВТекстToolStripMenuItem_Click);
            // 
            // сохранитьТекстКакToolStripMenuItem
            // 
            this.сохранитьТекстКакToolStripMenuItem.Image = global::PackageAnalyzer.Resources.SaveText;
            this.сохранитьТекстКакToolStripMenuItem.Name = "сохранитьТекстКакToolStripMenuItem";
            this.сохранитьТекстКакToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.сохранитьТекстКакToolStripMenuItem.Text = "Сохранить текст как...";
            this.сохранитьТекстКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьТекстКакToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.BinaryStructure);
            this.tabControl.Controls.Add(this.ASCIIText);
            this.tabControl.Controls.Add(this.PackageAnalyze);
            this.tabControl.HotTrack = true;
            this.tabControl.ImageList = this.imageList1;
            this.tabControl.Location = new System.Drawing.Point(13, 33);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(871, 542);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // BinaryStructure
            // 
            this.BinaryStructure.Controls.Add(this.panel1);
            this.BinaryStructure.ImageIndex = 0;
            this.BinaryStructure.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BinaryStructure.Location = new System.Drawing.Point(4, 23);
            this.BinaryStructure.Name = "BinaryStructure";
            this.BinaryStructure.Padding = new System.Windows.Forms.Padding(3);
            this.BinaryStructure.Size = new System.Drawing.Size(863, 515);
            this.BinaryStructure.TabIndex = 0;
            this.BinaryStructure.Text = "Бинарная структура";
            this.BinaryStructure.ToolTipText = "Структура пакета";
            this.BinaryStructure.UseVisualStyleBackColor = true;
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
            this.panel1.Size = new System.Drawing.Size(850, 502);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(827, 509);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // ASCIIText
            // 
            this.ASCIIText.Controls.Add(this.panel2);
            this.ASCIIText.ImageIndex = 2;
            this.ASCIIText.Location = new System.Drawing.Point(4, 23);
            this.ASCIIText.Name = "ASCIIText";
            this.ASCIIText.Size = new System.Drawing.Size(863, 515);
            this.ASCIIText.TabIndex = 2;
            this.ASCIIText.Text = "ASCII текст";
            this.ASCIIText.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 499);
            this.panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(850, 467);
            this.textBox1.TabIndex = 0;
            // 
            // PackageAnalyze
            // 
            this.PackageAnalyze.ImageIndex = 1;
            this.PackageAnalyze.Location = new System.Drawing.Point(4, 23);
            this.PackageAnalyze.Name = "PackageAnalyze";
            this.PackageAnalyze.Padding = new System.Windows.Forms.Padding(3);
            this.PackageAnalyze.Size = new System.Drawing.Size(863, 515);
            this.PackageAnalyze.TabIndex = 1;
            this.PackageAnalyze.Text = "Анализ пакета";
            this.PackageAnalyze.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 562);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(899, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(102, 17);
            this.toolStripStatusLabel1.Text = "Текущий размер:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(25, 17);
            this.toolStripStatusLabel2.Text = "1х1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(111, 17);
            this.toolStripStatusLabel3.Text = "Прочитано -  0 бит";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(166, 17);
            this.toolStripStatusLabel4.Text = "Осталось после 10ст8 - 0 бит";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(899, 584);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анализатор пакетов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.BinaryStructure.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ASCIIText.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бинарныйРежимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pcapрежимToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem текстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перевестиВТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьТекстКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уменьшитьToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage BinaryStructure;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage PackageAnalyze;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripMenuItem обработка9ст7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обработка11ст8ToolStripMenuItem;
        private System.Windows.Forms.TabPage ASCIIText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

