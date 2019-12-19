using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ClientProjetCodeIRV
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        /// 
        private static Form1 applicationWindow;
        private static Thread asynClient;

        [STAThread]


        static void launchApp()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(applicationWindow); 
        }

        public static void endProgram()
        {
            asynClient.Abort();
            System.Environment.Exit(1);
        }

        static void Main()
        {
            applicationWindow = new Form1();

            asynClient = new Thread(new ThreadStart(launchApp));
            asynClient.Start();

            AsynchronousClient.start(applicationWindow);
        }
    }
}
