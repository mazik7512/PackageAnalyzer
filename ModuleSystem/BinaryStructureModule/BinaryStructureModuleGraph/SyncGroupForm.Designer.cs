namespace BinaryStructureModuleGraph
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
            this.label1 = new System.Windows.Forms.Label();
            this.frameMarkerTextBox = new System.Windows.Forms.TextBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Синхрокомбинация:";
            // 
            // frameMarkerTextBox
            // 
            this.frameMarkerTextBox.Location = new System.Drawing.Point(137, 29);
            this.frameMarkerTextBox.Name = "frameMarkerTextBox";
            this.frameMarkerTextBox.Size = new System.Drawing.Size(234, 20);
            this.frameMarkerTextBox.TabIndex = 1;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ExecuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExecuteButton.Location = new System.Drawing.Point(46, 81);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(90, 23);
            this.ExecuteButton.TabIndex = 2;
            this.ExecuteButton.Text = "Установить";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButton.Location = new System.Drawing.Point(254, 81);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SyncGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 126);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.frameMarkerTextBox);
            this.Controls.Add(this.label1);
            this.Name = "SyncGroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SyncGroupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox frameMarkerTextBox;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Button CancelButton;
    }
}