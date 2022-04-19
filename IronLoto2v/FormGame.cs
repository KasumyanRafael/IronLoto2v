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
        string[] numbers = new string[92];
        int x = 3;
        int y = 4;
        int t = 5000;
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
            antirepeat(numbers);
        }

        private void dataGridViewGamer1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("В данной игре запрещено ходить мышкой. Смысл в конкуренции)");
        }

        private void dataGridViewGamer2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("В данной игре запрещено ходить мышкой. Смысл в конкуренции)");
        }
        void antirepeat(string[] array)
        {
            Random random = new Random();
            for (int i = array.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                // обменять значения data[j] и data[i]
                var temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }
        
    }
}

   

  
