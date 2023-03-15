using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IronLoto2v
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormReg frm=new FormReg();
            frm.Show();
            this.Hide();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            FormIntroduction frm = new FormIntroduction();
            frm.Show();
        }

        private void buttonDirections_Click(object sender, EventArgs e)
        {
            FormDirections frm = new FormDirections();
            frm.Show();
        }
    }
}
