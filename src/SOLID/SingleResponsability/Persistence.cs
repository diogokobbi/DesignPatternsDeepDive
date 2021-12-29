using System;
using System.Collections.Generic;
using System.IO;
namespace SOLID.SingleResponsability
{
    public class Persistence
    {
        public void SaveToFile(Journal journal, string filename, bool overwrite = false)
        {
            if(overwrite || !File.Exists(filename))
            {
                File.WriteAllText(filename, ToString());
            }
        }
    }
}