using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carriage_SMS_Project.Styler
{
    public class CustomPictureBox : PictureBox
    {
        private int _borderWidth = 0;
        private Color _borderColor = Color.Black;

        public int BorderWidth
        {
            get { return _borderWidth; }
            set
            {
                _borderWidth = value;
                Invalidate(); // Redraw to apply new border width
            }
        }

        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                Invalidate(); // Redraw to apply new border color
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            if (_borderWidth > 0)
            {
                using (Pen pen = new Pen(_borderColor, _borderWidth))
                {
                    pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    pe.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
                }
            }
        }
    }
}
