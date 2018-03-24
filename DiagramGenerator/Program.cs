/* Benny Skogberg
 * 2010-06-25
 * Program.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DiagramGenerator
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
            Application.Run(new MainForm());
        }
    }
}
