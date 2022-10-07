using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace IronLoto2v
{
    public partial class FormGame : Form
    {
        public string gamer1 = String.Empty;
        public string gamer2 = String.Empty;
        GameUser firstgamer = new GameUser();
        GameUser secondgamer = new GameUser();
        static int x = 3;
        static int y = 2;
        static int t = 1000;
        bool IsPause = false;
        int cnt = 0;
        int countpic;
        string[] s;
        int[,] firstTable = new int[x, y];
        int[,] secondTable = new int[x, y];
        int pictureshow = 0;
        int firstscore = 0;
        int secondscore = 0;
        WordExtract extract;
        int countdown=10;
        public FormGame()
        {
            InitializeComponent();
            start();
        }
        void start()
        {
            this.WindowState = FormWindowState.Maximized;
            firstgamer.Name = gamer1;
            secondgamer.Name = gamer2;
            s = Properties.Resources.dictionary__1_.Split('\n');
            firstgamer.RoundLoad(firstgamer, labelFirstGamer, labelFirstGamerCount);
            secondgamer.RoundLoad(secondgamer, labelSecondGamer, labelSecondGamerCount);
            GameTable firstfield = new GameTable(dataGridViewGamer1, x, y,firstgamer);
            GameTable secondfield = new GameTable(dataGridViewGamer2, x, y,secondgamer);
            extract = new WordExtract(s);
            firstfield.Fill(extract, x, y,"1");
            do
            {
                secondfield.Fill(extract, x, y,"1");
            }
            while(!antitwin(firstfield.undertable,secondfield.undertable,x,y));
            timerCountdown.Enabled = true;
            timerCountdown.Interval = t;
            if (cnt > s.Length)
                timerCountdown.Enabled = false;
        }
        /// <summary>
        /// Нельзя, чтобы таблицы были абсолютно одинаковыми
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        bool antitwin(int[,] a, int[,] b, int c, int d)
        {
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    if (a[i, j] == b[i, j]) return true;
                }
            }
            return false;
        }
        void Winner(string first, string second, int one, int two) //add to GameUser later!
        {
            timerCountdown.Stop();
            if (one > two) MessageBox.Show("В первом раунде победил(a) " + gamer1);
            if (one < two) MessageBox.Show("В первом раунде победил(a) " + gamer2);
            if (one == two) MessageBox.Show("В первом раунде победила дружба. Все молодцы");
            StreamWriter file2 = new StreamWriter("first.txt");
            file2.Write(one + " " + two);
            file2.Close();
            FormSecond form = new FormSecond();
            form.gamer1 = gamer1;
            form.gamer2 = gamer2;
            form.Show();
        }
        int CheckPicture(DataGridView data, int picture, int[,] mas, Label label)
        {
            int a = data.CurrentCell.RowIndex;
            int b = data.CurrentCell.ColumnIndex;
            if (mas[a, b] == picture)
            {
                data.CurrentCell.Value = Properties.Resources.p0;
                mas[a, b] = 0;
                cnt++; //Здесь начинается та самая конкуренция!
                if(cnt==extract.mas.Length) Winner(gamer1, gamer2, firstscore, secondscore);
                countdown = 10;
                pictureBoxShow.Image = extract.mas[cnt].GetRusPicture();
                pictureshow = extract.mas[cnt].NumberOf();
                countpic--;
                labelPicturesCount.Text = countpic.ToString() + "/10";
                return 1;
            }
            else if (mas[a,b]!=0) label.Visible = true;
            //MessageBox.Show("Ход невозможен");
            return 0;
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.D && IsPause == false)
                {
                    dataGridViewGamer1.Enabled = true;
                    labelNoWayGamer1.Visible = false;
                    int col = dataGridViewGamer1.CurrentCell.ColumnIndex + 1;
                    int row = dataGridViewGamer1.CurrentCell.RowIndex;
                    dataGridViewGamer1.CurrentCell = dataGridViewGamer1[col, row];
                }
                if (e.KeyCode == Keys.W && IsPause == false)
                {
                    dataGridViewGamer1.Enabled = true;
                    labelNoWayGamer1.Visible = false;
                    int col = dataGridViewGamer1.CurrentCell.ColumnIndex;
                    int row = dataGridViewGamer1.CurrentCell.RowIndex - 1;
                    dataGridViewGamer1.CurrentCell = dataGridViewGamer1[col, row];
                }
                if (e.KeyCode == Keys.A && IsPause == false)
                {
                    dataGridViewGamer1.Enabled = true;
                    labelNoWayGamer1.Visible = false;
                    int col = dataGridViewGamer1.CurrentCell.ColumnIndex - 1;
                    int row = dataGridViewGamer1.CurrentCell.RowIndex;
                    dataGridViewGamer1.CurrentCell = dataGridViewGamer1[col, row];
                }
                if (e.KeyCode == Keys.S && IsPause == false)
                {
                    dataGridViewGamer1.Enabled = true;
                    labelNoWayGamer1.Visible = false;
                    int col = dataGridViewGamer1.CurrentCell.ColumnIndex;
                    int row = dataGridViewGamer1.CurrentCell.RowIndex + 1;
                    dataGridViewGamer1.CurrentCell = dataGridViewGamer1[col, row];
                }
                if (e.KeyCode == Keys.NumPad8 && IsPause == false)
                {
                    dataGridViewGamer2.Enabled = true;
                    labelNoWayGamer2.Visible = false;
                    int col = dataGridViewGamer2.CurrentCell.ColumnIndex;
                    int row = dataGridViewGamer2.CurrentCell.RowIndex - 1;
                    dataGridViewGamer2.CurrentCell = dataGridViewGamer2[col, row];
                }
                if (e.KeyCode == Keys.NumPad2 && IsPause == false)
                {
                    dataGridViewGamer2.Enabled = true;
                    labelNoWayGamer2.Visible = false;
                    int col = dataGridViewGamer2.CurrentCell.ColumnIndex;
                    int row = dataGridViewGamer2.CurrentCell.RowIndex + 1;
                    dataGridViewGamer2.CurrentCell = dataGridViewGamer2[col, row];
                }
                if (e.KeyCode == Keys.NumPad4 && IsPause == false)
                {
                    dataGridViewGamer2.Enabled = true;
                    labelNoWayGamer2.Visible = false;
                    int col = dataGridViewGamer2.CurrentCell.ColumnIndex - 1;
                    int row = dataGridViewGamer2.CurrentCell.RowIndex;
                    dataGridViewGamer2.CurrentCell = dataGridViewGamer2[col, row];
                }
                if (e.KeyCode == Keys.NumPad6 && IsPause == false)
                {
                    dataGridViewGamer2.Enabled = true;
                    labelNoWayGamer2.Visible = false;
                    int col = dataGridViewGamer2.CurrentCell.ColumnIndex + 1;
                    int row = dataGridViewGamer2.CurrentCell.RowIndex;
                    dataGridViewGamer2.CurrentCell = dataGridViewGamer2[col, row];
                }

                if (e.KeyCode == Keys.Space && IsPause == false)
                {
                    dataGridViewGamer1.Enabled = true;
                    labelNoWayGamer1.Visible = false;
                    firstscore += CheckPicture(dataGridViewGamer1, pictureshow, firstTable, labelNoWayGamer1);
                    labelFirstGamerCount.Text = firstscore.ToString();
                    if (firstscore == x * y)
                    {
                        timerCountdown.Stop();
                        Winner(gamer1, gamer2, firstscore, secondscore);

                    }
                }
                if (e.KeyCode == Keys.NumPad5 && IsPause == false)
                {
                    dataGridViewGamer2.Enabled = true;
                    labelNoWayGamer2.Visible = false;
                    secondscore += CheckPicture(dataGridViewGamer2, pictureshow, secondTable, labelNoWayGamer2);
                    labelSecondGamerCount.Text = secondscore.ToString();
                    if (secondscore == x * y)
                    {
                        timerCountdown.Stop();
                        Winner(gamer1, gamer2, firstscore, secondscore);
                    }

                }
            }
            catch { }
            dataGridViewGamer1.Enabled = false;
            dataGridViewGamer2.Enabled = false;

        }

        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            /*countdown--;
            labelCountdown.Text=countdown.ToString();
            if(countdown<5) labelCountdown.ForeColor = Color.Red;
            else labelCountdown.ForeColor = Color.Black;
            if(countdown==0)
            {
                countdown = 10;
                try
                {
                    cnt++;
                    pictureBoxShow.Image = extract[cnt].GetRusPicture();
                    pictureshow = extract[cnt].NumberOf();
                }
                catch
                {
                    timerCountdown.Stop();
                    Winner(gamer1, gamer2, firstscore, secondscore);
                }
            }*/
            Card img = new Card(extract.mas[cnt]);
            pictureBoxShow.Image = img.CatchRusPicture();
            pictureshow = img.number;
            countdown--;
            labelCountdown.Text = countdown.ToString();
            if (countdown < 5) labelCountdown.ForeColor = Color.Red;
            else labelCountdown.ForeColor = Color.Black;
            if (countdown == 0)
            {
                countdown = 10;
                cnt++;
                countpic--;
                labelPicturesCount.Text= countpic.ToString()+"/10";
            }
            if(cnt==10)
            {
                timerCountdown.Stop();
                Winner(gamer1, gamer2, firstscore, secondscore);
            }
            
        }

        private void ToolStripMenuItemExits_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuItemMenues_Click(object sender, EventArgs e)
        {
            timerCountdown.Stop();
            FormMenu menu = new FormMenu();
            menu.Show();
        }

        private void ToolStripMenuItemUsersChange_Click(object sender, EventArgs e)
        {
            timerCountdown.Stop();
            FormIntroduction form = new FormIntroduction();
            form.Show();
        }


        private void ToolStripMenuItemDirections_Click(object sender, EventArgs e)
        {
            timerCountdown.Stop();
            labelPause.Visible = true;
            ToolStripMenuItemStopOrGo.Text = "Вперёд!";
            FormDirections frm = new FormDirections();
            frm.Show();
        }

        private void ToolStripMenuItemPause_Click(object sender, EventArgs e)
        {
            if (ToolStripMenuItemPause.Text == "Пауза")
            {
                timerCountdown.Stop();
                ToolStripMenuItemPause.Text = "Вперёд!";
                IsPause = true;
                labelPause.Visible = true;
            }
            else
            {
                timerCountdown.Start();
                ToolStripMenuItemPause.Text = "Пауза";
                IsPause = false;
                labelPause.Visible = false;
            }
        }
    }
}

   

  
