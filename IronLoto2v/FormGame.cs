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
        public GameUser firstgamer=new GameUser();
        public GameUser secondgamer=new GameUser();
        static int x = 3;
        static int y = 2;
        static int t = 1000;
        bool IsPause = false;
        int cnt = 0; //счётчик, не позволяющий выйти за пределы массива
        int countpic;
        string[] s;
        int[,] firstTable = new int[x, y];//
        int[,] secondTable = new int[x, y];//
        int pictureshow = 0;
        int firstscore = 0;//
        int secondscore = 0;//мусор
        WordExtract extract;
        int countdown=10;
        Card img;  //демонстрируемые картинки
        GameTable firstfield;
        GameTable secondfield;
        Switcher switcher;
        public FormGame()
        {
            InitializeComponent();
        }
        private void FormGame_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            firstgamer.RoundLoad(labelFirstGamer, labelFirstGamerCount);
            secondgamer.RoundLoad(labelSecondGamer, labelSecondGamerCount);
            s = Properties.Resources.dictionary__1_.Split('\n');
            extract = new WordExtract(s); 
            firstfield = new GameTable(dataGridViewGamer1, x, y, firstgamer);
            secondfield = new GameTable(dataGridViewGamer2, x, y, secondgamer);
            firstfield.Fill(extract, x, y, "1"); //alert
            do
            {
                secondfield.Fill(extract, x, y, "1");
            }
            while (!antitwin(firstfield.undertable, secondfield.undertable, x, y));
            switcher = new Switcher(timerCountdown,pictureBoxShow,img,extract,labelCountdown,labelPicturesCount,t,s);
        }
        /// <summary>
        /// Нельзя таблицам быть абсолютно одинаковыми
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
                    firstgamer.localscore += firstfield.CheckingCards(labelNoWayGamer1,labelPicturesCount,firstgamer,secondgamer,switcher,extract);
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
                    secondgamer.localscore += secondfield.CheckingCards(labelNoWayGamer2, labelPicturesCount, firstgamer, secondgamer, switcher, extract);
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
            }
            img = new Card(extract.mas[cnt]);
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
            }*/
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

   

  
