namespace BinaryStructureModuleGraph
{
    partial class ConfigureFilterForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.period = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.dataLength = new System.Windows.Forms.NumericUpDown();
            this.containerLength = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startBitsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stopBitsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.period)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerLength)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.stopBitsTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.startBitsTextBox);
            this.groupBox1.Controls.Add(this.period);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CancelButton);
            this.groupBox1.Controls.Add(this.ExecuteButton);
            this.groupBox1.Controls.Add(this.dataLength);
            this.groupBox1.Controls.Add(this.containerLength);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // period
            // 
            this.period.Location = new System.Drawing.Point(147, 171);
            this.period.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(120, 20);
            this.period.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Период строки:";
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButton.Location = new System.Drawing.Point(286, 168);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(98, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ExecuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExecuteButton.Location = new System.Drawing.Point(286, 125);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(98, 23);
            this.ExecuteButton.TabIndex = 4;
            this.ExecuteButton.Text = "Выполнить";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // dataLength
            // 
            this.dataLength.Location = new System.Drawing.Point(147, 128);
            this.dataLength.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.dataLength.Name = "dataLength";
            this.dataLength.Size = new System.Drawing.Size(120, 20);
            this.dataLength.TabIndex = 3;
            // 
            // containerLength
            // 
            this.containerLength.Location = new System.Drawing.Point(166, 31);
            this.containerLength.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.containerLength.Name = "containerLength";
            this.containerLength.Size = new System.Drawing.Size(120, 20);
            this.containerLength.TabIndex = 2;
            this.containerLength.ValueChanged += new System.EventHandler(this.containerLength_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Размер кодового слова:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер блока:";
            // 
            // startBitsTextBox
            // 
            this.startBitsTextBox.Location = new System.Drawing.Point(108, 74);
            this.startBitsTextBox.Name = "startBitsTextBox";
            this.startBitsTextBox.Size = new System.Drawing.Size(39, 20);
            this.startBitsTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Стартовые биты:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Стоповые биты:";
            // 
            // stopBitsTextBox
            // 
            this.stopBitsTextBox.Location = new System.Drawing.Point(342, 74);
            this.stopBitsTextBox.Name = "stopBitsTextBox";
            this.stopBitsTextBox.Size = new System.Drawing.Size(39, 20);
            this.stopBitsTextBox.TabIndex = 10;
            // 
            // ConfigureFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 227);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigureFilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Конфигуратор старт-стопных комбинаций";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.period)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown dataLength;
        private System.Windows.Forms.NumericUpDown containerLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.NumericUpDown period;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stopBitsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox startBitsTextBox;
    }
}