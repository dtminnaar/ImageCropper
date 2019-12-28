using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageCropper
{
    public static class Extensions
    {
        public static string Chop(this string s, string end)
        {
            if (string.IsNullOrEmpty(end) || string.IsNullOrEmpty(s))
                return s;

            if (end.Length > s.Length)
                return "";

            return s.Substring(0, s.Length - end.Length);
        }
    }
}
