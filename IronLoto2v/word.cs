using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IronLoto2v
{
    public class word
    {
        string[] mas;
        string ironword;
        string rusword;
        Image pictureshow;
        public word(string ss)
        {
            string[]s=ss.Split(' ');
            mas = s;
        }        
        public string LoadRusWord()
        {
            rusword = mas[1];
            return rusword;
        }
        public string LoadIronWord()
        {
            ironword = mas[2];
            return ironword;
        }
        public Image GetIronWord()
        {
            string name = "p" + mas[0] + "irword";
            pictureshow = (Image)Properties.Resources.ResourceManager.GetObject(name);
            return pictureshow;
        }
        public int NumberOf() 
        {
            return Convert.ToInt32(mas[0]); 
        }
        public Image GetPicture()
        {
            string name = "p" + mas[0];
            pictureshow=(Image)Properties.Resources.ResourceManager.GetObject(name);
            return pictureshow;
        }
        public Image GetRusPicture()
        {
            string name = "p" + mas[0]+"ru";
            pictureshow = (Image)Properties.Resources.ResourceManager.GetObject(name);
            return pictureshow;
        }
        public Image GetIrPicture()
        {
            string name = "p" + mas[0]+"ir";
            pictureshow = (Image)Properties.Resources.ResourceManager.GetObject(name);
            return pictureshow;
        }
    }
}
