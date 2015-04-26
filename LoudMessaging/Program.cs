using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace LoudMessaging
{
    class program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Messenger());
        }
    }

}
