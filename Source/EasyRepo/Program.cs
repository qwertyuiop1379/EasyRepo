using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyRepo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + @"\config.cfg"))
            {
                string[] config = File.ReadAllLines(Path.GetDirectoryName(Application.ExecutablePath) + @"\config.cfg");
                foreach (string s in config)
                {
                    if (s.Contains("REPOPATH="))
                    {
                        Application.Run(new form_manager(s.Remove(0, 9), false));
                    }
                    else
                    {
                        Application.Run(new form_init());
                    }
                }
            }
            else
            {
                Application.Run(new form_init());
            }
        }
    }
}
