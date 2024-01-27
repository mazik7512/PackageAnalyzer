namespace PackageAnalyzerModule
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Файл = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulesTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PageIcons = new System.Windows.Forms.ImageList(this.components);
            this.SwipePanel = new System.Windows.Forms.Panel();
            this.tabsPanel = new System.Windows.Forms.Panel();
            this.tabsTree = new System.Windows.Forms.TreeView();
            this.SwipeButton = new System.Windows.Forms.Label();
            this.showTimer = new System.Windows.Forms.Timer(this.components);
            this.hideTimer = new System.Windows.Forms.Timer(this.components);
            this.contextTreeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moduleInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.modulesTabControl.SuspendLayout();
            this.SwipePanel.SuspendLayout();
            this.tabsPanel.SuspendLayout();
            this.contextTreeMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Файл});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Файл
            // 
            this.Файл.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФайлToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.Файл.Image = global::PackageAnalyzerModule.Resources.FileOpen;
            this.Файл.Name = "Файл";
            this.Файл.Size = new System.Drawing.Size(64, 20);
            this.Файл.Text = "Файл";
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Image = global::PackageAnalyzerModule.Resources.File;
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.открытьФайлToolStripMenuItem.Text = "Открыть файл";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = global::PackageAnalyzerModule.Resources.Exit;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // modulesTabControl
            // 
            this.modulesTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modulesTabControl.Controls.Add(this.tabPage1);
            this.modulesTabControl.Controls.Add(this.tabPage2);
            this.modulesTabControl.HotTrack = true;
            this.modulesTabControl.Location = new System.Drawing.Point(115, 28);
            this.modulesTabControl.Name = "modulesTabControl";
            this.modulesTabControl.SelectedIndex = 0;
            this.modulesTabControl.Size = new System.Drawing.Size(780, 563);
            this.modulesTabControl.TabIndex = 1;
            this.modulesTabControl.DragDrop += new System.Windows.Forms.DragEventHandler(this.modulesTabControl_DragDrop);
            this.modulesTabControl.DragEnter += new System.Windows.Forms.DragEventHandler(this.modulesTabControl_DragEnter);
            this.modulesTabControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.modulesTabControl_KeyDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(772, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(772, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PageIcons
            // 
            this.PageIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.PageIcons.ImageSize = new System.Drawing.Size(16, 16);
            this.PageIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // SwipePanel
            // 
            this.SwipePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SwipePanel.BackColor = System.Drawing.Color.SkyBlue;
            this.SwipePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SwipePanel.Controls.Add(this.tabsPanel);
            this.SwipePanel.Controls.Add(this.SwipeButton);
            this.SwipePanel.Location = new System.Drawing.Point(13, 28);
            this.SwipePanel.Name = "SwipePanel";
            this.SwipePanel.Size = new System.Drawing.Size(96, 559);
            this.SwipePanel.TabIndex = 2;
            // 
            // tabsPanel
            // 
            this.tabsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabsPanel.Controls.Add(this.tabsTree);
            this.tabsPanel.Location = new System.Drawing.Point(8, 39);
            this.tabsPanel.Name = "tabsPanel";
            this.tabsPanel.Size = new System.Drawing.Size(280, 516);
            this.tabsPanel.TabIndex = 1;
            this.tabsPanel.Visible = false;
            // 
            // tabsTree
            // 
            this.tabsTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabsTree.BackColor = System.Drawing.Color.Azure;
            this.tabsTree.Location = new System.Drawing.Point(3, 13);
            this.tabsTree.Name = "tabsTree";
            this.tabsTree.Size = new System.Drawing.Size(250, 497);
            this.tabsTree.TabIndex = 0;
            this.tabsTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tabsTree_AfterSelect);
            // 
            // SwipeButton
            // 
            this.SwipeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SwipeButton.AutoSize = true;
            this.SwipeButton.BackColor = System.Drawing.Color.SkyBlue;
            this.SwipeButton.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SwipeButton.Location = new System.Drawing.Point(6, 7);
            this.SwipeButton.Name = "SwipeButton";
            this.SwipeButton.Size = new System.Drawing.Size(45, 29);
            this.SwipeButton.TabIndex = 0;
            this.SwipeButton.Text = ">>";
            this.SwipeButton.Click += new System.EventHandler(this.SwipeButton_Click);
            // 
            // showTimer
            // 
            this.showTimer.Interval = 10;
            this.showTimer.Tick += new System.EventHandler(this.showTimer_Tick);
            // 
            // hideTimer
            // 
            this.hideTimer.Interval = 10;
            this.hideTimer.Tick += new System.EventHandler(this.hideTimer_Tick);
            // 
            // contextTreeMenu
            // 
            this.contextTreeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moduleInfo});
            this.contextTreeMenu.Name = "contextTreeMenu";
            this.contextTreeMenu.Size = new System.Drawing.Size(203, 26);
            // 
            // moduleInfo
            // 
            this.moduleInfo.Name = "moduleInfo";
            this.moduleInfo.Size = new System.Drawing.Size(202, 22);
            this.moduleInfo.Text = "Информация о модуле";
            this.moduleInfo.Click += new System.EventHandler(this.moduleInfo_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 594);
            this.Controls.Add(this.SwipePanel);
            this.Controls.Add(this.modulesTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAPDS - Module for analyzing and processing of demodulated streams";
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.modulesTabControl.ResumeLayout(false);
            this.SwipePanel.ResumeLayout(false);
            this.SwipePanel.PerformLayout();
            this.tabsPanel.ResumeLayout(false);
            this.contextTreeMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Файл;
        private System.Windows.Forms.TabControl modulesTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList PageIcons;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Panel SwipePanel;
        private System.Windows.Forms.Label SwipeButton;
        private System.Windows.Forms.Timer showTimer;
        private System.Windows.Forms.Timer hideTimer;
        private System.Windows.Forms.TreeView tabsTree;
        private System.Windows.Forms.Panel tabsPanel;
        private System.Windows.Forms.ContextMenuStrip contextTreeMenu;
        private System.Windows.Forms.ToolStripMenuItem moduleInfo;
    }
}

