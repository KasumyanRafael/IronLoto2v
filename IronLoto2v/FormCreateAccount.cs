using MySql.Data.MySqlClient;
using System.Data.OleDb;
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
    public partial class FormCreateAccount : Form
    {
        string name;
        string surname;
        string password;
        string email;
        public FormCreateAccount()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text!=String.Empty && textBoxName.Text!="Введите имя")
            {
                name = textBoxName.Text;
                if (textBoxSurname.Text != String.Empty && textBoxSurname.Text != "Введите фамилию")
                {
                    surname = textBoxSurname.Text;
                    if (textBoxEmail.Text != String.Empty && textBoxEmail.Text != "Введите адрес почты")
                    {
                        email = textBoxEmail.Text;
                        if (textBoxPassword.Text != String.Empty && textBoxPassword.Text != "Введите пароль")
                        {
                            if (textBoxCheck.Text != String.Empty && textBoxCheck.Text != "Повторите пароль" && textBoxPassword.Text==textBoxCheck.Text)
                            {
                                password = textBoxPassword.Text;
                                string connect= "Data Source=127.0.0.1;Port=3306;User ID=root;Password=Kolobok168259;database=iron_pictures";
                                MySqlConnection connection = new MySqlConnection(connect);
                                string command = "insert into iron_pictures.extendedusers(userFirstName,userLastName,email,passwordInfo) values(@uname,@usurname,@uemail,@upassword)";
                                MySqlCommand mySqlCommand = new MySqlCommand(command, connection);
                                mySqlCommand.Parameters.AddWithValue("@uname", name);
                                mySqlCommand.Parameters.AddWithValue("@usurname", surname);
                                mySqlCommand.Parameters.AddWithValue("@uemail", email);
                                mySqlCommand.Parameters.AddWithValue("@upassword", password);
                                connection.Open();
                                try
                                {
                                    char r = '"';
                                    string newcommand = String.Format("SELECT userFirstName FROM iron_pictures.extendedusers where email = {2}{0}{2} and passwordInfo ={2}{1}{2};", email, password, r.ToString());
                                    MySqlConnection newconnection = new MySqlConnection(connect);
                                    MySqlCommand newmySqlCommand = new MySqlCommand(newcommand, newconnection);
                                    newconnection.Open();
                                    MySqlDataReader res2 = newmySqlCommand.ExecuteReader();
                                    if (!res2.HasRows)
                                    {
                                        mySqlCommand.ExecuteNonQuery();
                                        MessageBox.Show("Аккаунт создан");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Аккаунт с такими почтой и паролем уже есть. Странно, что вы знаете данные другого пользователя.");
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Что-то пошло не так");
                                }
                                finally
                                {
                                    connection.Close();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Повторите пароль");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Поле пароль обязательно");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Поле с электронной почтой обязательно");
                    }
                }
                else
                {
                    MessageBox.Show("Поле фамилия обязательно");
                }
            }
            else
            {
                MessageBox.Show("Поле имя обязательно");
            }
        }
    }
}
