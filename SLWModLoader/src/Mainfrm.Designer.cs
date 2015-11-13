﻿namespace SLWModLoader
{
    partial class Mainfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainfrm));
            this.modslist = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vcolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorcolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.savecolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.updatedcolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.refreshlbl = new System.Windows.Forms.LinkLabel();
            this.nomodsfound = new System.Windows.Forms.Label();
            this.MoveDownAll = new System.Windows.Forms.Button();
            this.MoveUpAll = new System.Windows.Forms.Button();
            this.MoveDownbtn = new System.Windows.Forms.Button();
            this.MoveUpbtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.modsdirbtn = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.modsdir = new System.Windows.Forms.TextBox();
            this.playbtn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statuslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // modslist
            // 
            this.modslist.CheckBoxes = true;
            this.modslist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.vcolumn,
            this.authorcolumn,
            this.savecolumn,
            this.updatedcolumn});
            this.modslist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modslist.Location = new System.Drawing.Point(0, 0);
            this.modslist.MultiSelect = false;
            this.modslist.Name = "modslist";
            this.modslist.Size = new System.Drawing.Size(501, 405);
            this.modslist.TabIndex = 0;
            this.modslist.UseCompatibleStateImageBehavior = false;
            this.modslist.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 175;
            // 
            // vcolumn
            // 
            this.vcolumn.Text = "V";
            this.vcolumn.Width = 31;
            // 
            // authorcolumn
            // 
            this.authorcolumn.Text = "Author";
            this.authorcolumn.Width = 119;
            // 
            // savecolumn
            // 
            this.savecolumn.Text = "Save";
            this.savecolumn.Width = 66;
            // 
            // updatedcolumn
            // 
            this.updatedcolumn.Text = "Updated";
            this.updatedcolumn.Width = 90;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.tabControl1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(548, 444);
            this.panel.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(548, 444);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.splitContainer);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(540, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mods";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(3, 3);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.refreshlbl);
            this.splitContainer.Panel1.Controls.Add(this.nomodsfound);
            this.splitContainer.Panel1.Controls.Add(this.modslist);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.MoveDownAll);
            this.splitContainer.Panel2.Controls.Add(this.MoveUpAll);
            this.splitContainer.Panel2.Controls.Add(this.MoveDownbtn);
            this.splitContainer.Panel2.Controls.Add(this.MoveUpbtn);
            this.splitContainer.Size = new System.Drawing.Size(534, 405);
            this.splitContainer.SplitterDistance = 501;
            this.splitContainer.TabIndex = 5;
            // 
            // refreshlbl
            // 
            this.refreshlbl.BackColor = System.Drawing.Color.Transparent;
            this.refreshlbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.refreshlbl.Location = new System.Drawing.Point(187, 245);
            this.refreshlbl.Name = "refreshlbl";
            this.refreshlbl.Size = new System.Drawing.Size(127, 21);
            this.refreshlbl.TabIndex = 4;
            this.refreshlbl.TabStop = true;
            this.refreshlbl.Text = "Refresh Mod List";
            this.refreshlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.refreshlbl.Visible = false;
            this.refreshlbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refreshlbl_Click);
            // 
            // nomodsfound
            // 
            this.nomodsfound.BackColor = System.Drawing.Color.Transparent;
            this.nomodsfound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nomodsfound.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nomodsfound.ForeColor = System.Drawing.Color.Red;
            this.nomodsfound.Location = new System.Drawing.Point(0, 0);
            this.nomodsfound.Name = "nomodsfound";
            this.nomodsfound.Size = new System.Drawing.Size(501, 405);
            this.nomodsfound.TabIndex = 4;
            this.nomodsfound.Text = "No mods found!\r\nPlease check your mod folder.";
            this.nomodsfound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nomodsfound.Visible = false;
            // 
            // MoveDownAll
            // 
            this.MoveDownAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MoveDownAll.Location = new System.Drawing.Point(3, 306);
            this.MoveDownAll.Name = "MoveDownAll";
            this.MoveDownAll.Size = new System.Drawing.Size(19, 100);
            this.MoveDownAll.TabIndex = 3;
            this.MoveDownAll.Text = "↓";
            this.MoveDownAll.UseVisualStyleBackColor = true;
            this.MoveDownAll.Click += new System.EventHandler(this.MoveDownAll_Click);
            // 
            // MoveUpAll
            // 
            this.MoveUpAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MoveUpAll.Location = new System.Drawing.Point(3, 3);
            this.MoveUpAll.Name = "MoveUpAll";
            this.MoveUpAll.Size = new System.Drawing.Size(19, 100);
            this.MoveUpAll.TabIndex = 2;
            this.MoveUpAll.Text = "↑";
            this.MoveUpAll.UseVisualStyleBackColor = true;
            this.MoveUpAll.Click += new System.EventHandler(this.MoveUpAll_Click);
            // 
            // MoveDownbtn
            // 
            this.MoveDownbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MoveDownbtn.Location = new System.Drawing.Point(3, 205);
            this.MoveDownbtn.Name = "MoveDownbtn";
            this.MoveDownbtn.Size = new System.Drawing.Size(19, 100);
            this.MoveDownbtn.TabIndex = 1;
            this.MoveDownbtn.Text = "▼";
            this.MoveDownbtn.UseVisualStyleBackColor = true;
            this.MoveDownbtn.Click += new System.EventHandler(this.MoveDownbtn_Click);
            // 
            // MoveUpbtn
            // 
            this.MoveUpbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MoveUpbtn.Location = new System.Drawing.Point(3, 104);
            this.MoveUpbtn.Name = "MoveUpbtn";
            this.MoveUpbtn.Size = new System.Drawing.Size(19, 100);
            this.MoveUpbtn.TabIndex = 0;
            this.MoveUpbtn.Text = "▲";
            this.MoveUpbtn.UseVisualStyleBackColor = true;
            this.MoveUpbtn.Click += new System.EventHandler(this.MoveUpbtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.modsdirbtn);
            this.tabPage2.Controls.Add(this.label);
            this.tabPage2.Controls.Add(this.modsdir);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(540, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(132, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "&About SLW Mod Loader";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // modsdirbtn
            // 
            this.modsdirbtn.AutoSize = true;
            this.modsdirbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.modsdirbtn.Location = new System.Drawing.Point(481, 7);
            this.modsdirbtn.Name = "modsdirbtn";
            this.modsdirbtn.Size = new System.Drawing.Size(49, 29);
            this.modsdirbtn.TabIndex = 3;
            this.modsdirbtn.Text = "...";
            this.modsdirbtn.UseVisualStyleBackColor = true;
            this.modsdirbtn.Click += new System.EventHandler(this.modsdirbtn_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(11, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(112, 20);
            this.label.TabIndex = 2;
            this.label.Text = "SLW directory:";
            // 
            // modsdir
            // 
            this.modsdir.Location = new System.Drawing.Point(145, 10);
            this.modsdir.Name = "modsdir";
            this.modsdir.Size = new System.Drawing.Size(330, 26);
            this.modsdir.TabIndex = 1;
            this.modsdir.TextChanged += new System.EventHandler(this.modsdir_TextChanged);
            // 
            // playbtn
            // 
            this.playbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.playbtn.Location = new System.Drawing.Point(19, 450);
            this.playbtn.Name = "playbtn";
            this.playbtn.Size = new System.Drawing.Size(515, 43);
            this.playbtn.TabIndex = 3;
            this.playbtn.Text = "Play";
            this.playbtn.UseVisualStyleBackColor = true;
            this.playbtn.Click += new System.EventHandler(this.playbtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.refreshbtn.Location = new System.Drawing.Point(124, 499);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(300, 33);
            this.refreshbtn.TabIndex = 4;
            this.refreshbtn.Text = "Refresh Mod List";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.White;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslbl});
            this.statusStrip.Location = new System.Drawing.Point(0, 540);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(548, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statuslbl
            // 
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 405);
            this.label1.TabIndex = 9;
            this.label1.Text = "More options coming soon! :)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mainfrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 562);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.playbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mainfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SLW Mod Loader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainfrm_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView modslist;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader vcolumn;
        private System.Windows.Forms.ColumnHeader authorcolumn;
        private System.Windows.Forms.ColumnHeader savecolumn;
        private System.Windows.Forms.ColumnHeader updatedcolumn;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox modsdir;
        private System.Windows.Forms.Button modsdirbtn;
        private System.Windows.Forms.Button playbtn;
        private System.Windows.Forms.Label nomodsfound;
        private System.Windows.Forms.LinkLabel refreshlbl;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button MoveDownbtn;
        private System.Windows.Forms.Button MoveUpbtn;
        private System.Windows.Forms.Button MoveDownAll;
        private System.Windows.Forms.Button MoveUpAll;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statuslbl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
