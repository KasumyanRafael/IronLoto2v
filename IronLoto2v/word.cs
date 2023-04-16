using System;
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
            pictureshow = (Image)Properties.Resources.ResourceManager.GetObject(name);
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
            string name = "p" + mas[0] + "ru";
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
            string name = "p" + mas[0] + "ir";
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
        /// <summary>
        /// Баллы за раунд
        /// </summary>
        public int localscore;
        /// <summary>
        /// Баллы за игру
        /// </summary>
        public int globalscore = 0;
        Label labelNick;
        public GameUser opponent;
        public Label labelcount;
        public bool WeFoundWinner = false;
        static int gameround=0;
        public int[] roundresults = new int[3];
        public GameUser(Label labelname, Label labelscore, string name)
        {
            Name = name;
            localscore = 0;
            labelname.Text = Name;
            labelscore.Text = localscore.ToString();
            labelNick = labelname;
            labelcount = labelscore;
        }
        public void IncreaseGlobalScore()
        {
            globalscore += localscore;
            roundresults[gameround] = localscore;
            localscore = 0;
            opponent.globalscore += opponent.localscore;
            opponent.roundresults[gameround] = opponent.localscore;
            opponent.localscore = 0;
            gameround++;
            labelcount.Text = "0";
            opponent.labelcount.Text = "0";
        }
    }
    /// <summary>
    /// класс, описывающий поля с картинками
    /// </summary>
    public class GameTable
    {
        public int x;
        public int y;
        public int[,] undertable;//таблица номеров соответствующих картинок
        public DataGridView data;
        public GameUser localuser;
        public Label labelway;
        public GameTable(DataGridView datum, int a, int b, GameUser user,Label label) //конструктор строит таблицу
        {
            x = a;
            y = b;
            localuser = user;
            labelway = label;
            DataGridViewImageColumn[] columns = new DataGridViewImageColumn[b];
            for (int i = 0; i < b; i++)
            {
                columns[i] = new DataGridViewImageColumn();
                columns[i].Width = datum.Width/y-4;
            }
            datum.RowTemplate.Height = datum.Height/3-4; ///адаптивная таблица
            datum.Columns.AddRange(columns);
            datum.Rows.Add(a - 1);
            data = datum;
            data.CurrentCell = this.data[0, 0];
        }
        /// <summary>
        /// Метод заполнения одной таблицы. Используется в DrawFields
        /// </summary>
        /// <param name="table"></param>
        /// <param name="array"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="tr"></param>
        public void Fill(WordExtract array, int a, int b, string regime)
        {
            Bitmap bmp;
            int k = 0;
            undertable = new int[x, y];
            try
            {
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        Card card = new Card(array.mas[k]);
                        switch (regime)
                        {
                            case "1":
                                bmp = new Bitmap(card.CatchIrPicture(), new Size(data.Width / b, data.Width / b)); //здесь изображение подстраивается под размеры ячейки
                                data.Rows[i].Cells[j].Value = Image.FromHbitmap(bmp.GetHbitmap());
                                break;
                            case "2":
                                bmp = new Bitmap(card.CatchIrPicture(), new Size(data.Width / b, data.Width / b)); //здесь изображение подстраивается под размеры ячейки
                                data.Rows[i].Cells[j].Value = Image.FromHbitmap(bmp.GetHbitmap());
                                break;
                            case "3":
                                bmp = new Bitmap(card.CatchIrWord(), new Size(data.Width / b, data.Width / b)); //здесь изображение подстраивается под размеры ячейки
                                data.Rows[i].Cells[j].Value = Image.FromHbitmap(bmp.GetHbitmap());
                                break;
                        }
                        undertable[i, j] = card.number;
                        if (k!= 2*a*b+1) k++;
                    }
                }
            }
            catch { }
            array.Shuffling();
        }
        public void Clear(int a,int b)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    data.Rows[i].Cells[j].Value = Properties.Resources.pwhite;
                }
            }
        }
        /// <summary>
        /// Функция, определяющая, можно ли повысить игроку балл. Вызывается в методе IsTheSameCard
        /// </summary>
        /// <param name="switcher"></param>
        /// <param name="extract"></param>
        /// <returns></returns>
        public int IncreaseLocalScore(WordExtract extract, Switcher localswitcher)
        {
            int a = data.CurrentCell.RowIndex;
            int b = data.CurrentCell.ColumnIndex;
            if (undertable[a, b] == localswitcher.contentId)
            {
                data.CurrentCell.Value = Properties.Resources.pwhite;
                undertable[a, b] = 0;
                localswitcher.cnt++; //Здесь начинается та самая конкуренция!
                localswitcher.countdown = 10;
                localswitcher.picturebox.Image = extract.mas[localswitcher.cnt].GetRusPicture();
                localswitcher.contentId = extract.mas[localswitcher.cnt].NumberOf();
                localswitcher.countpic--;
                localswitcher.labelPicturesCount.Text = localswitcher.countpic.ToString() + String.Format("/{0}",extract.MasLength.ToString());
                return 1;
            }
            else if (undertable[a, b] != 0) labelway.Visible = true;
            return 0;
        }
        /// <summary>
        /// Происходит, когда игрок "ходит" по таблице и отмечает клетки. Здесь же определяется победитель
        /// </summary>
        /// <param name="switcher"></param>
        /// <param name="extract"></param>
        public void IsTheSameCard(Switcher switcher,WordExtract extract)
        {
            localuser.localscore += IncreaseLocalScore(extract,switcher);
            localuser.labelcount.Text = localuser.localscore.ToString();
        }
        
    }
    public class Switcher
    {
        public PictureBox picturebox;
        public int contentId;
        public Timer timer;
        Card img;
        public WordExtract extract;
        public int cnt = 0;
        public int countdown = 10;
        public int countpic;
        Label labelCountdown;
        public Label labelPicturesCount;
        int round;
        GameUser gameuser;
        Button button;
        public Switcher(Timer havetime,Card card, PictureBox havepicture, WordExtract newextract, Label locallabelCountdown, Label locallabelpicturescount, int t,GameUser gameuser,Button btn,int reg)
        {
            img = card;
            labelPicturesCount = locallabelpicturescount;
            labelCountdown = locallabelCountdown;
            extract = newextract;
            picturebox = havepicture;
            timer = havetime;
            img.number = contentId;
            timer.Enabled = true;
            timer.Interval = t;
            countpic = extract.MasLength;
            this.gameuser = gameuser;
            button = btn;
            round=reg;
        }
        /// <summary>
        /// Запуск таймера
        /// </summary>
        public void Start()
        {
            timer.Enabled = true;
            timer.Tick += Timer_Tick;
        }
        public void Stop()
        {
            timer.Stop();
            gameuser.IncreaseGlobalScore();
            button.Visible = true;
        }
        public void Timer_Tick(object sender, EventArgs e)
        {
            if (gameuser.localscore == 6 || gameuser.opponent.localscore == 6)
            {
                this.Stop();
            }
            if (countpic != 0)
            {
                img = new Card(extract.mas[cnt]);
                switch (round)
                {
                    case 1: picturebox.Image = img.CatchRusPicture(); break;
                    case 2: picturebox.Image = img.CatchPicture(); break;
                    case 3: picturebox.Image = img.CatchPicture(); break;
                }
                contentId = img.number;
                countdown--;
                labelCountdown.Text = countdown.ToString();
                if (countdown < 5) labelCountdown.ForeColor = Color.Red;
                else labelCountdown.ForeColor = Color.Black;
                if (countdown == 0)
                {
                    countdown = 10;
                    cnt++;
                    countpic--;
                    labelPicturesCount.Text = countpic.ToString() + String.Format("/{0}", extract.MasLength.ToString());
                }
            }
            else
            {
                this.Stop();
            }
        }
    }
    /// <summary>
    /// Класс представляет собой массив из 10 объектов Word, используемых в игре
    /// </summary>
    public class WordExtract
    {
        public int MasLength { get; set; }
        int count;
        public Word[] mas;
        public WordExtract(string[] s,int num)
        {

            count = num+1;
            mas = ToWord(s);
            antirepeat(mas, s);
            Word[] a = GetExtract(mas);
            mas = a;
            MasLength = mas.Length;
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
            Word[] result = new Word[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = perm[i];
            }
            return result;
        }
        public void Shuffling()
        {
            Random rnd = new Random();
            for (int i = count-2; i >= 1; i--)
            {
                int j = rnd.Next(i + 1);
                var temp = mas[j];
                mas[j] = mas[i];
                mas[i] = temp;
            }
        }
    }
    /// <summary>
    /// Улучшенная карточка. В отличие от Word, имеет свой номер.
    /// </summary>
    public class Card
    {
        Word word;
        public int number { get; set; }
        public Card(Word temp)
        {
            word = temp;
            number = word.NumberOf();
        }
        /// <summary>
        /// получение картитнки с русским названием
        /// </summary>
        /// <returns>
        /// картинка с русской подписью
        /// </returns>
        public Image CatchRusPicture()
        {
            number = word.NumberOf();
            return word.GetRusPicture();
        }
        /// <summary>
        /// получение картитнки с осетинской подписью
        /// </summary>
        /// <returns>
        /// картинка с осетинской подписью
        /// </returns>
        public Image CatchIrPicture()
        {
            number = word.NumberOf();
            return word.GetIrPicture();
        }
        /// <summary>
        /// получение картитнки без подписи
        /// </summary>
        /// <returns>
        /// картинка без подписи
        /// </returns>
        public Image CatchPicture()
        {
            number = word.NumberOf();
            return word.GetPicture();
        }
        /// <summary>
        /// выделение осетинского слова Image
        /// </summary>
        /// <returns>
        /// осетинское слово (картинка со словом)
        /// </returns>
        public Image CatchIrWord()
        {
            number = word.NumberOf();
            return word.GetIronWord();
        }
    }
}
