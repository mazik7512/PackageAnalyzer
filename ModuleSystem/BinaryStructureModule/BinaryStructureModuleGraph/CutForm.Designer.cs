﻿namespace BinaryStructureModuleGraph
{
    partial class CutForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.footerLengthTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.headerLengthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButton.Location = new System.Drawing.Point(188, 101);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ExecuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExecuteButton.Location = new System.Drawing.Point(15, 101);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(75, 23);
            this.ExecuteButton.TabIndex = 14;
            this.ExecuteButton.Text = "Выполнить";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "байт";
            // 
            // footerLengthTextBox
            // 
            this.footerLengthTextBox.Location = new System.Drawing.Point(117, 60);
            this.footerLengthTextBox.Name = "footerLengthTextBox";
            this.footerLengthTextBox.Size = new System.Drawing.Size(110, 20);
            this.footerLengthTextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Усечение конца:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "байт";
            // 
            // headerLengthTextBox
            // 
            this.headerLengthTextBox.Location = new System.Drawing.Point(117, 19);
            this.headerLengthTextBox.Name = "headerLengthTextBox";
            this.headerLengthTextBox.Size = new System.Drawing.Size(110, 20);
            this.headerLengthTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Усечение начала:";
            // 
            // CutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 143);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.footerLengthTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.headerLengthTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CutForm";
            this.Text = "Конфигурация усечения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox footerLengthTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox headerLengthTextBox;
        private System.Windows.Forms.Label label1;
    }
}