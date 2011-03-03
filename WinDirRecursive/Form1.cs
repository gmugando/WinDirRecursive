using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace WinDirRecursive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string rootPath = @"C:\Client Web";
            ListFiles(rootPath);
        }

        private void ListFiles(string rootPath)
        {
            
            string[] directories = Directory.GetDirectories(rootPath);

            foreach (string d in directories)
            {
                listBox1.Items.Add(d);
                foreach (string f in Directory.GetFiles(d))
                {
                    listBox1.Items.Add(f);
                }

                ListFiles(d);

            }

        }
    }
}
