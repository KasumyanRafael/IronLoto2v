using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace IronLoto2v
{
    public class Word
    {
        string[] mas;
        string ironword;
        string rusword;
        Image pictureshow;
        public Word(string ss)
        {
            string[]s=ss.Split(' ');
            mas = s;
        }        
        public string LoadRusWord()  //выгрузка русского слова
        {
            rusword = mas[1];
            return rusword;
        }
        public string LoadIronWord() //осетинское слово
        {
            ironword = mas[2];
            return ironword;
        }
        public Image GetIronWord() //осетинское слово(в виде изображения)
        {
            string name = "p" + mas[0] + "irword";
            pictureshow = (Image)Properties.Resources.ResourceManager.GetObject(name);
            return pictureshow;
        }
        public int NumberOf() //номер элемента
        {
            return Convert.ToInt32(mas[0]); 
        }
        public Image GetPicture() //картинка без надписей
        {
            string name = "p" + mas[0];
            pictureshow=(Image)Properties.Resources.ResourceManager.GetObject(name);
            return pictureshow;
        }
        public Image GetRusPicture() //русская картинка
        {
            string name = "p" + mas[0]+"ru";
            pictureshow = (Image)Properties.Resources.ResourceManager.GetObject(name);
            return pictureshow;
        }
        public Image GetIrPicture() //осетинская картинка
        {
            string name = "p" + mas[0]+"ir";
            pictureshow = (Image)Properties.Resources.ResourceManager.GetObject(name);
            return pictureshow;
        }
    }
    public class GameUser
    {
        public string Name { get; set; }
        int score;
        public void RoundLoad(GameUser gamer,Label labelname,Label labelscore)
        {
            labelname.Text = gamer.Name;
            labelscore.Text=score.ToString();
        }
    }
    public class GameField
    {
        int x;
        int y;
        string[] s;
        Word[] list;
        Word[] extract;
        int countpic;
        int[,] undertable;//таблица номеров соответствующих картинок
        DataGridView data;
        public GameField(DataGridView datum,int a, int b,string[]mas,GameUser user) //конструктор строит таблицу
        {
            s = mas;
            x = a;
            y = b;
            DataGridViewImageColumn[] columns = new DataGridViewImageColumn[b];
            for (int i = 0; i < b; i++)
            {
                columns[i] = new DataGridViewImageColumn();
                columns[i].Width = 236;
            }
            datum.RowTemplate.Height = 236;
            datum.Columns.AddRange(columns);
            datum.Rows.Add(a - 1);
            datum.CurrentCell = this.data[0, 0];
            data = datum;
            list = ToWord(s);
            antirepeat(list, s);
            extract = GetExtract(list); //ЭТО МЫ ВЫБРАЛИ 10 КАРТОЧЕК ИЗ 92+
            countpic=extract.Length; //число картинок отображается в лейбле
        }
        public void DrawFields(GameField first,GameField second) //использовать в основной программе, заполнение таблицы
        {
            Fill(first, first.extract, first.x, first.y, first.undertable);
            do
            {
                Fill(second, second.extract, second.x, second.y, second.undertable);
            }
            while (antitwin(first.undertable, second.undertable, first.x, second.y) != false); //при занесении параметров игрок не имеет значения, так как две таблицы равны
        }
        Word[] ToWord(string[] a)
        {
            Word[] temp = new Word[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                temp[i] = new Word(a[i]);
            }
            return temp;
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
            for (int i = 0; i < 10; i++)
            {
                result[i] = perm[i];
            }
            return result;
        }
        void Shuffling(Word[] data)
        {
            Random rnd = new Random();
            for (int i = data.Length - 1; i >= 1; i--)
            {
                int j = rnd.Next(i + 1);
                var temp = data[j];
                data[j] = data[i];
                data[i] = temp;
            }
        }
        void Fill(GameField table, Word[] array, int a, int b, int[,] tr)
        {
            /*Random rnd = new Random();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    int c = rnd.Next(1, array.Length);
                    Word temp = array[c];
                    data.Rows[i].Cells[j].Value = temp.GetIrPicture();
                    tr[i, j] = temp.NumberOf();
                }
            }*/
            int k = 0;
            try
            {
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        table.data.Rows[i].Cells[j].Value = array[k].GetIrPicture();
                        tr[i, j] = array[k].NumberOf();
                        k++;
                    }
                }
            }
            catch { }
            Shuffling(array);
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
    }
}
