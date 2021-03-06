﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace TreeViewPractice
{
    public class MForm : Form
    {
        private TreeView tv;
        private Button expand;
        private Button expandAll;
        private Button collapse;
        private Button collapseAll;
        private StatusBar sb;

        private const string HOME_DIR = @"c:\GitHub";

        public MForm()
        {
            Size = new Size(400, 400);
            Text = "Directories";

            tv = new TreeView();

            SuspendLayout();

            tv.Parent = this;
            tv.Location = new Point(10, 10);
            tv.Size = new Size(ClientSize.Width - 20, Height - 200);
            tv.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            tv.FullRowSelect = true;
            tv.ShowLines = true;
            tv.ShowPlusMinus = true;
            tv.Scrollable = true;
            tv.AfterSelect += new TreeViewEventHandler(AfterSelect);

            expand = new Button();
            expand.Parent = this;
            expand.Location = new Point(20, tv.Bottom + 20);
            expand.Text = "Expand";
            expand.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            expand.Click += new EventHandler(OnExpand);


            expandAll = new Button();
            expandAll.Parent = this;
            expandAll.Location = new Point(20, expand.Bottom + 5);
            expandAll.Text = "Expand All";
            expandAll.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            expandAll.Click += new EventHandler(OnExpandAll);


            collapse = new Button();
            collapse.Parent = this;
            collapse.Location = new Point(expandAll.Right + 5, expand.Top);
            collapse.Text = "Collapse";
            collapse.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            collapse.Click += new EventHandler(OnCollapse);



            collapseAll = new Button();
            collapseAll.Parent = this;
            collapseAll.Location = new Point(collapse.Left, collapse.Bottom + 5);
            collapseAll.Text = "Collapse All";
            collapseAll.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            collapseAll.Click += new EventHandler(OnCollapseAll);

            sb = new StatusBar();
            sb.Parent = this;

            ShowDirectories(tv.Nodes, HOME_DIR);

            ResumeLayout();
            CenterToScreen();


        }

        void ShowDirectories(TreeNodeCollection trvNode, string path)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(path);
            if (dirinfo != null)
            {
                DirectoryInfo[] subDirs = dirinfo.GetDirectories();
                TreeNode tr = new TreeNode(dirinfo.Name);

                if (subDirs.Length > 0)
                {
                    foreach (DirectoryInfo dr in subDirs)
                    {
                        if (!dr.Name.StartsWith("."))
                            ShowDirectories(tr.Nodes, dr.FullName);
                    }
                }
            }
        }

        void AfterSelect(object sender, TreeViewEventArgs e)
        {
            sb.Text = e.Node.Text;
        }

        void OnExpand(object sender, EventArgs e)
        {
            tv.SelectedNode.Expand();
        }

        void OnExpandAll(object sender, EventArgs e)
        {
            tv.ExpandAll();
        }

        void OnCollapse(object sender, EventArgs e)
        {
            tv.SelectedNode.Collapse();
        }

        void OnCollapseAll(object sender, EventArgs e)
        {
            tv.CollapseAll();
        }


        static void Main()
        {
            Application.Run(new MForm());
        }

    }
}
