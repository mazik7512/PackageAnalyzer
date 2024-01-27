namespace IpModule
{
    partial class MapForm
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
            this.MapSplitContainer = new System.Windows.Forms.SplitContainer();
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.dateTimeValueLabel = new System.Windows.Forms.Label();
            this.dateTimeHeaderLabel = new System.Windows.Forms.Label();
            this.longtitudeValueLabel = new System.Windows.Forms.Label();
            this.longtitudeHeaderLabel = new System.Windows.Forms.Label();
            this.latitudeValueLabel = new System.Windows.Forms.Label();
            this.latitudeHeaderLabel = new System.Windows.Forms.Label();
            this.speedValueLabel = new System.Windows.Forms.Label();
            this.speedHeaderLabel = new System.Windows.Forms.Label();
            this.directionValueLabel = new System.Windows.Forms.Label();
            this.directionHeaderLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mapLegend = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.shipMarkerLabel = new System.Windows.Forms.Label();
            this.shipMarkerPicture = new System.Windows.Forms.PictureBox();
            this.NMEAComboBox = new System.Windows.Forms.ComboBox();
            this.MapControl = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.MapSplitContainer)).BeginInit();
            this.MapSplitContainer.Panel1.SuspendLayout();
            this.MapSplitContainer.Panel2.SuspendLayout();
            this.MapSplitContainer.SuspendLayout();
            this.dataGroupBox.SuspendLayout();
            this.mapLegend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipMarkerPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // MapSplitContainer
            // 
            this.MapSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MapSplitContainer.Name = "MapSplitContainer";
            // 
            // MapSplitContainer.Panel1
            // 
            this.MapSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.MapSplitContainer.Panel1.Controls.Add(this.dataGroupBox);
            this.MapSplitContainer.Panel1.Controls.Add(this.label1);
            this.MapSplitContainer.Panel1.Controls.Add(this.mapLegend);
            this.MapSplitContainer.Panel1.Controls.Add(this.NMEAComboBox);
            // 
            // MapSplitContainer.Panel2
            // 
            this.MapSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.MapSplitContainer.Panel2.Controls.Add(this.MapControl);
            this.MapSplitContainer.Size = new System.Drawing.Size(766, 385);
            this.MapSplitContainer.SplitterDistance = 255;
            this.MapSplitContainer.TabIndex = 0;
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGroupBox.Controls.Add(this.dateTimeValueLabel);
            this.dataGroupBox.Controls.Add(this.dateTimeHeaderLabel);
            this.dataGroupBox.Controls.Add(this.longtitudeValueLabel);
            this.dataGroupBox.Controls.Add(this.longtitudeHeaderLabel);
            this.dataGroupBox.Controls.Add(this.latitudeValueLabel);
            this.dataGroupBox.Controls.Add(this.latitudeHeaderLabel);
            this.dataGroupBox.Controls.Add(this.speedValueLabel);
            this.dataGroupBox.Controls.Add(this.speedHeaderLabel);
            this.dataGroupBox.Controls.Add(this.directionValueLabel);
            this.dataGroupBox.Controls.Add(this.directionHeaderLabel);
            this.dataGroupBox.Location = new System.Drawing.Point(12, 166);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(226, 216);
            this.dataGroupBox.TabIndex = 8;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "Данные";
            // 
            // dateTimeValueLabel
            // 
            this.dateTimeValueLabel.AutoSize = true;
            this.dateTimeValueLabel.BackColor = System.Drawing.SystemColors.InfoText;
            this.dateTimeValueLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeValueLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.dateTimeValueLabel.Location = new System.Drawing.Point(25, 181);
            this.dateTimeValueLabel.Name = "dateTimeValueLabel";
            this.dateTimeValueLabel.Size = new System.Drawing.Size(174, 19);
            this.dateTimeValueLabel.TabIndex = 9;
            this.dateTimeValueLabel.Text = "01.01.2000 00:00:00 UTC";
            // 
            // dateTimeHeaderLabel
            // 
            this.dateTimeHeaderLabel.AutoSize = true;
            this.dateTimeHeaderLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeHeaderLabel.Location = new System.Drawing.Point(25, 149);
            this.dateTimeHeaderLabel.Name = "dateTimeHeaderLabel";
            this.dateTimeHeaderLabel.Size = new System.Drawing.Size(171, 19);
            this.dateTimeHeaderLabel.TabIndex = 8;
            this.dateTimeHeaderLabel.Text = "Дата и время фиксации:";
            // 
            // longtitudeValueLabel
            // 
            this.longtitudeValueLabel.AutoSize = true;
            this.longtitudeValueLabel.BackColor = System.Drawing.SystemColors.InfoText;
            this.longtitudeValueLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.longtitudeValueLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.longtitudeValueLabel.Location = new System.Drawing.Point(89, 117);
            this.longtitudeValueLabel.Name = "longtitudeValueLabel";
            this.longtitudeValueLabel.Size = new System.Drawing.Size(92, 19);
            this.longtitudeValueLabel.TabIndex = 7;
            this.longtitudeValueLabel.Text = "0.0 градусов";
            // 
            // longtitudeHeaderLabel
            // 
            this.longtitudeHeaderLabel.AutoSize = true;
            this.longtitudeHeaderLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.longtitudeHeaderLabel.Location = new System.Drawing.Point(15, 117);
            this.longtitudeHeaderLabel.Name = "longtitudeHeaderLabel";
            this.longtitudeHeaderLabel.Size = new System.Drawing.Size(67, 19);
            this.longtitudeHeaderLabel.TabIndex = 6;
            this.longtitudeHeaderLabel.Text = "Долгота:";
            // 
            // latitudeValueLabel
            // 
            this.latitudeValueLabel.AutoSize = true;
            this.latitudeValueLabel.BackColor = System.Drawing.SystemColors.InfoText;
            this.latitudeValueLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.latitudeValueLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.latitudeValueLabel.Location = new System.Drawing.Point(87, 87);
            this.latitudeValueLabel.Name = "latitudeValueLabel";
            this.latitudeValueLabel.Size = new System.Drawing.Size(92, 19);
            this.latitudeValueLabel.TabIndex = 5;
            this.latitudeValueLabel.Text = "0.0 градусов";
            // 
            // latitudeHeaderLabel
            // 
            this.latitudeHeaderLabel.AutoSize = true;
            this.latitudeHeaderLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.latitudeHeaderLabel.Location = new System.Drawing.Point(13, 87);
            this.latitudeHeaderLabel.Name = "latitudeHeaderLabel";
            this.latitudeHeaderLabel.Size = new System.Drawing.Size(66, 19);
            this.latitudeHeaderLabel.TabIndex = 4;
            this.latitudeHeaderLabel.Text = "Широта:";
            // 
            // speedValueLabel
            // 
            this.speedValueLabel.AutoSize = true;
            this.speedValueLabel.BackColor = System.Drawing.SystemColors.InfoText;
            this.speedValueLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedValueLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.speedValueLabel.Location = new System.Drawing.Point(87, 60);
            this.speedValueLabel.Name = "speedValueLabel";
            this.speedValueLabel.Size = new System.Drawing.Size(70, 19);
            this.speedValueLabel.TabIndex = 3;
            this.speedValueLabel.Text = "0.0 узлов";
            // 
            // speedHeaderLabel
            // 
            this.speedHeaderLabel.AutoSize = true;
            this.speedHeaderLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedHeaderLabel.Location = new System.Drawing.Point(7, 60);
            this.speedHeaderLabel.Name = "speedHeaderLabel";
            this.speedHeaderLabel.Size = new System.Drawing.Size(74, 19);
            this.speedHeaderLabel.TabIndex = 2;
            this.speedHeaderLabel.Text = "Скорость:";
            // 
            // directionValueLabel
            // 
            this.directionValueLabel.AutoSize = true;
            this.directionValueLabel.BackColor = System.Drawing.SystemColors.InfoText;
            this.directionValueLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directionValueLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.directionValueLabel.Location = new System.Drawing.Point(115, 31);
            this.directionValueLabel.Name = "directionValueLabel";
            this.directionValueLabel.Size = new System.Drawing.Size(92, 19);
            this.directionValueLabel.TabIndex = 1;
            this.directionValueLabel.Text = "0.0 градусов";
            // 
            // directionHeaderLabel
            // 
            this.directionHeaderLabel.AutoSize = true;
            this.directionHeaderLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directionHeaderLabel.Location = new System.Drawing.Point(7, 31);
            this.directionHeaderLabel.Name = "directionHeaderLabel";
            this.directionHeaderLabel.Size = new System.Drawing.Size(102, 19);
            this.directionHeaderLabel.TabIndex = 0;
            this.directionHeaderLabel.Text = "Направление:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выбор пакета данных:";
            // 
            // mapLegend
            // 
            this.mapLegend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapLegend.Controls.Add(this.SaveButton);
            this.mapLegend.Controls.Add(this.shipMarkerLabel);
            this.mapLegend.Controls.Add(this.shipMarkerPicture);
            this.mapLegend.Location = new System.Drawing.Point(12, 12);
            this.mapLegend.Name = "mapLegend";
            this.mapLegend.Size = new System.Drawing.Size(226, 90);
            this.mapLegend.TabIndex = 5;
            this.mapLegend.TabStop = false;
            this.mapLegend.Text = "Легенда карты";
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Location = new System.Drawing.Point(6, 67);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(214, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "[DEBUG] Сохранить карту";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // shipMarkerLabel
            // 
            this.shipMarkerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shipMarkerLabel.AutoSize = true;
            this.shipMarkerLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shipMarkerLabel.Location = new System.Drawing.Point(56, 39);
            this.shipMarkerLabel.Name = "shipMarkerLabel";
            this.shipMarkerLabel.Size = new System.Drawing.Size(73, 19);
            this.shipMarkerLabel.TabIndex = 1;
            this.shipMarkerLabel.Text = "Корабль";
            // 
            // shipMarkerPicture
            // 
            this.shipMarkerPicture.Image = global::IpModule.Resources.ShipMarker;
            this.shipMarkerPicture.Location = new System.Drawing.Point(6, 30);
            this.shipMarkerPicture.Name = "shipMarkerPicture";
            this.shipMarkerPicture.Size = new System.Drawing.Size(44, 37);
            this.shipMarkerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.shipMarkerPicture.TabIndex = 0;
            this.shipMarkerPicture.TabStop = false;
            // 
            // NMEAComboBox
            // 
            this.NMEAComboBox.FormattingEnabled = true;
            this.NMEAComboBox.Location = new System.Drawing.Point(50, 130);
            this.NMEAComboBox.Name = "NMEAComboBox";
            this.NMEAComboBox.Size = new System.Drawing.Size(140, 21);
            this.NMEAComboBox.TabIndex = 6;
            this.NMEAComboBox.SelectedIndexChanged += new System.EventHandler(this.NMEAComboBox_SelectedIndexChanged);
            // 
            // MapControl
            // 
            this.MapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MapControl.Bearing = 0F;
            this.MapControl.CanDragMap = true;
            this.MapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.MapControl.GrayScaleMode = false;
            this.MapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MapControl.LevelsKeepInMemmory = 5;
            this.MapControl.Location = new System.Drawing.Point(3, 3);
            this.MapControl.MarkersEnabled = true;
            this.MapControl.MaxZoom = 2;
            this.MapControl.MinZoom = 2;
            this.MapControl.MouseWheelZoomEnabled = true;
            this.MapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MapControl.Name = "MapControl";
            this.MapControl.NegativeMode = false;
            this.MapControl.PolygonsEnabled = true;
            this.MapControl.RetryLoadTile = 0;
            this.MapControl.RoutesEnabled = true;
            this.MapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MapControl.ShowTileGridLines = false;
            this.MapControl.Size = new System.Drawing.Size(504, 379);
            this.MapControl.TabIndex = 4;
            this.MapControl.Zoom = 0D;
            this.MapControl.Load += new System.EventHandler(this.MapControl_Load);
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 385);
            this.Controls.Add(this.MapSplitContainer);
            this.Name = "MapForm";
            this.Text = "MapForm";
            this.MapSplitContainer.Panel1.ResumeLayout(false);
            this.MapSplitContainer.Panel1.PerformLayout();
            this.MapSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MapSplitContainer)).EndInit();
            this.MapSplitContainer.ResumeLayout(false);
            this.dataGroupBox.ResumeLayout(false);
            this.dataGroupBox.PerformLayout();
            this.mapLegend.ResumeLayout(false);
            this.mapLegend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipMarkerPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MapSplitContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox mapLegend;
        private System.Windows.Forms.Label shipMarkerLabel;
        private System.Windows.Forms.PictureBox shipMarkerPicture;
        private System.Windows.Forms.ComboBox NMEAComboBox;
        private GMap.NET.WindowsForms.GMapControl MapControl;
        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.Label dateTimeValueLabel;
        private System.Windows.Forms.Label dateTimeHeaderLabel;
        private System.Windows.Forms.Label longtitudeValueLabel;
        private System.Windows.Forms.Label longtitudeHeaderLabel;
        private System.Windows.Forms.Label latitudeValueLabel;
        private System.Windows.Forms.Label latitudeHeaderLabel;
        private System.Windows.Forms.Label speedValueLabel;
        private System.Windows.Forms.Label speedHeaderLabel;
        private System.Windows.Forms.Label directionValueLabel;
        private System.Windows.Forms.Label directionHeaderLabel;
        private System.Windows.Forms.Button SaveButton;
    }
}