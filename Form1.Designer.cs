
using System;

namespace AfterburnerMonitor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxShow = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxStart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.contextMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Afterburner Monitor";
            this.trayIcon.Visible = true;
            this.trayIcon.DoubleClick += new System.EventHandler(this.Tray_DoubleClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxShow,
            this.ctxStart,
            this.toolStripSeparator1,
            this.ctxExit});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(134, 76);
            // 
            // ctxShow
            // 
            this.ctxShow.Name = "ctxShow";
            this.ctxShow.Size = new System.Drawing.Size(133, 22);
            this.ctxShow.Text = "Show";
            // 
            // ctxStart
            // 
            this.ctxStart.Name = "ctxStart";
            this.ctxStart.Size = new System.Drawing.Size(133, 22);
            this.ctxStart.Text = "Start / Stop";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // ctxExit
            // 
            this.ctxExit.Name = "ctxExit";
            this.ctxExit.Size = new System.Drawing.Size(133, 22);
            this.ctxExit.Text = "Exit";
            // 
            // pathBox
            // 
            this.pathBox.Enabled = false;
            this.pathBox.Location = new System.Drawing.Point(12, 12);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(237, 23);
            this.pathBox.TabIndex = 1;
            this.pathBox.Text = "MSI Afterburner Path";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(255, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(94, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Choose File";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 56);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 38);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(84, 15);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Power Status : ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 91);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.pathBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afterburner Monitor";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxShow;
        private System.Windows.Forms.ToolStripMenuItem ctxStart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ctxExit;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label labelStatus;
    }
}

