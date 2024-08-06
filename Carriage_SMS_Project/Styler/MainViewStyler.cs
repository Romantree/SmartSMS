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

namespace Carriage_SMS_Project.Styler
{
    public  static class MainViewStyler
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        //MainForm Border Radius 설정
        public static void Style(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width, form.Height, 110, 110));
            form.Paint += (sender, e) => DrawGradientBackground(form, e.Graphics);
            
            Panel HeaderPanel = new Panel();
        }


        private static void DrawGradientBackground(Form form, Graphics graphics)
        {

            //Color color1 = Color.FromArgb(250, 250, 250);
            //Color color2 = Color.FromArgb(245, 245, 245);
            //Color color3 = Color.FromArgb(255, 240, 240); 


            //LinearGradientBrush gradientBrush = new LinearGradientBrush(form.ClientRectangle, color1, color3, LinearGradientMode.Vertical);
            //ColorBlend blend = new ColorBlend();
            //blend.Positions = new[] { 0, 0.5f, 1 };
            //blend.Colors = new[] { color1, color2, color3 };
            //gradientBrush.InterpolationColors = blend;

            //graphics.FillRectangle(gradientBrush, form.ClientRectangle);
        }

 
    }
}
