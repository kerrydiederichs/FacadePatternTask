using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternTask
{
    internal class PathExistValidator
    {
        public static bool ValidatePath(FileInfo pathToFile)
        {
            return !File.Exists(pathToFile.FullName);
        }
    }
}
