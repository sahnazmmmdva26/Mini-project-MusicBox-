using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBox
{
    public static class Extention
    {
        public static string Capitalize(this string text)
        {
            StringBuilder str = new StringBuilder();
            text=text.Trim();
            if(string.IsNullOrEmpty(text))
            {
                return " ";
            }
            if(text.Contains(" "))
            {
                string[] strArr=text.Split(' ');
                for (int i = 1; i < strArr.Length; i++)
                {
                    str.Append(char.ToUpper(strArr[i][0]) + strArr[i].Substring(1).ToLower());
                }
            }
            else
            {
                str.Append(char.ToUpper(text[0]) + text.Substring(1).ToLower());
                
            }
            return str.ToString();
        }
    }
}
