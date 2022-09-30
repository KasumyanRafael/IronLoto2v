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
}
