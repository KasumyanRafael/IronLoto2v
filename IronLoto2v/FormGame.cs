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
        static int x = 3;
        static int y = 2;
        static int t = 600;
        bool IsPause = false;
        int cnt = 0;
        string[] s;
        int[,] firstTable = new int[x, y];
        int[,] secondTable = new int[x, y];
        int pictureshow = 0;
        int firstscore = 0;
        int secondscore = 0;
        Word[] list;
        Word[] extract;
        int countdown=10;
        public FormGame()
        {
            InitializeComponent();
        }
        void drawData(DataGridView data, int a, int b)
        {
            DataGridViewImageColumn[] columns = new DataGridViewImageColumn[b];
            for (int i = 0; i < b; i++)
            {
                columns[i] = new DataGridViewImageColumn();
                columns[i].Width = 150;
            }
            data.RowTemplate.Height = 139;
            data.Columns.AddRange(columns);
            data.Rows.Add(a - 1);
        }
        public void FormGame_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            drawData(dataGridViewGamer1, x, y);
            drawData(dataGridViewGamer2, x, y);
            dataGridViewGamer1.CurrentCell = this.dataGridViewGamer1[0, 0];
            dataGridViewGamer2.CurrentCell = this.dataGridViewGamer2[0, 0];
            s = Properties.Resources.dictionary.Split('\n');
            list = ToWord(s); //это массив сo словами (типа word)
            antirepeat(list, s);
            extract=GetExtract(list); //ЭТО МЫ ВЫБРАЛИ 10 КАРТОЧЕК ИЗ 92+
            filling(dataGridViewGamer1, extract, x, y, firstTable);
            do
            {
                filling(dataGridViewGamer2, extract, x, y, secondTable);
            }
            while (antitwin(firstTable, secondTable, x, y) != false);
            timerCountdown.Enabled = true;
            timerCountdown.Interval = t;
            labelFirstGamer.Text = gamer1;
            labelSecondGamer.Text = gamer2;
            if (cnt > s.Length)
                timerCountdown.Enabled = false;
        }

        void filling(DataGridView data, Word[]array, int a, int b, int[,] tr)
        {
            Random rnd = new Random();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    int c = rnd.Next(1, array.Length);
                    Word temp = array[c];
                    data.Rows[i].Cells[j].Value = temp.GetIrPicture();
                    tr[i, j] = temp.NumberOf();
                }
            }
        }
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
        void antirepeat(Word[] perm, string[] s)
        {
            Random r = new Random(); // не создавайте новый Random здесь!
                                     // а то значения будут одни и те же
            int n = s.Length;
            for (int i = n - 1; i >= 1; i--)
            {
                int j = r.Next(i + 1);
                // exchange perm[j] and perm[i]
                Word temp = perm[j];
                perm[j] = perm[i];
                perm[i] = temp;
            }
        }
        Word[] GetExtract(Word[] perm) //выбираем первые 10 карточек из перетасованного массива
        {
            Word[] result = new Word[10];
            for (int i = 0;i < 10;i++)
            {
                result[i] = perm[i];
            }
            return result;
        }

        static Word[] ToWord(string[] a)
        {
            Word[] temp = new Word[a.Length];
            for (int i = 0; i < a.Length; i++) 
            {
                temp[i] = new Word(a[i]);
            }
            return temp;
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuItemUsers_Click(object sender, EventArgs e)
        {
            FormIntroduction form = new FormIntroduction();
            form.Show();
        }

        private void ToolStripMenuItemMenu_Click(object sender, EventArgs e)
        {
            timerCountdown.Stop();
            FormMenu menu = new FormMenu();
            menu.Show();
        }

        private void ToolStripMenuItemInformation_Click(object sender, EventArgs e)
        {
            timerCountdown.Stop();
            labelPause.Visible = true;
            ToolStripMenuItemStopOrGo.Text = "Вперёд!";
            FormDirections frm = new FormDirections();
            frm.Show();
        }

        private void ToolStripMenuItemStopOrGo_Click(object sender, EventArgs e)
        {
            if (ToolStripMenuItemStopOrGo.Text == "Пауза")
            {
                timerCountdown.Stop();
                ToolStripMenuItemStopOrGo.Text = "Вперёд!";
                IsPause = true;
                labelPause.Visible = true;
            }
            else
            {
                timerCountdown.Start();
                ToolStripMenuItemStopOrGo.Text = "Пауза";
                IsPause = false;
                labelPause.Visible = false;
            }
        }
        void Winner(string first, string second, int one, int two)
        {

            if (one > two) MessageBox.Show("В первом раунде победил(a) " + gamer1);
            if (one < two) MessageBox.Show("В первом раунде победил(a) " + gamer2);
            if (one == two) MessageBox.Show("В первом раунде победилf дружба. Все молодцы");
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
                data.CurrentCell.Value = null;
                return 1;
            }
            label.Visible = true;
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
            countdown--;
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
        }
    }
}

   

  
