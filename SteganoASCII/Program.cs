using System;
using System.Windows.Forms;

/// <summary>
/// Site utilisé pour générer les template ascii:
/// http://patorjk.com/software/taag/#p=display&h=0&v=1&f=Old%20Banner&t=A%0AB%0AC%0AD%0AE%0AF%0AG%0AH%0AI%0AJ%0AK%0AL%0AM%0AN%0AO%0AP%0AQ%0AR%0AS%0AT%0AU%0AV%0AW%0AX%0AY%0AZ%0A0%0A1%0A2%0A3%0A4%0A5%0A6%0A7%0A8%0A9%0A%20%0A%2F%0A*%0A-%0A%2B%0A%3F%0A%2C%0A.%0A%3B%0A%2F%0A%3A%0A%C2%A7%0A!%0A%C3%B9%0A%25%0A%24%0A%C2%A3%0A%3D%0A%26%0A%C3%A9%0A%22%0A'%0A(%0A-%0A%C3%A8%0A_%0A%C3%A7%0A%C3%A0%0A)%0A%C2%B5
/// ou tout simplement http://patorjk.com/software/taag
/// Old Banner, Fitted
/// </summary>
namespace SteganoASCII
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
