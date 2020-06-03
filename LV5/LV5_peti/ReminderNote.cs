using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5_peti
{
    class ReminderNote : Note
    {
        public ReminderNote(string message, Itheme theme)
            : base(message, theme) { }

        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("reminder:");
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            Console.ResetColor();
        }
    }
}