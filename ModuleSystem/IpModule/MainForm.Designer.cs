namespace IpModule
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.IpPanel = new System.Windows.Forms.Panel();
            this.showMapButton = new System.Windows.Forms.Button();
            this.DataGroupBox = new System.Windows.Forms.GroupBox();
            this.savePackageButton = new System.Windows.Forms.Button();
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
            this.label15 = new System.Windows.Forms.Label();
            this.NMEAIDTextBox = new System.Windows.Forms.TextBox();
            this.DATABlockCallSign = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.UDPGroupBox = new System.Windows.Forms.GroupBox();
            this.UDPHeaderCheckSumTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.UDPHeaderLengthTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.UDPHeaderDestinationPortTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.UDPHeaderSourcePortTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.packagePicker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AnalyzeMode = new System.Windows.Forms.CheckBox();
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
            this.SwipePanel = new System.Windows.Forms.Panel();
            this.animationThread = new System.ComponentModel.BackgroundWorker();
            this.HoverMapButton = new System.Windows.Forms.Label();
            this.swipeTimer = new System.Windows.Forms.Timer(this.components);
            this.IpPanel.SuspendLayout();
            this.DataGroupBox.SuspendLayout();
            this.NmeaGroupBox.SuspendLayout();
            this.UDPGroupBox.SuspendLayout();
            this.IPgroupBox.SuspendLayout();
            this.SwipePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IpPanel
            // 
            this.IpPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IpPanel.AutoScroll = true;
            this.IpPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.IpPanel.BackColor = System.Drawing.Color.White;
            this.IpPanel.Controls.Add(this.SwipePanel);
            this.IpPanel.Controls.Add(this.showMapButton);
            this.IpPanel.Controls.Add(this.DataGroupBox);
            this.IpPanel.Controls.Add(this.UDPGroupBox);
            this.IpPanel.Controls.Add(this.packagePicker);
            this.IpPanel.Controls.Add(this.label1);
            this.IpPanel.Controls.Add(this.AnalyzeMode);
            this.IpPanel.Controls.Add(this.IPgroupBox);
            this.IpPanel.Location = new System.Drawing.Point(13, 13);
            this.IpPanel.Name = "IpPanel";
            this.IpPanel.Size = new System.Drawing.Size(849, 540);
            this.IpPanel.TabIndex = 0;
            // 
            // showMapButton
            // 
            this.showMapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showMapButton.Enabled = false;
            this.showMapButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showMapButton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showMapButton.Image = ((System.Drawing.Image)(resources.GetObject("showMapButton.Image")));
            this.showMapButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showMapButton.Location = new System.Drawing.Point(24, 270);
            this.showMapButton.Name = "showMapButton";
            this.showMapButton.Size = new System.Drawing.Size(174, 31);
            this.showMapButton.TabIndex = 19;
            this.showMapButton.Text = "Посмотреть на карте";
            this.showMapButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showMapButton.UseVisualStyleBackColor = true;
            this.showMapButton.Click += new System.EventHandler(this.showMapButton_Click);
            // 
            // DataGroupBox
            // 
            this.DataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGroupBox.Controls.Add(this.savePackageButton);
            this.DataGroupBox.Controls.Add(this.NmeaGroupBox);
            this.DataGroupBox.Controls.Add(this.DATABlockCallSign);
            this.DataGroupBox.Controls.Add(this.label19);
            this.DataGroupBox.Enabled = false;
            this.DataGroupBox.Location = new System.Drawing.Point(19, 307);
            this.DataGroupBox.Name = "DataGroupBox";
            this.DataGroupBox.Size = new System.Drawing.Size(861, 222);
            this.DataGroupBox.TabIndex = 18;
            this.DataGroupBox.TabStop = false;
            this.DataGroupBox.Text = "Блок данных";
            // 
            // savePackageButton
            // 
            this.savePackageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.savePackageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.savePackageButton.Font = new System.Drawing.Font("Roboto Lt", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savePackageButton.Image = global::IpModule.Resources.Save_Data;
            this.savePackageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savePackageButton.Location = new System.Drawing.Point(636, 22);
            this.savePackageButton.Name = "savePackageButton";
            this.savePackageButton.Size = new System.Drawing.Size(177, 30);
            this.savePackageButton.TabIndex = 37;
            this.savePackageButton.Text = "Сохранить данные";
            this.savePackageButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.savePackageButton.UseVisualStyleBackColor = true;
            this.savePackageButton.Click += new System.EventHandler(this.savePackageButton_Click);
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
            this.NmeaGroupBox.Controls.Add(this.label15);
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
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(265, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Идентификатор NMEA:";
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
            this.UDPGroupBox.Controls.Add(this.label14);
            this.UDPGroupBox.Controls.Add(this.UDPHeaderSourcePortTextBox);
            this.UDPGroupBox.Controls.Add(this.label18);
            this.UDPGroupBox.Enabled = false;
            this.UDPGroupBox.Location = new System.Drawing.Point(610, 17);
            this.UDPGroupBox.Name = "UDPGroupBox";
            this.UDPGroupBox.Size = new System.Drawing.Size(272, 225);
            this.UDPGroupBox.TabIndex = 17;
            this.UDPGroupBox.TabStop = false;
            this.UDPGroupBox.Text = "UDP-заголовок";
            // 
            // UDPHeaderCheckSumTextBox
            // 
            this.UDPHeaderCheckSumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UDPHeaderCheckSumTextBox.Location = new System.Drawing.Point(78, 182);
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
            this.label17.Location = new System.Drawing.Point(6, 185);
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
            this.UDPHeaderLengthTextBox.Location = new System.Drawing.Point(145, 151);
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
            this.label16.Location = new System.Drawing.Point(6, 154);
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
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Порт получателя:";
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
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Порт отправителя:";
            // 
            // packagePicker
            // 
            this.packagePicker.FormattingEnabled = true;
            this.packagePicker.Location = new System.Drawing.Point(343, 13);
            this.packagePicker.Name = "packagePicker";
            this.packagePicker.Size = new System.Drawing.Size(205, 21);
            this.packagePicker.TabIndex = 12;
            this.packagePicker.SelectedIndexChanged += new System.EventHandler(this.packagePicker_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Найденные пакеты:";
            // 
            // AnalyzeMode
            // 
            this.AnalyzeMode.AutoSize = true;
            this.AnalyzeMode.Location = new System.Drawing.Point(19, 13);
            this.AnalyzeMode.Name = "AnalyzeMode";
            this.AnalyzeMode.Size = new System.Drawing.Size(114, 17);
            this.AnalyzeMode.TabIndex = 10;
            this.AnalyzeMode.Text = "Включить анализ";
            this.AnalyzeMode.UseVisualStyleBackColor = true;
            this.AnalyzeMode.CheckedChanged += new System.EventHandler(this.AnalyzeMode_CheckedChanged);
            // 
            // IPgroupBox
            // 
            this.IPgroupBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IPgroupBox.AutoSize = true;
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
            this.IPgroupBox.Location = new System.Drawing.Point(19, 39);
            this.IPgroupBox.Name = "IPgroupBox";
            this.IPgroupBox.Size = new System.Drawing.Size(561, 225);
            this.IPgroupBox.TabIndex = 9;
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
            // SwipePanel
            // 
            this.SwipePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SwipePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SwipePanel.BackColor = System.Drawing.Color.White;
            this.SwipePanel.Controls.Add(this.HoverMapButton);
            this.SwipePanel.Location = new System.Drawing.Point(786, 39);
            this.SwipePanel.Name = "SwipePanel";
            this.SwipePanel.Size = new System.Drawing.Size(63, 486);
            this.SwipePanel.TabIndex = 20;
            this.SwipePanel.MouseEnter += new System.EventHandler(this.SwipePanel_MouseEnter);
            // 
            // animationThread
            // 
            this.animationThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.animationThread_DoWork);
            // 
            // HoverMapButton
            // 
            this.HoverMapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HoverMapButton.AutoSize = true;
            this.HoverMapButton.BackColor = System.Drawing.Color.Transparent;
            this.HoverMapButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HoverMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HoverMapButton.Location = new System.Drawing.Point(3, 231);
            this.HoverMapButton.Name = "HoverMapButton";
            this.HoverMapButton.Size = new System.Drawing.Size(59, 39);
            this.HoverMapButton.TabIndex = 0;
            this.HoverMapButton.Text = "<<";
            this.HoverMapButton.MouseEnter += new System.EventHandler(this.HoverMapButton_MouseEnter);
            // 
            // swipeTimer
            // 
            this.swipeTimer.Interval = 1000;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 565);
            this.Controls.Add(this.IpPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.IpPanel.ResumeLayout(false);
            this.IpPanel.PerformLayout();
            this.DataGroupBox.ResumeLayout(false);
            this.DataGroupBox.PerformLayout();
            this.NmeaGroupBox.ResumeLayout(false);
            this.NmeaGroupBox.PerformLayout();
            this.UDPGroupBox.ResumeLayout(false);
            this.UDPGroupBox.PerformLayout();
            this.IPgroupBox.ResumeLayout(false);
            this.IPgroupBox.PerformLayout();
            this.SwipePanel.ResumeLayout(false);
            this.SwipePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox packagePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AnalyzeMode;
        private System.Windows.Forms.GroupBox IPgroupBox;
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
        public System.Windows.Forms.Panel IpPanel;
        private System.Windows.Forms.GroupBox UDPGroupBox;
        private System.Windows.Forms.TextBox UDPHeaderCheckSumTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox UDPHeaderLengthTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox UDPHeaderDestinationPortTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox UDPHeaderSourcePortTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox DataGroupBox;
        private System.Windows.Forms.GroupBox NmeaGroupBox;
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
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox NMEADirectionTextBox1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox NMEALongtitudeTextBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox NMEADirectionTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox NMEALatitudeTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox NMEAIDTextBox;
        private System.Windows.Forms.TextBox DATABlockCallSign;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button showMapButton;
        private System.Windows.Forms.Button savePackageButton;
        private System.Windows.Forms.Panel SwipePanel;
        private System.ComponentModel.BackgroundWorker animationThread;
        private System.Windows.Forms.Label HoverMapButton;
        private System.Windows.Forms.Timer swipeTimer;
    }
}