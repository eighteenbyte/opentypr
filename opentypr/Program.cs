using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opentypr
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main(string[] files)
        {
            //eğer bir dosyayla beraber açılırsa dosyayı textbox'a aktar
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            foreach (string s in files)
                Application.Run(new mainwindow(s));
            if(files.Length == 0)
                Application.Run(new mainwindow("Adsız"));
        }
    }
}
