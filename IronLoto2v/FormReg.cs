using MySql.Data.MySqlClient;
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
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDemo_Click(object sender, EventArgs e)
        {
            FormMenu frm=new FormMenu();
            frm.Show();
            this.Hide();
        }

        private void FormReg_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (File.Exists("storage.txt"))
            {
                StreamReader file = new StreamReader("storage.txt");
                textBoxEmail.Text = file.ReadLine();
                textBoxPassword.Text = file.ReadLine();
                File.Delete("storage.txt");
            }
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            FormCreateAccount frm=new FormCreateAccount();
            frm.Show();
            this.Hide();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            File.Delete("storage.txt");
            if (checkBoxStorage.Checked)
            {
                StreamWriter file = new StreamWriter("storage.txt");
                file.WriteLine(textBoxEmail.Text);
                file.WriteLine(textBoxPassword.Text);
                file.Close();
            }
            string connect = "Data Source=127.0.0.1;Port=3306;User ID=root;Password=Kolobok168259;database=iron_pictures";
            char r = '"';
            string command = String.Format("SELECT userFirstName FROM iron_pictures.extendedusers where email = {2}{0}{2} and passwordInfo ={2}{1}{2};", textBoxEmail.Text, textBoxPassword.Text,r.ToString());
            MessageBox.Show(command);
            MySqlConnection connection = new MySqlConnection(connect);
            MySqlCommand mySqlCommand = new MySqlCommand(command, connection);
            try
            {
                connection.Open();
                MySqlDataReader res2 = mySqlCommand.ExecuteReader();
                if (res2.HasRows)
                {
                    while (res2.Read()) MessageBox.Show($"Привет, {res2.GetValue(0)}! Есть настрой учиться? Тогда вперёд!");
                }
                else
                {
                    MessageBox.Show("К сожалению, данные не совпадают. Проверьте правильность введённых данных. Если у вас ещё нет аккаунта - создайте его!");
                } 
            }
            catch
            {
                MessageBox.Show("Произошла ошибка в системе. Зайдите попозже.");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
