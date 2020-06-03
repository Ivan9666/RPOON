using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6
{
    class Program
    {
        static void Main(string[] args)
        {
            Note note1 = new Note("Cars", "BMW, OPEL, VW, Porsche");
            Note note2 = new Note("Bikes", "Yammaha, Honda, KTM, Aprilia");
            Note note3 = new Note("Tyres", "Tigar, Fulda, Sava,Dunlop");
            Notebook notebook = new Notebook();

            notebook.AddNote(note1);
            notebook.AddNote(note2);
            notebook.AddNote(note3);
            notebook.RemoveNote(note2);

            IAbstractIterator notebookIterator = notebook.GetIterator();

            while (!notebookIterator.IsDone)
            {
                notebookIterator.Current.Show();
                notebookIterator.Next();
            }
        }
        static void OutputSeparationLine()
        {
            System.Console.WriteLine("--------------------");
        }
    }
}