using System;
using System.Diagnostics;
using SOLID.SingleResponsability;
namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            var myJournal = new Journal();
            myJournal.AddEntry("I ate a bug");
            Console.WriteLine(myJournal);

            var persistence = new Persistence();
            var filename =  @"c:\temp\journal.txt";
            persistence.SaveToFile(myJournal, filename);
            Process.Start(filename);
        }
    }
}
