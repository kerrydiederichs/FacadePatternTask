using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternTask
{
    internal class Writer
    {
        public static void Write(FileInfo fileInfo)
        {
            using (var writer = new StreamWriter(fileInfo.FullName))
            {
                writer.WriteLine("Hello, World!");
            }
        }
    }
}
