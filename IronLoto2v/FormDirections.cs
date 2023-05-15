using System;
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
            this.WindowState = FormWindowState.Maximized;
            pictureBox1.Image = new Bitmap(Properties.Resources.roundview, new Size(pictureBox1.Width, pictureBox1.Height));
            pictureBox2.Image = new Bitmap(Properties.Resources.endOfRound, new Size(pictureBox1.Width, pictureBox1.Height));
            pictureBox3.Image = new Bitmap(Properties.Resources.raunds, new Size(pictureBox1.Width, pictureBox1.Height));
            pictureBox4.Image = new Bitmap(Properties.Resources.keyboard, new Size(1271, 561));
            Process.Start(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HTMLPageDirections.html"));
        }
        private void FormDirections_Load_1(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReg frm=new FormReg();
            frm.Show();
            this.Hide();
        }
    }
}
