namespace TreebookC
{
    partial class Form1
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.editor = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.pageview = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menu_newpage = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toOneNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toNotepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_newheader = new System.Windows.Forms.Button();
            this.menu_deletepage = new System.Windows.Forms.Button();
            this.menu_save = new System.Windows.Forms.Button();
            this.menu_open = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox2.Controls.Add(this.editor);
            this.GroupBox2.Location = new System.Drawing.Point(247, 31);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(334, 430);
            this.GroupBox2.TabIndex = 6;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Page";
            // 
            // editor
            // 
            this.editor.AcceptsReturn = true;
            this.editor.AcceptsTab = true;
            this.editor.AllowDrop = true;
            this.editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editor.BackColor = System.Drawing.Color.White;
            this.editor.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editor.ForeColor = System.Drawing.Color.Black;
            this.editor.Location = new System.Drawing.Point(6, 19);
            this.editor.Multiline = true;
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(322, 403);
            this.editor.TabIndex = 0;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupBox1.Controls.Add(this.pageview);
            this.GroupBox1.Location = new System.Drawing.Point(12, 31);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(229, 342);
            this.GroupBox1.TabIndex = 5;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Tree";
            // 
            // pageview
            // 
            this.pageview.AllowDrop = true;
            this.pageview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pageview.Indent = 12;
            this.pageview.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.pageview.Location = new System.Drawing.Point(6, 19);
            this.pageview.Name = "pageview";
            this.pageview.Size = new System.Drawing.Size(217, 317);
            this.pageview.TabIndex = 0;
            this.pageview.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.pageview_AfterCheck);
            this.pageview.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.pageview_ItemDrag);
            this.pageview.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.pageview_BeforeSelect);
            this.pageview.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.pageview_AfterSelect);
            this.pageview.TabIndexChanged += new System.EventHandler(this.pageview_TabIndexChanged);
            this.pageview.DragDrop += new System.Windows.Forms.DragEventHandler(this.pageview_DragDrop);
            this.pageview.DragEnter += new System.Windows.Forms.DragEventHandler(this.pageview_DragEnter);
            this.pageview.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.pageview_ChangeUICues);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 379);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 82);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Properties";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 57);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Header";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(78, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Page Name:";
            // 
            // menu_newpage
            // 
            this.menu_newpage.ForeColor = System.Drawing.Color.Black;
            this.menu_newpage.Location = new System.Drawing.Point(102, 2);
            this.menu_newpage.Name = "menu_newpage";
            this.menu_newpage.Size = new System.Drawing.Size(78, 23);
            this.menu_newpage.TabIndex = 8;
            this.menu_newpage.Text = "New Page";
            this.menu_newpage.UseVisualStyleBackColor = true;
            this.menu_newpage.Click += new System.EventHandler(this.menu_newpage_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.saveCurrentPageToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.saveAllToolStripMenuItem.Text = "Save";
            // 
            // saveCurrentPageToolStripMenuItem
            // 
            this.saveCurrentPageToolStripMenuItem.Name = "saveCurrentPageToolStripMenuItem";
            this.saveCurrentPageToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.saveCurrentPageToolStripMenuItem.Text = "Save Current Page";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toOneNoteToolStripMenuItem,
            this.toNotepadToolStripMenuItem,
            this.toWordToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // toOneNoteToolStripMenuItem
            // 
            this.toOneNoteToolStripMenuItem.Name = "toOneNoteToolStripMenuItem";
            this.toOneNoteToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.toOneNoteToolStripMenuItem.Text = "To OneNote";
            // 
            // toNotepadToolStripMenuItem
            // 
            this.toNotepadToolStripMenuItem.Name = "toNotepadToolStripMenuItem";
            this.toNotepadToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.toNotepadToolStripMenuItem.Text = "To Notepad";
            // 
            // toWordToolStripMenuItem
            // 
            this.toWordToolStripMenuItem.Name = "toWordToolStripMenuItem";
            this.toWordToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.toWordToolStripMenuItem.Text = "To Word";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.treeSettingsToolStripMenuItem,
            this.editorSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // treeSettingsToolStripMenuItem
            // 
            this.treeSettingsToolStripMenuItem.Name = "treeSettingsToolStripMenuItem";
            this.treeSettingsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.treeSettingsToolStripMenuItem.Text = "Tree Settings";
            // 
            // editorSettingsToolStripMenuItem
            // 
            this.editorSettingsToolStripMenuItem.Name = "editorSettingsToolStripMenuItem";
            this.editorSettingsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.editorSettingsToolStripMenuItem.Text = "Editor Settings";
            // 
            // menu_newheader
            // 
            this.menu_newheader.ForeColor = System.Drawing.Color.Black;
            this.menu_newheader.Location = new System.Drawing.Point(186, 2);
            this.menu_newheader.Name = "menu_newheader";
            this.menu_newheader.Size = new System.Drawing.Size(78, 23);
            this.menu_newheader.TabIndex = 10;
            this.menu_newheader.Text = "New Header";
            this.menu_newheader.UseVisualStyleBackColor = true;
            this.menu_newheader.Click += new System.EventHandler(this.menu_newheader_Click);
            // 
            // menu_deletepage
            // 
            this.menu_deletepage.ForeColor = System.Drawing.Color.Black;
            this.menu_deletepage.Location = new System.Drawing.Point(270, 2);
            this.menu_deletepage.Name = "menu_deletepage";
            this.menu_deletepage.Size = new System.Drawing.Size(78, 23);
            this.menu_deletepage.TabIndex = 11;
            this.menu_deletepage.Text = "Delete Page";
            this.menu_deletepage.UseVisualStyleBackColor = true;
            // 
            // menu_save
            // 
            this.menu_save.ForeColor = System.Drawing.Color.Black;
            this.menu_save.Location = new System.Drawing.Point(354, 2);
            this.menu_save.Name = "menu_save";
            this.menu_save.Size = new System.Drawing.Size(78, 23);
            this.menu_save.TabIndex = 12;
            this.menu_save.Text = "Save";
            this.menu_save.UseVisualStyleBackColor = true;
            // 
            // menu_open
            // 
            this.menu_open.ForeColor = System.Drawing.Color.Black;
            this.menu_open.Location = new System.Drawing.Point(438, 2);
            this.menu_open.Name = "menu_open";
            this.menu_open.Size = new System.Drawing.Size(78, 23);
            this.menu_open.TabIndex = 13;
            this.menu_open.Text = "Open";
            this.menu_open.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(588, 465);
            this.Controls.Add(this.menu_open);
            this.Controls.Add(this.menu_save);
            this.Controls.Add(this.menu_deletepage);
            this.Controls.Add(this.menu_newheader);
            this.Controls.Add(this.menu_newpage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(604, 503);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox editor;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TreeView pageview;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button menu_newpage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toOneNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toNotepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Button menu_newheader;
        private System.Windows.Forms.Button menu_deletepage;
        private System.Windows.Forms.Button menu_save;
        private System.Windows.Forms.Button menu_open;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treeSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorSettingsToolStripMenuItem;
    }
}

