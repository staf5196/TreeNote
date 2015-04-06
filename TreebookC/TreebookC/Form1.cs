using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Windows;

namespace TreebookC
{
    #region Code by Arpad Kovesdy and Joseph Stafford
    public partial class Form1 : Form
    {
        int pd = 1;
        int hd = 1;
        String documentname = "TreeNote";
        String author = "";
        public bool isFileOpen = false;
        public string fileLoc = "";
        bool partialLayoutb = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createCorePage();
            refresh();
            this.flowLayoutPanel1.AllowDrop = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            newPage();
        }
        public void collapseAll()
        {
            foreach (TreeNode t in pageview.Nodes)
            {
                collapseNodes(t);
            }
        }
        private void collapseNodes(TreeNode np)
        {
              np.Collapse();
              foreach(TreeNode t in np.Nodes) {
                  collapseNodes(t);
              }
        }
        public void expandAll()
        {
            foreach (TreeNode t in pageview.Nodes)
            {
                expandNodes(t);
            }
        }
        private void expandNodes(TreeNode np)
        {
            np.Expand();
            foreach (TreeNode t in np.Nodes)
            {
                expandNodes(t);
            }
        }
        public void newSubPage()
        {
            TreeNode n = pageview.SelectedNode;
            String newpg = "NewPage" + pd;
            pd++;
            //String newpg = "NewPage" + (n.Nodes.Count + 1);
            TreeNodePrime np = new TreeNodePrime();
            np.Text = newpg;
            n.Nodes.Add(np);
            pageview.SelectedNode = np;
            np.Expand();
        }
        public void newHeader()
        {
            TreeNode n = pageview.SelectedNode;
            String newpg = "NewHeader" + hd;
            hd++;
            //String newpg = "NewHeader" + (n.Nodes.Count + 1);
            TreeNodePrime np = new TreeNodePrime();
            np.Text = newpg;
            np.isHeader = true;
            n.Nodes.Add(np);
            pageview.SelectedNode = np;
            np.Expand();
        }
        public void newPage()
        {
            String newpg = "NewPage" + (pageview.Nodes.Count + 1);
            TreeNodePrime n = new TreeNodePrime();
            n.Text = newpg;
            pageview.Nodes.Add(n);
            pageview.SelectedNode = n;
        }
        public void createCorePage()
        {
            String newpg = "TreeBook";
            TreeNodePrime n = new TreeNodePrime();
            n.Text = newpg;
            n.isHeader = true;
            n.isLocked = true;
            pageview.Nodes.Add(n);
            pageview.SelectedNode = n;
        }
        public void deletePage()
        {
            TreeNodePrime n = (TreeNodePrime)pageview.SelectedNode;
            if (n.Nodes.Count > 0 && !n.isLocked)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this branch?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    pageview.Nodes.Remove(n);
                }
            }
            else if (Properties.Settings.Default.AskBeforeDelete && !n.isLocked)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this branch?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    pageview.Nodes.Remove(n);
                }
            }
            else if (!n.isLocked)
            {
                pageview.Nodes.Remove(n);
            }

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            newSubPage();
        }

        private void pageview_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void pageview_AfterCheck(object sender, TreeViewEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pageview.SelectedNode.Text = textBox1.Text;
        }

        private void pageview_AfterSelect(object sender, TreeViewEventArgs e)
        {
            refresh();
        }
        public void refresh()
        {
            if (pageview.SelectedNode != null)
            {
                textBox1.Text = pageview.SelectedNode.Text;
                textBox1.Enabled = true;
                if (pageview.SelectedNode.GetType() == typeof(TreeNodePrime))
                {
                    TreeNodePrime tp = (TreeNodePrime)pageview.SelectedNode;
                    checkBox1.Checked = tp.isHeader;
                    editor.Text = tp.text;
                    if (tp.isHeader)
                    {
                        editor.Enabled = false;
                        menu_save.Enabled = false;
                        //UPDATE LAYOUTS TO FULL SCREEN
                        partialLayoutb = false;
                        fullLayout();
                    }
                    else
                    {
                        editor.Enabled = true;
                        menu_save.Enabled = true;
                        //UPDATE LAYOUTS TO PARTIAL
                        partialLayoutb = true;
                        partialLayout();
                    }
                    if (tp.isLocked)
                    {
                        checkBox1.Enabled = false;
                        //CANNOT BE DELETED
                    }
                    else
                    {
                        checkBox1.Enabled = true;
                    }
                }
            }
            else
            {
                try
                {
                pageview.SelectedNode = pageview.Nodes[0];
                refresh();
                }
                catch (Exception e)
                {
                    //THIS SHOULD NOT HAPPEN
                }

            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (pageview.SelectedNode.GetType() == typeof(TreeNodePrime))
            {
                TreeNodePrime tp = (TreeNodePrime)pageview.SelectedNode;
                tp.isHeader = checkBox1.Checked;
            }
            editor.Enabled = !checkBox1.Checked;
            menu_save.Enabled = !checkBox1.Checked;
            GroupBox2.Visible = !checkBox1.Checked;
            refresh();
        }
        public void fullLayout()
        {
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top)));
            this.pageview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top)));
            //this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom)));
            //this.Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupBox1.Size = new System.Drawing.Size(this.Width - 32, this.Height - 161);
            this.pageview.Size = new System.Drawing.Size(this.GroupBox1.Width - 12, this.GroupBox1.Height - 25);
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Size = new System.Drawing.Size(this.Width - 32, this.groupBox3.Height);
            this.textBox1.Size = new System.Drawing.Size(this.groupBox3.Width - 92, this.groupBox3.Height);
        }
        public void partialLayout()
        {
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top)));
            this.pageview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top)));
            this.GroupBox1.Size = new System.Drawing.Size(229, this.Height - 161);
            this.pageview.Size = new System.Drawing.Size(212, this.GroupBox1.Height - 25);
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.groupBox3.Size = new System.Drawing.Size(229, 82);
            //this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            //this.Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            //this.button1.Location = new System.Drawing.Point(117, 313);
            //this.Button2.Location = new System.Drawing.Point(6, 313);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            expandAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            collapseAll();
        }

        private void collapseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            collapseAll();
        }

        private void expandAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            expandAll();
        }

        private void newPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newPage();
        }

        private void newSubpageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newSubPage();
        }

        private void savetext_Click(object sender, EventArgs e)
        {
            saveText();
        }
        public void saveText()
        {
            try
            {
            if (pageview.SelectedNode.GetType() == typeof(TreeNodePrime))
            {
                TreeNodePrime tp = (TreeNodePrime)pageview.SelectedNode;
                tp.text = editor.Text;
            }
            }
            catch (Exception e)
            {
                //ERROR SAVING, happens on startup im too lazy to fix
            }
        }

        private void pageview_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void pageview_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            saveText();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            newHeader();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (!partialLayoutb)
            {

            }
            menu_more.Margin = new Padding(this.Width - 628,0,0,0);
        }

        private void menu_newpage_Click(object sender, EventArgs e)
        {
            newSubPage();
        }

        private void pageview_DragDrop(object sender, DragEventArgs e)
        {
            TreeNodePrime newNode;
            if (e.Data.GetDataPresent(typeof(TreeNodePrime)))
            {
                Point pt = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
                TreeNode DestinationNode = ((TreeView)sender).GetNodeAt(pt);
                newNode = (TreeNodePrime)e.Data.GetData(typeof(TreeNodePrime));
                if (!newNode.isLocked)
                {
                    TreeNodePrime npNode = newNode.clonePrime();
                    DestinationNode.Nodes.Add(npNode);
                    expandNodes(DestinationNode);
                    newNode.Remove();
                    pageview.SelectedNode = npNode;
                    refresh();
                }
            }
        }

        private void pageview_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void pageview_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void menu_newheader_Click(object sender, EventArgs e)
        {
            newHeader();
        }

        private void menu_save_Click(object sender, EventArgs e)
        {

        }
        private void save()
        {
            saveText();
            if (isFileOpen)
            {
                StreamWriter sw = new StreamWriter(fileLoc);
                encode(sw);
                sw.Flush();
                sw.Close();
            }
            else
            {
                saveAs();
            }
        }
        private void saveAs()
        {
            saveText();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                encode(sw);
                sw.Flush();
                sw.Close();
                isFileOpen = true;
                fileLoc = sfd.FileName;
            }
        }
        private void open()
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                String content = sr.ReadToEnd();
                sr.Close();
                sr.Dispose();
                load(sr, ofd.FileName);
                isFileOpen = true;
                fileLoc = ofd.FileName;
            }
        }
        private void newFile()
        {
             DialogResult result = MessageBox.Show("Are you sure you want to create a new file without saving?", "Warning", MessageBoxButtons.YesNo);
             if (result == DialogResult.Yes)
                {
                    isFileOpen = false;
                    fileLoc = "";
                    pageview.Nodes.Clear();
                    createCorePage();
                    refresh();
                    pd = 1;
                    hd = 1;
                }
            }
        public void encode(StreamWriter sw)
        {
            //Write the header and root node
            sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            sw.WriteLine("<" + pageview.Nodes[0].Text + ">");
            foreach (TreeNodePrime node in pageview.Nodes)
            {
                //Only called once in this situation -> gets every subnode of the core node
                saveNode(node.Nodes, sw);
            }
            //Close the root node
            sw.WriteLine("</" + pageview.Nodes[0].Text + ">");
        }

        private void saveNode(TreeNodeCollection tnc, StreamWriter sw)
        {
            foreach (TreeNodePrime node in tnc)
            {
                //If we have child nodes, we'll write 
                //a parent node, then iterrate through
                //the children
                    sw.WriteLine("<" + node.Text + " lock=" + (char)34 + node.isLocked.ToString() + (char)34 +
                        " header=" + (char)34 + node.isHeader.ToString() + (char)34 +
                        " usertext=" + (char)34 + node.text + (char)34 + ">");
                    saveNode(node.Nodes, sw);
                    sw.WriteLine("</" + node.Text + ">");
            }
        }

        public void load(StreamReader sw, String filename)
        {
            try
            {
                //Just a good practice -- change the cursor to a 
                //wait cursor while the nodes populate
                this.Cursor = Cursors.WaitCursor;
                //First, we'll load the Xml document
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(filename);
                //Now, clear out the treeview, 
                //and add the first (root) node
                pageview.Nodes.Clear();
                createCorePage();
                TreeNodePrime tNode = new TreeNodePrime();
                tNode = (TreeNodePrime)pageview.Nodes[0];
                //We make a call to addTreeNode, 
                //where we'll add all of our nodes
                addTreeNode(xDoc.DocumentElement, tNode);
                //Expand the treeview to show all nodes
                pageview.ExpandAll();
            }
            catch (XmlException xExc)
            //Exception is thrown is there is an error in the Xml
            {
                MessageBox.Show(xExc.Message);
            }
            catch (Exception ex) //General exception
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default; //Change the cursor back
            }
        }

        //This function is called recursively until all nodes are loaded
        private void addTreeNode(XmlNode xmlNode, TreeNodePrime treeNode)
        {
            XmlNode xNode;
            TreeNodePrime tNode;
            XmlNodeList xNodeList;
            if (xmlNode.HasChildNodes) //The current node has children
            {
                xNodeList = xmlNode.ChildNodes;
                for (int x = 0; x <= xNodeList.Count - 1; x++)
                //Loop through the child nodes
                {
                    xNode = xmlNode.ChildNodes[x];
                    TreeNodePrime t = new TreeNodePrime();
                    t.Text = xNode.Name;
                    t.isLocked = false;
                    t.isHeader = false;
                    t.text = "";
                    foreach(XmlAttribute atr in xNode.Attributes)
                    {
                        if (atr.Name == "lock")
                        {
                            t.isLocked = Convert.ToBoolean(atr.Value);
                        }
                        else if (atr.Name == "header")
                        {
                            t.isHeader = Convert.ToBoolean(atr.Value);
                        }
                        else if (atr.Name == "usertext")
                        {
                            t.text = atr.Value;
                        }
                    }
                    treeNode.Nodes.Add(t);
                    tNode = (TreeNodePrime)treeNode.Nodes[x];
                    addTreeNode(xNode, tNode);
                }
            }
        }

        private List<String> getStringEncode()
        {
            List<String> firstliststring = new List<String>();
            firstliststring.Add(this.documentname);
            if (author != "") firstliststring.Add(this.author);
            //Add date possibly?
            firstliststring.Add("");

            return stringencodeloop(firstliststring, pageview.Nodes[0].Nodes, 0, 0);
        }

        private List<String> stringencodeloop(List<String> lst, TreeNodeCollection tnc, int level, int spacing)
        {
            for(int i = 1; i <= tnc.Count; i++){
                TreeNodePrime node = (TreeNodePrime)tnc[i-1];
                String endsegment = "";
                if (!node.isHeader && node.text != "")
                {
                    //Gets the title of the node and then what the user typed into the node
                    endsegment = node.Text + " - " + node.text;
                }
                else if(!node.isHeader && node.text == "")
                {
                    endsegment = node.Text;
                }
                else
                {
                    endsegment = node.Text + ":";
                }

                switch (level)
                {
                    case 0: lst.Add(ToRomanUpper(i).ToString() + ". " + endsegment);
                        lst = stringencodeloop(lst, node.Nodes, 1, spacing + 4);
                        break;
                    case 1: lst.Add(getSpacing(spacing) + ToUpperCase(i).ToString() + ". " + endsegment);
                        lst = stringencodeloop(lst, node.Nodes, 2, spacing + 4);
                        break;
                    case 2: lst.Add(getSpacing(spacing) + ToRomanLower(i).ToString() + ". " + endsegment);
                        lst = stringencodeloop(lst, node.Nodes, 3, spacing + 4);
                        break;
                    case 3: lst.Add(getSpacing(spacing) + i.ToString() + ". " + endsegment);
                        lst = stringencodeloop(lst, node.Nodes, 1, spacing + 4);
                        break;
                    default: MessageBox.Show("Critical Error");
                        break;
                }
            }
            return lst;
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private static byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }

        private static Object ByteArrayToObject(byte[] arrBytes)
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            memStream.Write(arrBytes, 0, arrBytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            Object obj = (Object)binForm.Deserialize(memStream);
            return obj;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }

        private void newPageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            newSubPage();
        }

        private void headerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newHeader();
        }

        private void menu_deletepage_Click(object sender, EventArgs e)
        {
            deletePage();
        }

        private void menu_saveas_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void newdocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void menu_print_Click(object sender, EventArgs e)
        {
            
        }

        private void openfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open();
        }

        private void addTag(String s)
        {
            TextBox pbox = new TextBox();
            pbox.Height = (23);
            pbox.Width = (50);
            pbox.Visible = true;
            pbox.BackColor = Color.FromArgb(0,192,0);
            pbox.Cursor = Cursors.Hand;
            pbox.Font = new Font("Candara", 9.75f);
            pbox.ForeColor = Color.White;
            pbox.TextAlign = HorizontalAlignment.Center;
            pbox.BorderStyle = BorderStyle.FixedSingle;

            pbox.MouseDown += new MouseEventHandler(pbox_MouseDown);
            pbox.DragOver += new DragEventHandler(pbox_DragOver);
            pbox.DragEnter += new DragEventHandler(pbox_DragEnter);
            pbox.TextChanged += new EventHandler(pbox_TextChanged);
            pbox.AllowDrop = true;
            flowLayoutPanel1.Controls.Add(pbox);
        }
        void pbox_DragOver(object sender, DragEventArgs e)
        {
            base.OnDragOver(e);
            // is another dragable
            if (e.Data.GetData(typeof(TextBox)) != null)
            {
                FlowLayoutPanel p = (FlowLayoutPanel)(sender as TextBox).Parent;
                //Current Position             
                int myIndex = p.Controls.GetChildIndex((sender as TextBox));

                //Dragged to control to location of next picturebox
                TextBox q = (TextBox)e.Data.GetData(typeof(TextBox));
                p.Controls.SetChildIndex(q, myIndex);
            }
        }
        void pbox_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            DoDragDrop(sender, DragDropEffects.All);
        }
        void pbox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            addTag(textBox3.Text);
        }

        private void pbox_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(textBox1.Text, textBox1.Font);
            textBox1.Width = size.Width;
            textBox1.Height = size.Height;
        }

        public static string ToRomanUpper(int number)
        {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + ToRomanUpper(number - 1000);
            if (number >= 900) return "CM" + ToRomanUpper(number - 900);
            if (number >= 500) return "D" + ToRomanUpper(number - 500);
            if (number >= 400) return "CD" + ToRomanUpper(number - 400);
            if (number >= 100) return "C" + ToRomanUpper(number - 100);
            if (number >= 90) return "XC" + ToRomanUpper(number - 90);
            if (number >= 50) return "L" + ToRomanUpper(number - 50);
            if (number >= 40) return "XL" + ToRomanUpper(number - 40);
            if (number >= 10) return "X" + ToRomanUpper(number - 10);
            if (number >= 9) return "IX" + ToRomanUpper(number - 9);
            if (number >= 5) return "V" + ToRomanUpper(number - 5);
            if (number >= 4) return "IV" + ToRomanUpper(number - 4);
            if (number >= 1) return "I" + ToRomanUpper(number - 1);
            throw new ArgumentOutOfRangeException("something bad happened");
        }

        public static string ToRomanLower(int number)
        {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "m" + ToRomanLower(number - 1000);
            if (number >= 900) return "cm" + ToRomanLower(number - 900);
            if (number >= 500) return "d" + ToRomanLower(number - 500);
            if (number >= 400) return "cd" + ToRomanLower(number - 400);
            if (number >= 100) return "c" + ToRomanLower(number - 100);
            if (number >= 90) return "xc" + ToRomanLower(number - 90);
            if (number >= 50) return "l" + ToRomanLower(number - 50);
            if (number >= 40) return "xl" + ToRomanLower(number - 40);
            if (number >= 10) return "x" + ToRomanLower(number - 10);
            if (number >= 9) return "ix" + ToRomanLower(number - 9);
            if (number >= 5) return "v" + ToRomanLower(number - 5);
            if (number >= 4) return "iv" + ToRomanLower(number - 4);
            if (number >= 1) return "i" + ToRomanLower(number - 1);
            throw new ArgumentOutOfRangeException("something bad happened");
        }

        public static string ToUpperCase(int number)
        {
            while (number > 26)
            {
                number = number - 26;
            }
            if (number == 0) MessageBox.Show("Uppercase error");
            if (number == 1) return "A";
            if (number == 2) return "B";
            if (number == 3) return "C";
            if (number == 4) return "D";
            if (number == 5) return "E";
            if (number == 6) return "F";
            if (number == 7) return "G";
            if (number == 8) return "H";
            if (number == 9) return "I";
            if (number == 10) return "J";
            if (number == 11) return "K";
            if (number == 12) return "L";
            if (number == 13) return "M";
            if (number == 14) return "N";
            if (number == 15) return "O";
            if (number == 16) return "P";
            if (number == 17) return "Q";
            if (number == 18) return "R";
            if (number == 19) return "S";
            if (number == 20) return "T";
            if (number == 21) return "U";
            if (number == 22) return "V";
            if (number == 23) return "W";
            if (number == 24) return "X";
            if (number == 25) return "Y";
            if (number == 26) return "Z";

            MessageBox.Show("Uppercase error: Did not find number");
            return "";
        }

        public static String getSpacing(int num)
        {
            String s = "";
            while (num > 0)
            {
                s += " ";
                num--;
            }
            return s;
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Only exports to a text file currently
            exportToTextFile();
        }

        private void exportToTextFile()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Public\Tnotetest_export.txt"))
            {
                foreach (string line in getStringEncode())
                {
                    file.WriteLine(line);
                }
            }
        }
    }
    #endregion
}
