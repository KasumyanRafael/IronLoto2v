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
            StartPosition = FormStartPosition.CenterScreen;
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

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            if(File.Exists("localname.txt"))
            {
                buttonSubmit.Visible = false;
                panel1.Visible = true;
                StreamReader file = new StreamReader("localname.txt");
                labelNick.Text = file.ReadLine();
                file.Close();
            }
            else
            {
                panel1.Visible=false;
                buttonSubmit.Visible=true;
            }
            if (File.Exists("localname.txt"))
            {
                buttonStart.Text = "Играть вдвоём";
                buttonLearn.Visible=true;
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            FormReg formReg = new FormReg();
            formReg.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.Delete("localname.txt");
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }

        private void changeUseкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReg frm=new FormReg();
            frm.Show();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
