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

namespace IronLoto2v
{
    public partial class FormSettings : Form
    {
        string[] parametres;
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            parametres= Properties.Resources.sets.Split('\n');
            comboBoxCols.Text=parametres[0];
            comboBoxRows.Text=parametres[1];
            comboBoxTime.Text=parametres[2];
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            GetResourse(parametres);
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
        }
        void GetResourse(string[]s)
        {
            using (StreamWriter input = new StreamWriter(WindowsFormsSection.Properties.Resources.sets))
            {
                input.WriteLine(s[0] + '\n' + s[1] + '\n' + s[2]);
            }
        }
    }
}
