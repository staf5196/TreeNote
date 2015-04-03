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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logo = new System.Windows.Forms.PictureBox();
            this.newPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_deletepage = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_save = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_saveas = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_print = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox2.BackColor = System.Drawing.Color.White;
            this.GroupBox2.Controls.Add(this.editor);
            this.GroupBox2.Location = new System.Drawing.Point(247, 72);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(480, 437);
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
            this.editor.Size = new System.Drawing.Size(469, 410);
            this.editor.TabIndex = 0;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupBox1.BackColor = System.Drawing.Color.White;
            this.GroupBox1.Controls.Add(this.pageview);
            this.GroupBox1.Location = new System.Drawing.Point(12, 72);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(229, 349);
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
            this.pageview.Size = new System.Drawing.Size(217, 324);
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
            this.groupBox3.Location = new System.Drawing.Point(12, 427);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel1.Controls.Add(this.logo);
            this.flowLayoutPanel1.Controls.Add(this.menuStrip1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(732, 66);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPageToolStripMenuItem,
            this.menu_deletepage,
            this.menu_save,
            this.menu_saveas,
            this.menu_print});
            this.menuStrip1.Location = new System.Drawing.Point(212, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(186, 38);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logo
            // 
            this.logo.Image = global::TreebookC.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(3, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(206, 57);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 14;
            this.logo.TabStop = false;
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
            // menu_deletepage
            // 
            this.menu_deletepage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menu_deletepage.Image = global::TreebookC.Properties.Resources.file_delete_final;
            this.menu_deletepage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_deletepage.Name = "menu_deletepage";
            this.menu_deletepage.Padding = new System.Windows.Forms.Padding(0);
            this.menu_deletepage.Size = new System.Drawing.Size(34, 34);
            this.menu_deletepage.Text = "New Header";
            // 
            // menu_save
            // 
            this.menu_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menu_save.Image = global::TreebookC.Properties.Resources.save_final2;
            this.menu_save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_save.Name = "menu_save";
            this.menu_save.Padding = new System.Windows.Forms.Padding(0);
            this.menu_save.Size = new System.Drawing.Size(34, 34);
            this.menu_save.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // menu_saveas
            // 
            this.menu_saveas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menu_saveas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menu_saveas.Image = global::TreebookC.Properties.Resources.save_as_final2;
            this.menu_saveas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_saveas.Name = "menu_saveas";
            this.menu_saveas.Padding = new System.Windows.Forms.Padding(0);
            this.menu_saveas.Size = new System.Drawing.Size(34, 34);
            this.menu_saveas.Text = "s";
            // 
            // menu_print
            // 
            this.menu_print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menu_print.Image = global::TreebookC.Properties.Resources.printericon;
            this.menu_print.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_print.Name = "menu_print";
            this.menu_print.Size = new System.Drawing.Size(42, 34);
            this.menu_print.Text = "Print";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(0, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(744, 456);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 513);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.pictureBox2);
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
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_deletepage;
        private System.Windows.Forms.ToolStripMenuItem menu_save;
        private System.Windows.Forms.ToolStripMenuItem menu_saveas;
        private System.Windows.Forms.ToolStripMenuItem menu_print;
    }
}

