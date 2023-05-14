﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace IronLoto2v
{
    public partial class FormDirections : Form
    {
        public FormDirections()
        {
            InitializeComponent();
            string path = Properties.Resources.index;
            //webBrowserDirections.DocumentText = path;
            Process.Start(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HTMLPageDirections.html"));
        }
        private void FormDirections_Load_1(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }
    }
}
