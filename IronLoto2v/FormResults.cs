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
        public FormResults()
        {
            InitializeComponent();
        }

        private void FormResults_Load(object sender, EventArgs e)
        {
            drawData(dataGridViewResults);
            fillData(dataGridViewResults);
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
            string[] arr = file.ReadLine().Split(' ');
            string[] arr2 = file2.ReadLine().Split(' ');
            string[] arr3 = file3.ReadLine().Split(' ');
            file.Close();
            file2.Close();
            file3.Close();
            data.Rows[0].Cells[0].Value = arr[0].ToString();
            data.Rows[0].Cells[1].Value = arr[1].ToString();
            data.Rows[1].Cells[0].Value = arr2[0].ToString();
            data.Rows[1].Cells[1].Value = arr2[1].ToString();
            data.Rows[2].Cells[0].Value = arr2[0].ToString();
            data.Rows[2].Cells[1].Value = arr[1].ToString();
        }
    }
}
