using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SteganoASCII.Helpers
{
    static class TemplatesHelper
    {
        private static List<StringBuilder> templates = new List<StringBuilder>();

        public static List<StringBuilder> Templates
        {
            get
            {
                return templates;
            }

            set
            {
                templates = value;
            }
        }

        public static void LoadFromFile(string fullFilePath, int nbDeCaracteres = 1)
        {
            Queue<string> que = new Queue<string>();
            using (TextReader strR = new StreamReader(fullFilePath))
            {
                while (strR.Peek() != -1)
                {
                    que.Enqueue(strR.ReadLine());
                }
            }

            KeyTemplateHelper.TemplateNbOfLines = que.Count / nbDeCaracteres;
            StringBuilder currentTemplate = null;
            while (que.Count != 0)
            {
                if (que.Count % KeyTemplateHelper.TemplateNbOfLines == 0)
                {
                    if (currentTemplate != null)
                    {
                        Templates.Add(currentTemplate);
                    }
                    currentTemplate = new StringBuilder();
                    currentTemplate.AppendLine(que.Dequeue());
                }
                else
                {
                    currentTemplate.AppendLine(que.Dequeue());
                }
            }
        }
    }
}
