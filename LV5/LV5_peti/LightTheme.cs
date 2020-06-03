using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5_peti
{
    class LightTheme : Itheme
    {
        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.White;
        }
        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        public string GetHeader(int width)
        {
            return new string('+', width);
        }
        public string GetFooter(int width)
        {
            return new string('_', width);
        }
    }
}