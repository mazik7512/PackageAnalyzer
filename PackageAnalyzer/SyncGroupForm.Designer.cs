namespace PackageAnalyzer
{
    partial class SyncGroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SyncGroupForm));
            this.invertedOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SyncGroupTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // invertedOrderCheckBox
            // 
            this.invertedOrderCheckBox.AutoSize = true;
            this.invertedOrderCheckBox.Location = new System.Drawing.Point(9, 100);
            this.invertedOrderCheckBox.Name = "invertedOrderCheckBox";
            this.invertedOrderCheckBox.Size = new System.Drawing.Size(155, 17);
            this.invertedOrderCheckBox.TabIndex = 0;
            this.invertedOrderCheckBox.Text = "Обратный порядок ввода";
            this.invertedOrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(239, 94);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "Установить";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Синхрогруппа:";
            // 
            // SyncGroupTextBox
            // 
            this.SyncGroupTextBox.Location = new System.Drawing.Point(92, 54);
            this.SyncGroupTextBox.Mask = "0000000000000000";
            this.SyncGroupTextBox.Name = "SyncGroupTextBox";
            this.SyncGroupTextBox.PromptChar = ' ';
            this.SyncGroupTextBox.Size = new System.Drawing.Size(247, 20);
            this.SyncGroupTextBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.OKButton);
            this.groupBox1.Controls.Add(this.SyncGroupTextBox);
            this.groupBox1.Controls.Add(this.invertedOrderCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 143);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод синхрогруппы";
            // 
            // SyncGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 167);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SyncGroupForm";
            this.Text = "Ввод синхрогруппы";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox invertedOrderCheckBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox SyncGroupTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}