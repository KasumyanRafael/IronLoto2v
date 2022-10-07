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
        GameUser firstgamer=new GameUser();
        GameUser secondgamer=new GameUser();
        public FormIntroduction()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            firstgamer.Name = textBoxGamer1.Text;
            secondgamer.Name = textBoxGamer2.Text;
            MessageBox.Show("Желаем вам приятной игры и пусть победит сильнейший.");            
            FormGame form=new FormGame();
            form.firstgamer=firstgamer;
            form.secondgamer=secondgamer;
            form.Show();
        }
    }
}
