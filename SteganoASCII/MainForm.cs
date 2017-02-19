using SteganoASCII.DAO;
using SteganoASCII.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace SteganoASCII
{
    public partial class MainForm : Form
    {
        private List<CaractereMorphing> alphabet = new List<CaractereMorphing>();

        public MainForm()
        {
            InitializeComponent();

            InitializeParametrage();
        }

        /// <summary>
        /// Récupère les information de configuration de l'application
        /// Comme le répertoire des patrons pour l'affichage des caractère en ASCII Art
        /// </summary>
        private void InitializeParametrage()
        {
            string currentPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string dataDirectory = ConfigurationManager.AppSettings["DataDirectory"];
            string completeDataDirectory = Path.Combine(currentPath, dataDirectory);
            if (Directory.Exists(completeDataDirectory))
            {
                string keysFile = ConfigurationManager.AppSettings["KeysFile"];
                string fullpathToKeysFile = Path.Combine(completeDataDirectory, keysFile);
                if (File.Exists(fullpathToKeysFile))
                {
                    KeysHelper.LoadFromFile(fullpathToKeysFile);

                    string templatesFile = ConfigurationManager.AppSettings["TemplatesFile"];
                    string fullpathToTemplatesFile = Path.Combine(completeDataDirectory, templatesFile);
                    if (File.Exists(fullpathToTemplatesFile))
                    {
                        TemplatesHelper.LoadFromFile(fullpathToTemplatesFile, KeysHelper.Caracteres.Count);
                    }

                    int minChar = Math.Min(KeysHelper.Caracteres.Count, TemplatesHelper.Templates.Count);
                    for (int idx = 0; idx < minChar; idx++)
                    {
                        CaractereMorphing current = new CaractereMorphing() { Caractere = KeysHelper.Caracteres[idx], Template = TemplatesHelper.Templates[idx] };
                        alphabet.Add(current);
                    }
                }
            }
            else
            {

            }

            //if (!String.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["Width"]))
            //{
            //    this.Width = int.Parse(ConfigurationManager.AppSettings["Width"]);
            //}
            //if (!String.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["Height"]))
            //{
            //    this.Height = int.Parse(ConfigurationManager.AppSettings["Height"]);
            //}

            //var section_jeu = ConfigurationManager.GetSection("jeu_caractere");
            string jeu = "jeu";
            int idx_jeu = 1;
            bool continue_while = false;
            List<string> valeur_jeu = new List<string>();
            do
            {
                string jeu_de_caract = ConfigurationManager.AppSettings[jeu + idx_jeu];
                if (!string.IsNullOrWhiteSpace(jeu_de_caract))
                {
                    valeur_jeu.Add(jeu_de_caract);
                }
                continue_while = !string.IsNullOrWhiteSpace(jeu_de_caract);
                idx_jeu++;
            } while (continue_while);
            cb_jeudecaracteres.Items.AddRange(valeur_jeu.ToArray());

        }

        private void RTB_Input_TextChanged(object sender, EventArgs e)
        {
            if (cb_caractereCodant.SelectedItem == null)
                return;

            TB_Ouput.Text = ReplaceAllChar(RTB_Input.Text);
        }

        private string ReplaceAllChar(string text)
        {
            int linePosition = 1;
            KeyTemplateHelper.Clear();
            for (int idx = 0; idx < text.Length; idx++)
            {
                if (text[idx] == '\n')
                {
                    linePosition++;
                }
                else
                {
                    CaractereMorphing current = alphabet.Where(a => a.Caractere == text.ToUpper()[idx]).FirstOrDefault();
                    if (current == null)
                    {

                    }
                    else
                        KeyTemplateHelper.Append(current.HidenTemplate(cb_caractereCodant.SelectedItem.ToString(), cb_jeudecaracteres.SelectedItem.ToString()).ToString().Split("\n".ToCharArray()), linePosition);
                    //result.Append(alphabet.Where(a=>a.Caractere == text.ToUpper()[idx]).FirstOrDefault().Template);
                }
            }

            return KeyTemplateHelper.ToString();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            //Configuration conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //if (conf.AppSettings.Settings["Width"] == null)
            //{
            //    conf.AppSettings.Settings.Add("Width", this.Width.ToString());
            //}
            //else
            //    conf.AppSettings.Settings["Width"].Value = this.Width.ToString();
            //if (conf.AppSettings.Settings["Height"] == null)
            //{
            //    conf.AppSettings.Settings.Add("Height", this.Height.ToString());
            //}
            //else
            //    conf.AppSettings.Settings["Height"].Value = this.Height.ToString();

            ////conf.AppSettings.("Width", this.Width.ToString());
            //conf.Save();
            //ConfigurationManager.AppSettings.Add("Width", this.Width.ToString());
            //ConfigurationManager.AppSettings.Set("Width", this.Width.ToString());
            //ConfigurationManager.AppSettings.Set("Height", this.Height.ToString());
        }

        private void cb_jeudecaracteres_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_caractereCodant.Items.Clear();
            if (cb_jeudecaracteres.SelectedItem != null)
            {
                foreach (char c in cb_jeudecaracteres.SelectedItem.ToString().ToCharArray())
                {
                    cb_caractereCodant.Items.Add(c.ToString());
                }
            }
        }
    }
}
