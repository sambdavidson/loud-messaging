using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace LoudMessaging
{
    public partial class LaunchForm : Form
    {
        private const int WM_NCHITTEST = 0x0084;
        private IntPtr HTTRANSPARENT = new IntPtr(-1);
        private bool running = false;
        public LaunchForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == (int)WM_NCHITTEST)
                m.Result = (IntPtr)(-1);
            else
                base.WndProc(ref m);
        }
    }
}
