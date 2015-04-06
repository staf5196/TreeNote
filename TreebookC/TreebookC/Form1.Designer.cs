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
            this.components = new System.ComponentModel.Container();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.editor = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.pageview = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.logo = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_deletepage = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_open = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_save = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_saveas = new System.Windows.Forms.ToolStripMenuItem();
            this.newdocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_print = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_more = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox2.BackColor = System.Drawing.Color.White;
            this.GroupBox2.Controls.Add(this.editor);
            this.GroupBox2.Location = new System.Drawing.Point(247, 141);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(367, 474);
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
            this.editor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editor.ForeColor = System.Drawing.Color.Black;
            this.editor.Location = new System.Drawing.Point(6, 19);
            this.editor.Multiline = true;
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(356, 447);
            this.editor.TabIndex = 0;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupBox1.BackColor = System.Drawing.Color.White;
            this.GroupBox1.Controls.Add(this.pageview);
            this.GroupBox1.Location = new System.Drawing.Point(12, 141);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(229, 386);
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
            this.pageview.Size = new System.Drawing.Size(217, 361);
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
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 533);
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
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Filter = "TreeNote Files (*.tnote)|*.tnote";
            // 
            // sfd
            // 
            this.sfd.Filter = "TreeNote Files (*.tnote)|*.tnote";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Gainsboro;
            this.logo.Image = global::TreebookC.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(8, 8);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(206, 57);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 14;
            this.logo.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPageToolStripMenuItem,
            this.headerToolStripMenuItem,
            this.menu_deletepage,
            this.menu_open,
            this.menu_save,
            this.menu_saveas,
            this.newdocToolStripMenuItem,
            this.menu_print,
            this.exportToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.menu_more});
            this.menuStrip1.Location = new System.Drawing.Point(213, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 38);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newPageToolStripMenuItem
            // 
            this.newPageToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newPageToolStripMenuItem.Image = global::TreebookC.Properties.Resources.file_save_final;
            this.newPageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newPageToolStripMenuItem.Name = "newPageToolStripMenuItem";
            this.newPageToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.newPageToolStripMenuItem.Size = new System.Drawing.Size(34, 34);
            this.newPageToolStripMenuItem.Click += new System.EventHandler(this.newPageToolStripMenuItem_Click_1);
            // 
            // headerToolStripMenuItem
            // 
            this.headerToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.headerToolStripMenuItem.Image = global::TreebookC.Properties.Resources.headericon21;
            this.headerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.headerToolStripMenuItem.Name = "headerToolStripMenuItem";
            this.headerToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.headerToolStripMenuItem.Size = new System.Drawing.Size(34, 34);
            this.headerToolStripMenuItem.Text = "Header";
            this.headerToolStripMenuItem.Click += new System.EventHandler(this.headerToolStripMenuItem_Click);
            // 
            // menu_deletepage
            // 
            this.menu_deletepage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menu_deletepage.Image = global::TreebookC.Properties.Resources.file_delete_final;
            this.menu_deletepage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_deletepage.Name = "menu_deletepage";
            this.menu_deletepage.Padding = new System.Windows.Forms.Padding(0);
            this.menu_deletepage.Size = new System.Drawing.Size(34, 34);
            this.menu_deletepage.Text = "New Header";
            this.menu_deletepage.Click += new System.EventHandler(this.menu_deletepage_Click);
            // 
            // menu_open
            // 
            this.menu_open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menu_open.Image = global::TreebookC.Properties.Resources.openfileicon;
            this.menu_open.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_open.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.menu_open.Name = "menu_open";
            this.menu_open.Padding = new System.Windows.Forms.Padding(0);
            this.menu_open.Size = new System.Drawing.Size(34, 34);
            this.menu_open.Text = "openfile";
            this.menu_open.Click += new System.EventHandler(this.openfileToolStripMenuItem_Click);
            // 
            // menu_save
            // 
            this.menu_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menu_save.Image = global::TreebookC.Properties.Resources.save_final2;
            this.menu_save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_save.Name = "menu_save";
            this.menu_save.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.menu_save.Size = new System.Drawing.Size(36, 34);
            this.menu_save.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // menu_saveas
            // 
            this.menu_saveas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menu_saveas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menu_saveas.Image = global::TreebookC.Properties.Resources.save_as_final2;
            this.menu_saveas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_saveas.Name = "menu_saveas";
            this.menu_saveas.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.menu_saveas.Size = new System.Drawing.Size(36, 34);
            this.menu_saveas.Text = "s";
            this.menu_saveas.Click += new System.EventHandler(this.menu_saveas_Click);
            // 
            // newdocToolStripMenuItem
            // 
            this.newdocToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newdocToolStripMenuItem.Image = global::TreebookC.Properties.Resources.refreshicon2;
            this.newdocToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newdocToolStripMenuItem.Name = "newdocToolStripMenuItem";
            this.newdocToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.newdocToolStripMenuItem.Size = new System.Drawing.Size(34, 34);
            this.newdocToolStripMenuItem.Text = "Newdoc";
            this.newdocToolStripMenuItem.Click += new System.EventHandler(this.newdocToolStripMenuItem_Click);
            // 
            // menu_print
            // 
            this.menu_print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menu_print.Image = global::TreebookC.Properties.Resources.printericon;
            this.menu_print.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_print.Name = "menu_print";
            this.menu_print.Padding = new System.Windows.Forms.Padding(0);
            this.menu_print.Size = new System.Drawing.Size(34, 34);
            this.menu_print.Text = "Print";
            this.menu_print.Click += new System.EventHandler(this.menu_print_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportToolStripMenuItem.Image = global::TreebookC.Properties.Resources.exporticon;
            this.exportToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(34, 34);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settingsToolStripMenuItem.Image = global::TreebookC.Properties.Resources.settingsicon21;
            this.settingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(42, 34);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // menu_more
            // 
            this.menu_more.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menu_more.Image = global::TreebookC.Properties.Resources.moreicon;
            this.menu_more.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_more.Margin = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.menu_more.Name = "menu_more";
            this.menu_more.Size = new System.Drawing.Size(42, 34);
            this.menu_more.Text = "More";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 135);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel1.Controls.Add(this.textBox2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(225, 46);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(354, 47);
            this.flowLayoutPanel1.TabIndex = 16;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(78, 23);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "TreeNote";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 619);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.MinimumSize = new System.Drawing.Size(637, 503);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_deletepage;
        private System.Windows.Forms.ToolStripMenuItem menu_open;
        private System.Windows.Forms.ToolStripMenuItem menu_save;
        private System.Windows.Forms.ToolStripMenuItem menu_saveas;
        private System.Windows.Forms.ToolStripMenuItem newdocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_print;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_more;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
    }
}

