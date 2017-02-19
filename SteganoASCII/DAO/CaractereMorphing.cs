using System;
using System.Text;

namespace SteganoASCII.DAO
{
    class CaractereMorphing
    {
        private static Random r = new Random(DateTime.Now.Millisecond);

        private char _caractere;

        private StringBuilder _template;

        public char Caractere
        {
            get
            {
                return _caractere;
            }

            set
            {
                _caractere = value;
            }
        }

        public StringBuilder Template
        {
            get
            {
                return _template;
            }

            set
            {
                _template = value;
            }
        }

        public StringBuilder HidenTemplate(string stableCar = "9", string listeChar = "0123456789")
        {
            StringBuilder result = new StringBuilder(_template.ToString());
            result = result.Replace("#", stableCar);
            string newlisteChar = listeChar.Remove(listeChar.IndexOf(stableCar), 1);

            int idx = 0;
            foreach (var c in result.ToString())
            {
                if (c == '.')
                {
                    int randoIdx = r.Next(0, newlisteChar.Length);
                    result = result.Replace('.', newlisteChar[randoIdx], idx, 1);
                }
                idx++;
            }

            return result;
        }
    }
}
