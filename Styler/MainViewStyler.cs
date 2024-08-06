using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carriage_SMS_Project.Views;
using System.Diagnostics;

namespace Carriage_SMS_Project.Styler
{
       
    public  static class MainViewStyler
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        //MainForm Border Radius 설정
        [DebuggerStepThrough]
        public static void Style(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width, form.Height, 10, 10));
            
            Panel HeaderPanel = new Panel();
        }



 
    }
}
