using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternTask
{
    internal static class HashCreator
    {
        public static string GetHash()
        {
            return DateTime.Now.Ticks.ToString("x");
        }

        public static bool ValidateHash(string hash)
        {
            var tryParse = long.TryParse(hash, System.Globalization.NumberStyles.AllowHexSpecifier, null, out var _ticks);
            return tryParse && new DateTime(_ticks) <= DateTime.Now;
        }
    }
}
