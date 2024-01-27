namespace ConverterModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.converterPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.buttonLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.binaryDataButton = new System.Windows.Forms.Button();
            this.decDataButton = new System.Windows.Forms.Button();
            this.hexDataButton = new System.Windows.Forms.Button();
            this.converterPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.buttonLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // converterPanel
            // 
            this.converterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.converterPanel.AutoSize = true;
            this.converterPanel.BackColor = System.Drawing.SystemColors.Window;
            this.converterPanel.Controls.Add(this.groupBox1);
            this.converterPanel.Controls.Add(this.DataTextBox);
            this.converterPanel.Location = new System.Drawing.Point(3, 13);
            this.converterPanel.Name = "converterPanel";
            this.converterPanel.Size = new System.Drawing.Size(797, 447);
            this.converterPanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonLayoutPanel);
            this.groupBox1.Location = new System.Drawing.Point(10, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки отображения";
            // 
            // DataTextBox
            // 
            this.DataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataTextBox.Location = new System.Drawing.Point(10, 78);
            this.DataTextBox.Multiline = true;
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataTextBox.Size = new System.Drawing.Size(775, 360);
            this.DataTextBox.TabIndex = 0;
            // 
            // buttonLayoutPanel
            // 
            this.buttonLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLayoutPanel.AutoSize = true;
            this.buttonLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLayoutPanel.Controls.Add(this.binaryDataButton);
            this.buttonLayoutPanel.Controls.Add(this.decDataButton);
            this.buttonLayoutPanel.Controls.Add(this.hexDataButton);
            this.buttonLayoutPanel.Location = new System.Drawing.Point(7, 20);
            this.buttonLayoutPanel.Name = "buttonLayoutPanel";
            this.buttonLayoutPanel.Size = new System.Drawing.Size(585, 40);
            this.buttonLayoutPanel.TabIndex = 3;
            // 
            // binaryDataButton
            // 
            this.binaryDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.binaryDataButton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.binaryDataButton.Image = ((System.Drawing.Image)(resources.GetObject("binaryDataButton.Image")));
            this.binaryDataButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.binaryDataButton.Location = new System.Drawing.Point(3, 3);
            this.binaryDataButton.Name = "binaryDataButton";
            this.binaryDataButton.Size = new System.Drawing.Size(159, 34);
            this.binaryDataButton.TabIndex = 0;
            this.binaryDataButton.Text = "Двоичные данные";
            this.binaryDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.binaryDataButton.UseVisualStyleBackColor = true;
            this.binaryDataButton.Click += new System.EventHandler(this.binaryDataButton_Click);
            // 
            // decDataButton
            // 
            this.decDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decDataButton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decDataButton.Image = global::ConverterModule.Resources.Data;
            this.decDataButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.decDataButton.Location = new System.Drawing.Point(168, 3);
            this.decDataButton.Name = "decDataButton";
            this.decDataButton.Size = new System.Drawing.Size(175, 34);
            this.decDataButton.TabIndex = 1;
            this.decDataButton.Text = "Десятичные данные";
            this.decDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.decDataButton.UseVisualStyleBackColor = true;
            this.decDataButton.Click += new System.EventHandler(this.decDataButton_Click);
            // 
            // hexDataButton
            // 
            this.hexDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hexDataButton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hexDataButton.Image = global::ConverterModule.Resources.Hex_Data;
            this.hexDataButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hexDataButton.Location = new System.Drawing.Point(349, 3);
            this.hexDataButton.Name = "hexDataButton";
            this.hexDataButton.Size = new System.Drawing.Size(233, 34);
            this.hexDataButton.TabIndex = 2;
            this.hexDataButton.Text = "Шестнадцетиричные данные";
            this.hexDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hexDataButton.UseVisualStyleBackColor = true;
            this.hexDataButton.Click += new System.EventHandler(this.hexDataButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 463);
            this.Controls.Add(this.converterPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.converterPanel.ResumeLayout(false);
            this.converterPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.buttonLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DataTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button binaryDataButton;
        private System.Windows.Forms.Button hexDataButton;
        private System.Windows.Forms.Button decDataButton;
        private System.Windows.Forms.FlowLayoutPanel buttonLayoutPanel;
        public System.Windows.Forms.Panel converterPanel;
    }
}