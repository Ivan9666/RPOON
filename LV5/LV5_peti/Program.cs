using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5_peti
{
    class Program
    {
        static void Main(string[] args)
        {
            LightTheme lightTheme = new LightTheme();
            ReminderNote lightReminderNote = new ReminderNote("Moja svijetla poruka", lightTheme);
            lightReminderNote.Show();

            DarkTheme darkTheme = new DarkTheme();
            ReminderNote darkReminderNote = new ReminderNote("Moja tamna poruka", darkTheme);
            darkReminderNote.Show();

        }
        static void OutputSeparationLine()
        {
            System.Console.WriteLine("----------------------");
        }
    }
}