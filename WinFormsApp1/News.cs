using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class News
    {
        public int id;
        public string author;
        public string text;
        public byte[] image;
        public News(int id, string author, string text, byte[] image)
        {
            this.id = id;
            this.author = author;
            this.text = text;
            this.image = image;
        }

        public News(string author,string text, byte[] image)
        {
            this.author = author;
            this.text = text;
            this.image = image;
        }
    }
}
