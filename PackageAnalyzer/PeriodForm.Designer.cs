namespace PackageAnalyzer
{
    partial class PeriodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeriodForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.setButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.setButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Период";
            // 
            // setButton
            // 
            this.setButton.AutoEllipsis = true;
            this.setButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.setButton.FlatAppearance.BorderSize = 10;
            this.setButton.Location = new System.Drawing.Point(59, 77);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 2;
            this.setButton.Text = "Установить";
            this.setButton.UseCompatibleTextRendering = true;
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Период строки:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(99, 42);
            this.maskedTextBox1.Mask = "000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = ' ';
            this.maskedTextBox1.RejectInputOnFirstFailure = true;
            this.maskedTextBox1.ResetOnPrompt = false;
            this.maskedTextBox1.ResetOnSpace = false;
            this.maskedTextBox1.Size = new System.Drawing.Size(63, 20);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyDown);
            // 
            // PeriodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 139);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PeriodForm";
            this.Text = "Установка периода";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button setButton;
    }
}