﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IronLoto2v
{
    public partial class FormGame : Form
    {
        public string gamer1=String.Empty;
        public string gamer2=String.Empty;
        int x = 4;
        int y = 16;
        int t = 5000;
        public FormGame()
        {
            InitializeComponent();
        }
        void drawData(DataGridView data, int a, int b)
        {
            DataGridViewImageColumn[] columns = new DataGridViewImageColumn[b];
            for (int i = 0; i < b; i++)
            {
                columns[i] = new DataGridViewImageColumn();
                columns[i].Width = 558 / b;
            }
            data.Columns.AddRange(columns);
            data.Rows.Add(a - 1);
            data.RowTemplate.Height = 510 / a;
            
            
        }
        private void FormGame_Load(object sender, EventArgs e)
        {
            drawData(dataGridViewGamer1, y, x);
            drawData(dataGridViewGamer2, y, x);
        }

    }
}
