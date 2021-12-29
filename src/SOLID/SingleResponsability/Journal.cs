using System;
using System.Collections.Generic;
using System.IO;
namespace SOLID.SingleResponsability
{
    public class Journal
    {
        private readonly IList<string> entires = new List<string>();
        private static int count = 0;
        public int AddEntry(string text)
        {
            entires.Add($"{++count}: {text}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            entires.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entires);
        }
        //Métodos abaixo estão violando o princípio da única responsabilidade:
        public void Save(string filename)
        {
            File.WriteAllText(filename, ToString());
        }
    }
}