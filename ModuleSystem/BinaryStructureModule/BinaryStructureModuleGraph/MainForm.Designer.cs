namespace BinaryStructureModuleGraph
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.paintBox = new System.Windows.Forms.PictureBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.currentPeriod = new System.Windows.Forms.Label();
            this.bordersLabel = new System.Windows.Forms.Label();
            this.current_mode_picture = new System.Windows.Forms.PictureBox();
            this.current_mode_label = new System.Windows.Forms.Label();
            this.current_mode_header_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.framePicker = new System.Windows.Forms.ComboBox();
            this.dataTable = new System.Windows.Forms.ListView();
            this.mainPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paintBox)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.current_mode_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AllowDrop = true;
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.AutoScroll = true;
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.Controls.Add(this.ContentPanel);
            this.mainPanel.Controls.Add(this.headerPanel);
            this.mainPanel.Location = new System.Drawing.Point(28, 16);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(840, 527);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainPanel_DragDrop);
            this.mainPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.mainPanel_DragEnter);
            this.mainPanel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.mainPanel_PreviewKeyDown);
            this.mainPanel.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ContentPanel.Controls.Add(this.dataTable);
            this.ContentPanel.Controls.Add(this.paintBox);
            this.ContentPanel.Location = new System.Drawing.Point(4, 60);
            this.ContentPanel.MinimumSize = new System.Drawing.Size(126, 50);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(833, 464);
            this.ContentPanel.TabIndex = 6;
            // 
            // paintBox
            // 
            this.paintBox.BackColor = System.Drawing.SystemColors.Control;
            this.paintBox.Location = new System.Drawing.Point(3, 12);
            this.paintBox.Name = "paintBox";
            this.paintBox.Size = new System.Drawing.Size(827, 449);
            this.paintBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.paintBox.TabIndex = 0;
            this.paintBox.TabStop = false;
            this.paintBox.SizeChanged += new System.EventHandler(this.paintBox_SizeChanged);
            this.paintBox.Paint += new System.Windows.Forms.PaintEventHandler(this.paintBox_Paint);
            this.paintBox.Resize += new System.EventHandler(this.paintBox_Resize);
            // 
            // headerPanel
            // 
            this.headerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerPanel.AutoScroll = true;
            this.headerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.headerPanel.Controls.Add(this.currentPeriod);
            this.headerPanel.Controls.Add(this.bordersLabel);
            this.headerPanel.Controls.Add(this.current_mode_picture);
            this.headerPanel.Controls.Add(this.current_mode_label);
            this.headerPanel.Controls.Add(this.current_mode_header_label);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Controls.Add(this.framePicker);
            this.headerPanel.Location = new System.Drawing.Point(3, 3);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(834, 179);
            this.headerPanel.TabIndex = 5;
            // 
            // currentPeriod
            // 
            this.currentPeriod.AutoSize = true;
            this.currentPeriod.Font = new System.Drawing.Font("Roboto Lt", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentPeriod.Location = new System.Drawing.Point(387, 22);
            this.currentPeriod.Name = "currentPeriod";
            this.currentPeriod.Size = new System.Drawing.Size(106, 14);
            this.currentPeriod.TabIndex = 9;
            this.currentPeriod.Text = "Текущий период: ";
            // 
            // bordersLabel
            // 
            this.bordersLabel.AutoSize = true;
            this.bordersLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bordersLabel.Location = new System.Drawing.Point(241, 22);
            this.bordersLabel.Name = "bordersLabel";
            this.bordersLabel.Size = new System.Drawing.Size(128, 15);
            this.bordersLabel.TabIndex = 8;
            this.bordersLabel.Text = "Вывод: с 0 по 0 байт";
            // 
            // current_mode_picture
            // 
            this.current_mode_picture.Image = global::BinaryStructureModuleGraph.Resource.GraphMode;
            this.current_mode_picture.Location = new System.Drawing.Point(687, 16);
            this.current_mode_picture.Name = "current_mode_picture";
            this.current_mode_picture.Size = new System.Drawing.Size(24, 24);
            this.current_mode_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.current_mode_picture.TabIndex = 7;
            this.current_mode_picture.TabStop = false;
            // 
            // current_mode_label
            // 
            this.current_mode_label.AutoSize = true;
            this.current_mode_label.Font = new System.Drawing.Font("Roboto Lt", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.current_mode_label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.current_mode_label.Location = new System.Drawing.Point(717, 22);
            this.current_mode_label.Name = "current_mode_label";
            this.current_mode_label.Size = new System.Drawing.Size(97, 14);
            this.current_mode_label.TabIndex = 6;
            this.current_mode_label.Text = "Графический";
            // 
            // current_mode_header_label
            // 
            this.current_mode_header_label.AutoSize = true;
            this.current_mode_header_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.current_mode_header_label.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.current_mode_header_label.Location = new System.Drawing.Point(574, 22);
            this.current_mode_header_label.Name = "current_mode_header_label";
            this.current_mode_header_label.Size = new System.Drawing.Size(107, 15);
            this.current_mode_header_label.TabIndex = 5;
            this.current_mode_header_label.Text = "Текущий режим:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выбор кадра:";
            // 
            // framePicker
            // 
            this.framePicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.framePicker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.framePicker.FormattingEnabled = true;
            this.framePicker.Location = new System.Drawing.Point(100, 16);
            this.framePicker.Name = "framePicker";
            this.framePicker.Size = new System.Drawing.Size(123, 21);
            this.framePicker.TabIndex = 3;
            this.framePicker.SelectedIndexChanged += new System.EventHandler(this.framePicker_SelectedIndexChanged);
            // 
            // dataTable
            // 
            this.dataTable.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.dataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTable.GridLines = true;
            this.dataTable.Location = new System.Drawing.Point(30, 50);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(783, 312);
            this.dataTable.TabIndex = 2;
            this.dataTable.UseCompatibleStateImageBehavior = false;
            this.dataTable.View = System.Windows.Forms.View.Details;
            this.dataTable.VirtualMode = true;
            this.dataTable.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.dataTable_RetrieveVirtualItem);
            this.dataTable.SearchForVirtualItem += new System.Windows.Forms.SearchForVirtualItemEventHandler(this.dataTable_SearchForVirtualItem);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 555);
            this.Controls.Add(this.mainPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "formTheme1";
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.MainForm_Scroll);
            this.mainPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paintBox)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.current_mode_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox paintBox;
        public System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.ComboBox framePicker;
        private System.Windows.Forms.Label current_mode_header_label;
        private System.Windows.Forms.PictureBox current_mode_picture;
        private System.Windows.Forms.Label current_mode_label;
        private System.Windows.Forms.Label bordersLabel;
        private System.Windows.Forms.Label currentPeriod;
        private System.Windows.Forms.ListView dataTable;
    }
}