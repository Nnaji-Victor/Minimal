using System;
using System.Collections.Generic;
using System.Text;

namespace Minimal.Utility
{
    public static class SD
    {
        public static string Truncate(this string value, int maxChars)
        {
            return value.Length <= maxChars ? value : value.Substring(0, maxChars) + "...";
        }
    }
}
