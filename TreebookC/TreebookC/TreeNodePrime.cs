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

namespace TreebookC
{
    class TreeNodePrime : TreeNode
    {
        public TreeNodePrime()
        {
            text = "";
            isHeader = false;
            isLocked = false;
        }
        public string text;
        public bool isHeader;
        public bool isLocked;
        public void replicateFrom(TreeNodePrime t)
        {
            this.text = t.text;
            this.isHeader = t.isHeader;
            this.isLocked = t.isLocked;
        }
        public TreeNodePrime clonePrime()
        {
            TreeNodePrime t = (TreeNodePrime) this.Clone();
            t.replicateFrom(this);
            return t;
        }
    }
}
