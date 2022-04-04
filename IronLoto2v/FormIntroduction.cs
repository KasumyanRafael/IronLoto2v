using System;
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
    public partial class FormIntroduction : Form
    {
        public string gamer1=String.Empty;
        public string gamer2=String.Empty;
        public FormIntroduction()
        {
            InitializeComponent();
        }

        private void FormIntroduction_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            gamer1=textBoxGamer1.Text;
            gamer2=textBoxGamer2.Text;
            MessageBox.Show("Желаем вам приятной игры и пусть победит сильнейший.");
            FormGame form=new FormGame();
            form.Show();
            form.gamer1 = gamer1;
            form.gamer2 = gamer2;
        }
    }
}
