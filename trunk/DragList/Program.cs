/*
 *  * User: RDressing@gmail.com
 * Date: 2/20/2011
 * Time: 5:22 PM
 * 
 * 
 */
using System;
using System.Windows.Forms;

namespace DragGrabber
{
    /// <summary>
    /// Class with program entry point.
    /// </summary>
    internal sealed class Program
    {
        /// <summary>
        /// Program entry point.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        
    }
}
