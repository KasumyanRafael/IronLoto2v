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
    public partial class FormResults : Form
    {
        public string gamer1;
        public string gamer2;
        string[] arr1;
        string[] arr2;
        string[] arr3;
        public FormResults()
        {
            InitializeComponent();
        }

        private void FormResults_Load(object sender, EventArgs e)
        {
            drawData(dataGridViewResults);
            fillData(dataGridViewResults);
            KnowResults(dataGridViewResults, arr1, arr2, arr3);
        }
        void drawData(DataGridView data)
        {
            ColumnGamer1.HeaderText = gamer1;
            ColumnGamer2.HeaderText = gamer2;
            data.RowTemplate.Height = 100;
            data.Rows.Add(4);
            int i = 0;
            foreach(DataGridViewRow row in data.Rows)
            {
                i++;
                if(i!=4)
                {
                    row.HeaderCell.Value="Раунд "+i.ToString();
                }
                else
                {
                    row.HeaderCell.Value="Итого:".ToString();
                    break;
                }
            }
        }
        void fillData(DataGridView data)
        {
            StreamReader file = new StreamReader("first.txt");
            StreamReader file2 = new StreamReader("second.txt");
            StreamReader file3 = new StreamReader("final.txt");
            arr1 = file.ReadLine().Split(' ');
            arr2 = file2.ReadLine().Split(' ');
            arr3 = file3.ReadLine().Split(' ');
            file.Close();
            file2.Close();
            file3.Close();
            data.Rows[0].Cells[0].Value = arr1[0].ToString();
            data.Rows[0].Cells[1].Value = arr1[1].ToString();
            data.Rows[1].Cells[0].Value = arr2[0].ToString();
            data.Rows[1].Cells[1].Value = arr2[1].ToString();
            data.Rows[2].Cells[0].Value = arr3[0].ToString();
            data.Rows[2].Cells[1].Value = arr3[1].ToString();
        }
        void KnowResults(DataGridView data,string[]a,string[]b,string[]c)
        {
            int[] results = new int[2];
            results[0] = Convert.ToInt32(a[0]) + Convert.ToInt32(b[0]) + Convert.ToInt32(c[0]);
            results[1] = Convert.ToInt32(a[1]) + Convert.ToInt32(b[1]) + Convert.ToInt32(c[1]);
            data.Rows[3].Cells[0].Value = results[0];
            data.Rows[3].Cells[1].Value= results[1];
            if(results[0]>results[1])
            {
                MessageBox.Show("И у нас есть победитель! Это " + gamer1 + " От всей души желаем тебе счастья, здоровья. Никогда не забывай родной язык, иначе тебе будет очень трудно. Приходи ещё");
            }
            else
            {
                if(results[1]>results[0])
                {
                    MessageBox.Show("И у нас есть победитель! Это " + gamer2 + " От всей души желаем тебе счастья, здоровья. Никогда не забывай родной язык, иначе тебе будет очень трудно. Приходи ещё");
                }
                else
                {
                    MessageBox.Show("Невероятно! Победила дружба! Приходите ещё, чтобы взять реванш. Никогда не забывайте родной язык!");
                }
            }
        }

        private void ToolStripMenuItemNewGame_Click(object sender, EventArgs e)
        {
            FormGame game = new FormGame();
            game.Show();
        }

        private void ToolStripMenuItemMenu_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
        }

        private void ToolStripMenuItemUsers_Click(object sender, EventArgs e)
        {
            FormIntroduction formIntroduction = new FormIntroduction();
            formIntroduction.Show();
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
