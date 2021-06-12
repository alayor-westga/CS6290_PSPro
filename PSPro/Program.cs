using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSPro
{
    public static class Program
    {
        public enum Environments
        {
            PROD,
            E2E_TESTS
        }
        private static Environments psProEnvironment = Environments.PROD;
        public static Environments Env
        {
            get { return psProEnvironment; }
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "e2e_tests")
            {
                psProEnvironment = Environments.E2E_TESTS;
            }
            try
            {
                if (Environment.OSVersion.Version.Major >= 6)
                    SetProcessDPIAware();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                // ignore
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View.LoginForm());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
