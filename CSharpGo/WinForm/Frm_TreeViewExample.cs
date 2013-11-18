using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;

namespace CSharpGo
{
    public partial class Frm_TreeViewExample : DockContent
    {
        public Frm_TreeViewExample()
        {
            InitializeComponent();
        }
        private void FillDirTree()
        {
            string[] drivers = Environment.GetLogicalDrives();
            for (int i = 0; i < drivers.Length; i++)
            {
                Console.WriteLine("i={0}", i);
                if (PlatformInvokeKernel32.GetDriveType(drivers[i]) == PlatformInvokeKernel32.DRIVE_FIXED)
                {
                    DirNode root = new DirNode(drivers[i]);
                    treeViewDir.Nodes.Add(root);
                    AddDirs(root);
                }
            }
        }
        private void AddDirs(TreeNode node)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(GetPathFromNode(node));
                DirectoryInfo[] e = dir.GetDirectories();
                FileInfo[] f = dir.GetFiles();
                string name;
                for (int i = 0; i < e.Length; i++)
                {
                    name = e[i].Name;
                    if (!name.Equals(".") && !name.Equals(".."))
                    {
                        node.Nodes.Add(new DirNode(name));
                    }
                }
                for (int i = 0; i < f.Length; i++)
                {
                    name = f[i].Name;
                    node.Nodes.Add(new DirNode(name));
                }
            }
            catch
            {
            }
        }
        private string GetPathFromNode(TreeNode node)
        {
            if (node.Parent == null)
            {
                return node.Text;
            }
            return Path.Combine(GetPathFromNode(node.Parent), node.Text);
        }

        private void Frm_TreeViewExample_Load(object sender, EventArgs e)
        {
            FillDirTree();		
        }

        private void treeViewDir_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                string fileName = GetPathFromNode(e.Node);
                richTextBox1.Text = System.IO.File.ReadAllText(fileName, System.Text.Encoding.GetEncoding("gb2312"));

            }
            catch
            {

            }
        }

        private void treeViewDir_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            DirNode nodeExpanding = (DirNode)e.Node;
            if (!nodeExpanding.SubDirectoriesAdded)
            {
                AddSubDirs(nodeExpanding);
            }
        }
        private void AddSubDirs(DirNode node)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                AddDirs(node.Nodes[i]);
            }
            node.SubDirectoriesAdded = true;
        }
    }
}
