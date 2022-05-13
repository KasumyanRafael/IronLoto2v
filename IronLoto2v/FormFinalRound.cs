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
    public partial class FormFinalRound : Form
    {
        public string gamer1 = String.Empty;
        public string gamer2 = String.Empty;
        static int x = 6;
        static int y = 3;
        static int t = 2;
        bool IsPause = false;
        int cnt = 0;
        string[] prMeans;
        string[] s;
        int[,] firstTable = new int[x, y];
        int[,] secondTable = new int[x, y];
        int pictureshow = 0;
        int firstscore = 0;
        int secondscore = 0;
        word[] list;
        public FormFinalRound()
        {
            InitializeComponent();
        }
        void drawData(DataGridView data, int a, int b)
        {
            DataGridViewImageColumn[] columns = new DataGridViewImageColumn[b];
            for (int i = 0; i < b; i++)
            {
                columns[i] = new DataGridViewImageColumn();
                columns[i].Width = 230;
            }
            data.RowTemplate.Height = 290;
            data.Columns.AddRange(columns);
            data.Rows.Add(a - 1);
        }
        private void FormFinalRound_Load(object sender, EventArgs e)
        {
            drawData(dataGridViewGamer1, x, y);
            drawData(dataGridViewGamer2, x, y);
            StreamReader file = new StreamReader("results");
            prMeans = file.ReadLine().Split(' ');
            file.Close();
            dataGridViewGamer1.CurrentCell = this.dataGridViewGamer1[0, 0];
            dataGridViewGamer2.CurrentCell = this.dataGridViewGamer2[0, 0];
            s = Properties.Resources.dictionary.Split('\n');
            list = ToWord(s);
            antirepeat(list, s);
            filling(dataGridViewGamer1, s, x, y, firstTable);
            do
            {
                filling(dataGridViewGamer2, s, x, y, secondTable);
            }
            while (antitwin(firstTable, secondTable, x, y) != false);
            timerChangePicture.Enabled = true;
            timerChangePicture.Interval = t * 1000;
            labelFirstGamer.Text = gamer1;
            labelSecondGamer.Text = gamer2;
            if (cnt > s.Length)
                timerChangePicture.Enabled = false;
        }
        void filling(DataGridView data, string[] array, int a, int b, int[,] tr)
        {
            Random rnd = new Random();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    int c = rnd.Next(1, array.Length);
                    word temp = new word(array[c]);
                    data.Rows[i].Cells[j].Value = temp.GetIronWord();
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
        void antirepeat(word[] perm, string[] s)
        {
            Random r = new Random(); // не создавайте новый Random здесь!
                                     // а то значения будут одни и те же
            int n = s.Length;
            for (int i = n - 1; i >= 1; i--)
            {
                int j = r.Next(i + 1);
                // exchange perm[j] and perm[i]
                word temp = perm[j];
                perm[j] = perm[i];
                perm[i] = temp;
            }
        }
        static word[] ToWord(string[] a)
        {
            word[] temp = new word[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                temp[i] = new word(a[i]);
            }
            return temp;
        }

        private void timerChangePicture_Tick(object sender, EventArgs e)
        {
            try
            {
                cnt++;
                pictureBoxShow.Image = list[cnt].GetPicture();
                pictureshow = list[cnt].NumberOf();
            }
            catch
            {
                timerChangePicture.Stop();
                Winner(gamer1, gamer2, firstscore, secondscore);
            }
        }
        int CheckPicture(DataGridView data, int picture, int[,] mas)
        {
            int a = data.CurrentCell.RowIndex;
            int b = data.CurrentCell.ColumnIndex;
            if (mas[a, b] == picture)
            {
                data.CurrentCell.Value = null;
                return 1;
            }
            MessageBox.Show("Ход невозможен");
            return 0;
        }

        private void FormFinalRound_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.D && IsPause == false)
                {
                    dataGridViewGamer1.Enabled = true;
                    int col = dataGridViewGamer1.CurrentCell.ColumnIndex + 1;
                    int row = dataGridViewGamer1.CurrentCell.RowIndex;
                    dataGridViewGamer1.CurrentCell = dataGridViewGamer1[col, row];
                }
                if (e.KeyCode == Keys.W && IsPause == false)
                {
                    dataGridViewGamer1.Enabled = true;
                    int col = dataGridViewGamer1.CurrentCell.ColumnIndex;
                    int row = dataGridViewGamer1.CurrentCell.RowIndex - 1;
                    dataGridViewGamer1.CurrentCell = dataGridViewGamer1[col, row];
                }
                if (e.KeyCode == Keys.A && IsPause == false)
                {
                    dataGridViewGamer1.Enabled = true;
                    int col = dataGridViewGamer1.CurrentCell.ColumnIndex - 1;
                    int row = dataGridViewGamer1.CurrentCell.RowIndex;
                    dataGridViewGamer1.CurrentCell = dataGridViewGamer1[col, row];
                }
                if (e.KeyCode == Keys.S && IsPause == false)
                {
                    dataGridViewGamer1.Enabled = true;
                    int col = dataGridViewGamer1.CurrentCell.ColumnIndex;
                    int row = dataGridViewGamer1.CurrentCell.RowIndex + 1;
                    dataGridViewGamer1.CurrentCell = dataGridViewGamer1[col, row];
                }
                if (e.KeyCode == Keys.NumPad8 && IsPause == false)
                {
                    dataGridViewGamer2.Enabled = true;
                    int col = dataGridViewGamer2.CurrentCell.ColumnIndex;
                    int row = dataGridViewGamer2.CurrentCell.RowIndex - 1;
                    dataGridViewGamer2.CurrentCell = dataGridViewGamer2[col, row];
                }
                if (e.KeyCode == Keys.NumPad2 && IsPause == false)
                {
                    dataGridViewGamer2.Enabled = true;
                    int col = dataGridViewGamer2.CurrentCell.ColumnIndex;
                    int row = dataGridViewGamer2.CurrentCell.RowIndex + 1;
                    dataGridViewGamer2.CurrentCell = dataGridViewGamer2[col, row];
                }
                if (e.KeyCode == Keys.NumPad4 && IsPause == false)
                {
                    dataGridViewGamer2.Enabled = true;
                    int col = dataGridViewGamer2.CurrentCell.ColumnIndex - 1;
                    int row = dataGridViewGamer2.CurrentCell.RowIndex;
                    dataGridViewGamer2.CurrentCell = dataGridViewGamer2[col, row];
                }
                if (e.KeyCode == Keys.NumPad6 && IsPause == false)
                {
                    dataGridViewGamer2.Enabled = true;
                    int col = dataGridViewGamer2.CurrentCell.ColumnIndex + 1;
                    int row = dataGridViewGamer2.CurrentCell.RowIndex;
                    dataGridViewGamer2.CurrentCell = dataGridViewGamer2[col, row];
                }

                if (e.KeyCode == Keys.Space && IsPause == false)
                {
                    dataGridViewGamer1.Enabled = true;
                    firstscore += CheckPicture(dataGridViewGamer1, pictureshow, firstTable);
                    labelFirstGamerCount.Text = firstscore.ToString();
                }
                if (e.KeyCode == Keys.NumPad5 && IsPause == false)
                {
                    dataGridViewGamer2.Enabled = true;
                    secondscore += CheckPicture(dataGridViewGamer2, pictureshow, secondTable);
                    labelSecondGamerCount.Text = secondscore.ToString();
                }
            }
            catch { }
            dataGridViewGamer1.Enabled = false;
            dataGridViewGamer2.Enabled = false;
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
            FormMenu menu = new FormMenu();
            menu.Show();
        }

        private void ToolStripMenuItemStopOrGo_Click(object sender, EventArgs e)
        {
            if (ToolStripMenuItemStopOrGo.Text == "Пауза")
            {
                timerChangePicture.Stop();
                ToolStripMenuItemStopOrGo.Text = "Вперёд!";
                IsPause = true;
            }
            else
            {
                timerChangePicture.Start();
                ToolStripMenuItemStopOrGo.Text = "Пауза";
                IsPause = false;
            }
        }
        void Winner(string first, string second, int one, int two)
        {
            if (one > two) MessageBox.Show("Ура,у нас есть победитель. Это " + gamer1+" . Поздравляем!");
            if (one < two) MessageBox.Show("Ура,у нас есть победитель. Это " + gamer2+ " . Поздравляем!");
            if (one == two) MessageBox.Show("Ура! Победила дружба! Все молодцы!");
            StreamWriter file = new StreamWriter("results");
            file.Write(one + Convert.ToInt32(prMeans[0]) + " ");
            file.Write(two + Convert.ToInt32(prMeans[1]));
            file.Close();
        }
    }
}
