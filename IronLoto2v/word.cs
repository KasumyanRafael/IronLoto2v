using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace IronLoto2v
{
    /// <summary>
    /// Массив, где хранятся номер слова, русское и осетинское слова
    /// </summary>
    public class Word
    {
        string[] mas; //word это массив из трёх элементов-номера,русского и осетинского слов
        string ironword;//осетинское слово
        string rusword;//русское слово
        Image pictureshow;//картинка, которая может быть русской, осетинской или без подписи
        /// <summary>
        /// Конвертация подающейся из файла строки в массив объекта Word
        /// </summary>
        /// <returns></returns>
        public Word(string ss)
        {
            mas = ss.Split(' ');
        } 
        /// <summary>
        /// выделение русского слова
        /// </summary>
        /// <returns>
        /// русское слово
        /// </returns>
        public string LoadRusWord()  
        {
            rusword = mas[1];
            return rusword;
        }
        /// <summary>
        /// выделение осетинского слова
        /// </summary>
        /// <returns>
        /// осетинское слово (напечатанное)
        /// </returns>
        public string LoadIronWord() 
        {
            ironword = mas[2];
            return ironword;
        }
        /// <summary>
        /// выделение осетинского слова Image
        /// </summary>
        /// <returns>
        /// осетинское слово (картинка со словом)
        /// </returns>
        public Image GetIronWord() 
        {
            string name = "p" + mas[0] + "irword";
            pictureshow = (Image)Properties.Resources.ResourceManager.GetObject(name);
            return pictureshow;
        }
        /// <summary>
        /// получение номера слова из списка
        /// </summary>
        /// <returns>
        /// порядковый номер
        /// </returns>
        public int NumberOf() 
        {
            return Convert.ToInt32(mas[0]); 
        }
        /// <summary>
        /// получение картитнки без подписи
        /// </summary>
        /// <returns>
        /// картинка без подписи
        /// </returns>
        public Image GetPicture() 
        {
            string name = "p" + mas[0];
            pictureshow=(Image)Properties.Resources.ResourceManager.GetObject(name);
            return pictureshow;
        }
        /// <summary>
        /// получение картитнки с русским названием
        /// </summary>
        /// <returns>
        /// картинка с русской подписью
        /// </returns>
        public Image GetRusPicture() //русская картинка
        {
            string name = "p" + mas[0]+"ru";
            pictureshow = (Image)Properties.Resources.ResourceManager.GetObject(name);
            return pictureshow;
        }
        /// <summary>
        /// получение картитнки с осетинской подписью
        /// </summary>
        /// <returns>
        /// картинка с осетинской подписью
        /// </returns>
        public Image GetIrPicture() //осетинская картинка
        {
            string name = "p" + mas[0]+"ir";
            pictureshow = (Image)Properties.Resources.ResourceManager.GetObject(name);
            return pictureshow;
        }
    }
    /// <summary>
    /// Класс, характеризующий пользователя игры
    /// </summary>
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
    /// <summary>
    /// класс, описывающий поля с картинками
    /// </summary>
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
            data = datum;
            data.CurrentCell = this.data[0, 0];
            list = ToWord(s);
            antirepeat(list, s);
            extract = GetExtract(list); //ЭТО МЫ ВЫБРАЛИ 10 КАРТОЧЕК ИЗ 92+
            countpic=extract.Length; //число картинок отображается в лейбле
        }
        /// <summary>
        /// Здесь мы заполняем таблицы так,чтобы они никогда не были одинаковыми
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
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
        /// <summary>
        /// Метод заполнения одной таблицы. Используется в DrawFields
        /// </summary>
        /// <param name="table"></param>
        /// <param name="array"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="tr"></param>
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
        /// <summary>
        /// Нельзя, чтобы таблицы были абсолютно одинаковыми
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
    }
}
