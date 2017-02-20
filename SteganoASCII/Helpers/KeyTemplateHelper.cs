using System;
using System.Collections.Generic;
using System.Text;

namespace SteganoASCII.Helpers
{
    static class KeyTemplateHelper
    {
        private static int _templateNbOfLines = 1;

        private static List<string> _console = new List<string>(_templateNbOfLines);

        public static int TemplateNbOfLines
        {
            get
            {
                return _templateNbOfLines;
            }
            set
            {
                _templateNbOfLines = value;
                _console = new List<string>(_templateNbOfLines);
            }
        }

        public static string Console
        {
            get
            {
                return String.Join("\n", _console);
            }
        }

        public static void Append(string[] text, int linePosition = 1)
        {
            if (text == null || text.Length == 0)
                return;

            int nbLine = Math.Min(text.Length, _templateNbOfLines);

            for (int idx = (linePosition - 1) * nbLine; idx < nbLine * linePosition; idx++)
            {
                while (_console.Count <= idx)
                    _console.Add(string.Empty);

                string propreString = text[idx % nbLine].Replace("\r", string.Empty);
                _console[idx] += propreString;
            }
        }

        public static void Clear()
        {
            _console = new List<string>(_templateNbOfLines);
        }

        public static new string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (string s in _console)
            {
                result.AppendLine(s);
            }
            return result.ToString();
        }
    }
}
