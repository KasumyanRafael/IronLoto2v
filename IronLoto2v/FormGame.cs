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
            s = Properties.Resources.dictionary.Split('\n');
            filling(dataGridViewGamer1,s,x,y);
            filling(dataGridViewGamer2, s, x, y);
            timerChangePicture.Enabled = true;
            timerChangePicture.Interval = t*1000;
            
        }

        private void dataGridViewGamer1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("В данной игре запрещено ходить мышкой. Смысл в конкуренции)");
        }

        private void dataGridViewGamer2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("В данной игре запрещено ходить мышкой. Смысл в конкуренции)");
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
        void antirepeat(int[]perm,int n)
        {
            Random r = new Random(); // не создавайте новый Random здесь!
                                     // а то значения будут одни и те же
            for (int i = n - 1; i >= 1; i--)
            {
                int j = r.Next(i + 1);
                // exchange perm[j] and perm[i]
                int temp = perm[j];
                perm[j] = perm[i];
                perm[i] = temp;
            }
        }
    }
}

   

  
