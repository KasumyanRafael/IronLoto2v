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
        int x = 30;
        int y = 60;
        int t = 2;
        int cnt = 0;
        string[] s;
        word[] list;

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
                columns[i].Width = 216;
            }

            data.RowTemplate.Height = 216;
            data.Columns.AddRange(columns);
            data.Rows.Add(a - 1);
        }
        private void FormGame_Load(object sender, EventArgs e)
        {
            drawData(dataGridViewGamer1, x, y);
            drawData(dataGridViewGamer2, x, y);
            dataGridViewGamer1.CurrentCell = this.dataGridViewGamer1[0, 0];
            dataGridViewGamer2.CurrentCell = this.dataGridViewGamer2[0, 0];
            s = Properties.Resources.dictionary.Split('\n');
            list = ToWord(s);
            antirepeat(list,s);
            filling(dataGridViewGamer1,s,x,y);
            filling(dataGridViewGamer2, s, x, y);
            timerChangePicture.Enabled = true;
            timerChangePicture.Interval = t*1000;
            
        }
        void filling(DataGridView data,string[]array,int a,int b)
        {
            Random rnd=new Random();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    int c=rnd.Next(1,array.Length);
                    word temp=new word(array[c]);
                    data.Rows[i].Cells[j].Value=temp.GetIrPicture();
                }
            }
        }
        void antirepeat(word[]perm,string[]s)
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

        private void dataGridViewGamer1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("В данной игре запрещено ходить мышкой. Смысл в конкуренции)");
        }

        private void dataGridViewGamer2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("В данной игре запрещено ходить мышкой. Смысл в конкуренции)");
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                int col = dataGridViewGamer1.CurrentCell.ColumnIndex + 1;
                int row = dataGridViewGamer1.CurrentCell.RowIndex;
                dataGridViewGamer1.CurrentCell = dataGridViewGamer1[col, row];
            }
            if (e.KeyCode == Keys.W)
            {
                int col = dataGridViewGamer1.CurrentCell.ColumnIndex;
                int row = dataGridViewGamer1.CurrentCell.RowIndex - 1;
                dataGridViewGamer1.CurrentCell = dataGridViewGamer1[col, row];
            }
            if (e.KeyCode == Keys.A)
            {
                int col = dataGridViewGamer1.CurrentCell.ColumnIndex - 1;
                int row = dataGridViewGamer1.CurrentCell.RowIndex;
                dataGridViewGamer1.CurrentCell = dataGridViewGamer1[col, row];
            }
            if (e.KeyCode == Keys.S)
            {
                int col = dataGridViewGamer1.CurrentCell.ColumnIndex;
                int row = dataGridViewGamer1.CurrentCell.RowIndex + 1;
                dataGridViewGamer1.CurrentCell = dataGridViewGamer1[col, row];
            }
            if (e.KeyCode == Keys.Up)
            {
                int col = dataGridViewGamer2.CurrentCell.ColumnIndex;
                int row = dataGridViewGamer2.CurrentCell.RowIndex - 1;
                dataGridViewGamer2.CurrentCell = dataGridViewGamer2[col, row];
            }
            if (e.KeyCode == Keys.Down)
            {
                int col = dataGridViewGamer2.CurrentCell.ColumnIndex;
                int row = dataGridViewGamer2.CurrentCell.RowIndex + 1;
                dataGridViewGamer2.CurrentCell = dataGridViewGamer2[col, row];
            }
            if (e.KeyCode == Keys.Left)
            {
                int col = dataGridViewGamer2.CurrentCell.ColumnIndex - 1;
                int row = dataGridViewGamer2.CurrentCell.RowIndex;
                dataGridViewGamer2.CurrentCell = dataGridViewGamer2[col, row];
            }
            if (e.KeyCode == Keys.Right)
            {
                int col = dataGridViewGamer2.CurrentCell.ColumnIndex + 1;
                int row = dataGridViewGamer2.CurrentCell.RowIndex;
                dataGridViewGamer2.CurrentCell = dataGridViewGamer2[col, row];
            }
        }
        static word[]ToWord(string[]a)
        {
            word[]temp=new word[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                temp[i] = new word(a[i]);
            }
            return temp;
        }

        private void timerChangePicture_Tick(object sender, EventArgs e)
        {
            cnt++;
            pictureBoxShow.Image=list[cnt].GetPicture();
            labelWord.Text=list[cnt].LoadRusWord();
        }
    }
}

   

  
