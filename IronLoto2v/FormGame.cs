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
        public static int regime = 0;
        public string firstname;
        public string secondname;
        public GameUser firstgamer;
        public GameUser secondgamer;
        static int x = 3;
        static int y = 2;
        static int t = 1000;
        bool IsPause = false;
        string[] s;
        WordExtract extract;
        Card img;  //демонстрируемые картинки
        GameTable firstfield;
        GameTable secondfield;
        Switcher switcher;
        public FormGame()
        {
            InitializeComponent();
        }
        public void Start()
        {
            firstgamer = new GameUser(labelFirstGamer, labelFirstGamerCount, firstname);
            secondgamer = new GameUser(labelSecondGamer, labelSecondGamerCount, secondname);
            firstgamer.opponent = secondgamer;
            secondgamer.opponent = firstgamer;
            firstfield = new GameTable(dataGridViewGamer1, x, y, firstgamer, labelNoWayGamer1);
            secondfield = new GameTable(dataGridViewGamer2, x, y, secondgamer, labelNoWayGamer2);
            s = Properties.Resources.dictionary__1_.Split('\n');
            extract = new WordExtract(s, 10); //начиная отсюда,обновляем данные
            img = new Card(extract.mas[0]);
            firstfield.Fill(extract, x, y, regime.ToString()); 
            do
            {
                secondfield.Fill(extract, x, y, regime.ToString());
            }
            while (!antitwin(firstfield.undertable, secondfield.undertable, x, y));
            switcher = new Switcher(timerCountdown, img, pictureBoxShow, extract, labelCountdown, labelPicturesCount, t, firstgamer);
            switcher.labelPicturesCount.Text = String.Format("{0}/{0}", extract.MasLength.ToString());
            switcher.Start(); //до сюда
        }
        private void FormGame_Load(object sender, EventArgs e)
        {
            regime++;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Start();
            if (firstgamer.WeFoundWinner == true && regime < 3)
            {
                Start();
            }
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
                    firstfield.IsTheSameCard(switcher, extract);
                }
                if (e.KeyCode == Keys.NumPad5 && IsPause == false)
                {
                    secondfield.IsTheSameCard(switcher, extract);
                }
            }
            catch { }
            dataGridViewGamer1.Enabled = false;
            dataGridViewGamer2.Enabled = false;

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

   

  
