using System;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;

namespace TextToSpeech
{
    public static class EntryPoint
    {
        /// <summary> 
        /// The main entry point for the application. 
        /// </summary> 
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            
        }
    }
}
