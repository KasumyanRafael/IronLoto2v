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
        public string firstgamer;
        public string secondgamer=String.Empty;
        public FormIntroduction()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            firstgamer = textBoxGamer1.Text;
            secondgamer = textBoxGamer2.Text;
            MessageBox.Show("Желаем вам приятной игры и пусть победит сильнейший.");            
            FormGame form=new FormGame();           
            form.gamer1 = firstgamer;
            form.gamer2 = secondgamer;
            form.Show();
        }
    }
}
