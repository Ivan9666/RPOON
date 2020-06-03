using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5_peti
{
    abstract class Note
    {
        private string message;
        private Itheme theme;
        public Note(string message, Itheme theme)
        {
            this.message = message;
            this.theme = theme;
        }
        public string Message { get { return this.message; } }
        public Itheme Theme { set { this.theme = value; } }
        protected void ChangeColor()
        {
            this.theme.SetBackgroundColor();

            this.theme.SetFontColor();

        }
        protected string GetFramedMessage()
        {
            int width = this.message.Length;
            return this.theme.GetHeader(width) + "\n" +
             message + "\n" + this.theme.GetFooter(width);
        }

        public abstract void Show();
    }
}
