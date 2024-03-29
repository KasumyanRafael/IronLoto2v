﻿using System;
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
        public static int regime = 1;
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
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            dataGridViewGamer1.Width=dataGridViewGamer1.Width*ClientSize.Width/this.Width;
            dataGridViewGamer1.Height=dataGridViewGamer1.Height*ClientSize.Height/this.Height;
            dataGridViewGamer2.Width = dataGridViewGamer2.Width * ClientSize.Width / this.Width;
            dataGridViewGamer2.Height = dataGridViewGamer2.Height * ClientSize.Height / this.Height; //адаптив таблиц
        }
        public void Start()
        {
            labelRounds.Text = String.Format("{0} раунд",regime);
            firstfield.Fill(extract, x, y, regime.ToString());
            secondfield.Fill(extract, x, y, regime.ToString());
            switch(regime)
            {
                case 1: switcher = new Switcher(extract, timerFirstRound, img, pictureBoxShow, labelCountdown, labelPicturesCount, t, firstgamer, buttonRoundsAccelerator, regime);break;
                case 2: switcher = new Switcher(extract, timerSecondRound, img, pictureBoxShow, labelCountdown, labelPicturesCount, t, firstgamer, buttonRoundsAccelerator, regime); break;
                case 3: switcher = new Switcher(extract, timerFinalRound, img, pictureBoxShow, labelCountdown, labelPicturesCount, t, firstgamer, buttonRoundsAccelerator, regime); break;
            }
            //switcher = new Switcher(extract,timerCountdown, img, pictureBoxShow, labelCountdown, labelPicturesCount, t, firstgamer, buttonRoundsAccelerator, regime);
            regime++;
            switcher.labelPicturesCount.Text = String.Format("{0}/{0}", extract.MasLength.ToString());
            switcher.Start(); //до сюда
        }
        private void FormGame_Load(object sender, EventArgs e)
        {
            firstgamer = new GameUser(labelFirstGamer, labelFirstGamerCount, firstname);
            secondgamer = new GameUser(labelSecondGamer, labelSecondGamerCount, secondname);
            firstgamer.opponent = secondgamer;
            secondgamer.opponent = firstgamer;
            firstfield = new GameTable(dataGridViewGamer1, x, y, firstgamer, labelNoWayGamer1);
            secondfield = new GameTable(dataGridViewGamer2, x, y, secondgamer, labelNoWayGamer2);
            firstfield.Clear(x, y);
            secondfield.Clear(x, y);
            s = Properties.Resources.dictionary__1_.Split('\n');
            extract = new WordExtract(s, 2 * x * y); //начиная отсюда,обновляем данные
            img = new Card(extract.mas[0]);
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
            timerFirstRound.Stop();
            FormMenu menu = new FormMenu();
            menu.Show();
        }

        private void ToolStripMenuItemUsersChange_Click(object sender, EventArgs e)
        {
            timerFirstRound.Stop();
            FormIntroduction form = new FormIntroduction();
            form.Show();
        }


        private void ToolStripMenuItemDirections_Click(object sender, EventArgs e)
        {
            ToolStripMenuItemPause.Text = "Вперёд!";
            timerFirstRound.Stop();
            labelPause.Visible = true;
            FormDirections frm = new FormDirections();
            frm.Show();
        }

        private void ToolStripMenuItemPause_Click(object sender, EventArgs e)
        {
            if (ToolStripMenuItemPause.Text == "Пауза")
            {
                timerFirstRound.Stop();
                ToolStripMenuItemPause.Text = "Вперёд!";
                IsPause = true;
                labelPause.Visible = true;
            }
            else
            {
                timerFirstRound.Start();
                ToolStripMenuItemPause.Text = "Пауза";
                IsPause = false;
                labelPause.Visible = false;
            }
        }
        private void buttonRoundsAccelerator_Click_1(object sender, EventArgs e)
        {
            switcher = null;
            if(regime==4)
            {
                FormResults formResults = new FormResults();
                formResults.Show();
                this.Hide();
            }
            buttonRoundsAccelerator.Text = "Следующий раунд";
            labelFirstGamerCount.Text = "0";
            labelSecondGamerCount.Text = "0";
            buttonRoundsAccelerator.Visible = false;
            Start();
        }
    }
}

   

  
