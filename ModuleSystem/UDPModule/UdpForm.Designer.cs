namespace UDPModule
{
    partial class UdpForm
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
            this.UdpPanel = new System.Windows.Forms.Panel();
            this.UDPGroupBox = new System.Windows.Forms.GroupBox();
            this.UDPHeaderCheckSumTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.UDPHeaderLengthTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.UDPHeaderDestinationPortTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.UDPHeaderSourcePortTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.UdpPanel.SuspendLayout();
            this.UDPGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UdpPanel
            // 
            this.UdpPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UdpPanel.BackColor = System.Drawing.SystemColors.Window;
            this.UdpPanel.Controls.Add(this.UDPGroupBox);
            this.UdpPanel.Location = new System.Drawing.Point(13, 13);
            this.UdpPanel.Name = "UdpPanel";
            this.UdpPanel.Size = new System.Drawing.Size(257, 247);
            this.UdpPanel.TabIndex = 0;
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
            this.UDPGroupBox.Location = new System.Drawing.Point(3, 14);
            this.UDPGroupBox.Name = "UDPGroupBox";
            this.UDPGroupBox.Size = new System.Drawing.Size(236, 215);
            this.UDPGroupBox.TabIndex = 4;
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
            // UdpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 272);
            this.Controls.Add(this.UdpPanel);
            this.Name = "UdpForm";
            this.Text = "UdpForm";
            this.UdpPanel.ResumeLayout(false);
            this.UDPGroupBox.ResumeLayout(false);
            this.UDPGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UdpPanel;
        private System.Windows.Forms.GroupBox UDPGroupBox;
        private System.Windows.Forms.TextBox UDPHeaderCheckSumTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox UDPHeaderLengthTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox UDPHeaderDestinationPortTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox UDPHeaderSourcePortTextBox;
        private System.Windows.Forms.Label label14;
    }
}