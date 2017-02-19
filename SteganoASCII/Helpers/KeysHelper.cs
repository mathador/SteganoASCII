using System.Collections.Generic;
using System.IO;

namespace SteganoASCII.Helpers
{
    static class KeysHelper
    {
        private static List<char> caracteres = new List<char>();

        public static List<char> Caracteres
        {
            get
            {
                return caracteres;
            }

            set
            {
                caracteres = value;
            }
        }

        public static void LoadFromFile(string fullFilePath)
        {
            using(TextReader strR = new StreamReader(fullFilePath))
            {
                string getFileContetnt = strR.ReadToEnd();
                Caracteres.AddRange(getFileContetnt.ToCharArray());
                Caracteres.RemoveAll(c => c == '\r' || c == '\n');
            }
        }
    }
}
