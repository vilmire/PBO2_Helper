using System.Security.Principal;

namespace PBO2_Helper
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            WindowsPrincipal myPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            if (myPrincipal.IsInRole(WindowsBuiltInRole.Administrator) == false)
            {
                //show messagebox - displaying a messange to the user that rights are missing
                MessageBox.Show("You need to run the application using the \"run as administrator\" option", "administrator right required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new Main());
            }
        }
    }
}