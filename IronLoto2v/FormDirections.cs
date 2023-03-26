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

namespace IronLoto2v
{
    public partial class FormDirections : Form
    {
        public FormDirections()
        {
            InitializeComponent();
            //webBrowserDirections.Navigate(@"C:\Users\Efrem\Desktop\Рафаэль\Курсовая работа\IronLoto2v\IronLoto2v\Resources\loto-directions\mydirs.html");
            string path = Properties.Resources.index;
            webBrowserDirections.DocumentText = path;
        }
        private void FormDirections_Load_1(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;

        }
    }
}
