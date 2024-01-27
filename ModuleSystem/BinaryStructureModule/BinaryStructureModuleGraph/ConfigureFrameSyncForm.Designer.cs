namespace BinaryStructureModuleGraph
{
    partial class ConfigureFrameSyncForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.frameMarkerTextBox = new System.Windows.Forms.TextBox();
            this.lStrTextBox = new System.Windows.Forms.TextBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Синхрогруппа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Длина строки:";
            // 
            // frameMarkerTextBox
            // 
            this.frameMarkerTextBox.Location = new System.Drawing.Point(133, 23);
            this.frameMarkerTextBox.Name = "frameMarkerTextBox";
            this.frameMarkerTextBox.Size = new System.Drawing.Size(234, 20);
            this.frameMarkerTextBox.TabIndex = 2;
            // 
            // lStrTextBox
            // 
            this.lStrTextBox.Location = new System.Drawing.Point(133, 65);
            this.lStrTextBox.Name = "lStrTextBox";
            this.lStrTextBox.Size = new System.Drawing.Size(166, 20);
            this.lStrTextBox.TabIndex = 3;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ExecuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExecuteButton.Location = new System.Drawing.Point(59, 94);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(90, 23);
            this.ExecuteButton.TabIndex = 4;
            this.ExecuteButton.Text = "Выполнить";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButton.Location = new System.Drawing.Point(277, 91);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ConfigureFrameSyncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 129);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.lStrTextBox);
            this.Controls.Add(this.frameMarkerTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConfigureFrameSyncForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройка кадровой синхронизации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox frameMarkerTextBox;
        private System.Windows.Forms.TextBox lStrTextBox;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Button CancelButton;
    }
}