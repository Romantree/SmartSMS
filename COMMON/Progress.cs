﻿//using CommonClassLibs;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Drawing.Drawing2D;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Carriage_SMS_Project.COMMON
//{
//    [DefaultEvent("ValueChanged")]
//    public class ProgressBar : System.Windows.Forms.UserControl
//    {

//        #region -  Designer  -

//        /// <summary> 
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.Container components = null;

//        /// <summary>
//        /// Create the control and initialize it.
//        /// </summary>
//        public ProgressBar()
//        {
//            // This call is required by the Windows.Forms Form Designer.
//            InitializeComponent();
//            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
//            this.SetStyle(ControlStyles.DoubleBuffer, true);
//            this.SetStyle(ControlStyles.ResizeRedraw, true);
//            this.SetStyle(ControlStyles.Selectable, true);
//            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
//            this.SetStyle(ControlStyles.UserPaint, true);
//            this.BackColor = Color.Transparent;
//            if (!InDesignMode())
//            {
//                mGlowAnimation.Tick += new EventHandler(mGlowAnimation_Tick);
//                mGlowAnimation.Interval = 15;
//                if (Value < MaxValue) { mGlowAnimation.Start(); }
//            }
//        }

//        /// <summary> 
//        /// Clean up any resources being used.
//        /// </summary>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                if (components != null)
//                {
//                    components.Dispose();
//                }
//            }
//            base.Dispose(disposing);
//        }

//        #region -  Component Designer  -

//        /// <summary> 
//        /// Required method for Designer support - do not modify 
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.SuspendLayout();
//            // 
//            // ProgressBar
//            // 
//            this.Name = "ProgressBar";
//            this.Size = new System.Drawing.Size(264, 43);
//            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ProgressBar_Paint);
//            this.ResumeLayout(false);

//        }

//        #endregion

//        #endregion

//        #region -  Properties  -

//        private int mGlowPosition = -325;
//        private Timer mGlowAnimation = new Timer();

//        #region -  Value  -

//        private int mValue = 0;
//        /// <summary>
//        /// The value that is displayed on the progress bar.
//        /// </summary>
//        [Category("Value"),
//        DefaultValue(0),
//        Description("The value that is displayed on the progress bar.")]
//        public int Value
//        {
//            get { return mValue; }
//            set
//            {
//                if (value > MaxValue || value < MinValue) { return; }
//                mValue = value;
//                if (value < MaxValue) { mGlowAnimation.Start(); }
//                if (value == MaxValue) { mGlowAnimation.Stop(); }
//                ValueChangedHandler vc = ValueChanged;
//                if (vc != null) { vc(this, new System.EventArgs()); }
//                this.Invalidate();
//            }
//        }

//        private int mMaxValue = 100;
//        /// <summary>
//        /// The maximum value for the Value property.
//        /// </summary>
//        [Category("Value"),
//        DefaultValue(100),
//        Description("The maximum value for the Value property.")]
//        public int MaxValue
//        {
//            get { return mMaxValue; }
//            set
//            {
//                mMaxValue = value;
//                if (value > MaxValue) { Value = MaxValue; }
//                if (Value < MaxValue) { mGlowAnimation.Start(); }
//                MaxChangedHandler mc = MaxChanged;
//                if (mc != null) { mc(this, new System.EventArgs()); }
//                this.Invalidate();
//            }
//        }

//        private int mMinValue = 0;
//        /// <summary>
//        /// The minimum value for the Value property.
//        /// </summary>
//        [Category("Value"),
//        DefaultValue(0),
//        Description("The minimum value for the Value property.")]
//        public int MinValue
//        {
//            get { return mMinValue; }
//            set
//            {
//                mMinValue = value;
//                if (value < MinValue) { Value = MinValue; }
//                MinChangedHandler mc = MinChanged;
//                if (mc != null) { mc(this, new System.EventArgs()); }
//                this.Invalidate();
//            }
//        }

//        #endregion

//        #region -  Bar  -

//        private Color mStartColor = Color.FromArgb(210, 0, 0);
//        /// <summary>
//        /// The start color for the progress bar.
//        /// 210, 000, 000 = Red
//        /// 210, 202, 000 = Yellow
//        /// 000, 163, 211 = Blue
//        /// 000, 211, 040 = Green
//        /// </summary>
//        [Category("Bar"),
//        DefaultValue(typeof(Color), "210, 0, 0"),
//        Description("The start color for the progress bar." +
//                    "210, 000, 000 = Red\n" +
//                    "210, 202, 000 = Yellow\n" +
//                    "000, 163, 211 = Blue\n" +
//                    "000, 211, 040 = Green\n")]
//        public Color StartColor
//        {
//            get { return mStartColor; }
//            set { mStartColor = value; this.Invalidate(); }
//        }

//        private Color mEndColor = Color.FromArgb(0, 211, 40);
//        /// <summary>
//        /// The end color for the progress bar.
//        /// 210, 000, 000 = Red
//        /// 210, 202, 000 = Yellow
//        /// 000, 163, 211 = Blue
//        /// 000, 211, 040 = Green
//        /// </summary>
//        [Category("Bar"),
//        DefaultValue(typeof(Color), "0, 211, 40"),
//        Description("The end color for the progress bar." +
//            "210, 000, 000 = Red\n" +
//            "210, 202, 000 = Yellow\n" +
//            "000, 163, 211 = Blue\n" +
//            "000, 211, 040 = Green\n")]
//        public Color EndColor
//        {
//            get { return mEndColor; }
//            set { mEndColor = value; this.Invalidate(); }
//        }

//        #endregion

//        #region -  Highlights and Glows  -

//        private Color mHighlightColor = Color.White;
//        /// <summary>
//        /// The color of the highlights.
//        /// </summary>
//        [Category("Highlights and Glows"),
//        DefaultValue(typeof(Color), "White"),
//        Description("The color of the highlights.")]
//        public Color HighlightColor
//        {
//            get { return mHighlightColor; }
//            set { mHighlightColor = value; this.Invalidate(); }
//        }

//        private Color mBackgroundColor = Color.FromArgb(201, 201, 201);
//        /// <summary>
//        /// The color of the background.
//        /// </summary>
//        [Category("Highlights and Glows"),
//        DefaultValue(typeof(Color), "201,201,201"),
//        Description("The color of the background.")]
//        public Color BackgroundColor
//        {
//            get { return mBackgroundColor; }
//            set { mBackgroundColor = value; this.Invalidate(); }
//        }

//        private bool mAnimate = true;
//        /// <summary>
//        /// Whether the glow is animated.
//        /// </summary>
//        [Category("Highlights and Glows"),
//        DefaultValue(typeof(bool), "true"),
//        Description("Whether the glow is animated or not.")]
//        public bool Animate
//        {
//            get { return mAnimate; }
//            set
//            {
//                mAnimate = value;
//                if (value) { mGlowAnimation.Start(); } else { mGlowAnimation.Stop(); }
//                this.Invalidate();
//            }
//        }

//        private Color mGlowColor = Color.FromArgb(150, 255, 255, 255);
//        /// <summary>
//        /// The color of the glow.
//        /// </summary>
//        [Category("Highlights and Glows"),
//        DefaultValue(typeof(Color), "150, 255, 255, 255"),
//        Description("The color of the glow.")]
//        public Color GlowColor
//        {
//            get { return mGlowColor; }
//            set { mGlowColor = value; this.Invalidate(); }
//        }

//        #endregion

//        #endregion

//        #region -  Drawing  -

//        private void DrawBackground(Graphics g)
//        {
//            Rectangle r = this.ClientRectangle; r.Width--; r.Height--;
//            GraphicsPath rr = RoundRect(r, 2, 2, 2, 2);
//            g.FillPath(new SolidBrush(this.BackgroundColor), rr);
//        }

//        private void DrawBackgroundShadows(Graphics g)
//        {
//            Rectangle lr = new Rectangle(2, 2, 10, this.Height - 5);
//            LinearGradientBrush lg = new LinearGradientBrush(lr, Color.FromArgb(30, 0, 0, 0),
//                                                             Color.Transparent,
//                                                             LinearGradientMode.Horizontal);
//            lr.X--;
//            g.FillRectangle(lg, lr);

//            Rectangle rr = new Rectangle(this.Width - 12, 2, 10, this.Height - 5);
//            LinearGradientBrush rg = new LinearGradientBrush(rr, Color.Transparent,
//                                                             Color.FromArgb(20, 0, 0, 0),
//                                                             LinearGradientMode.Horizontal);
//            g.FillRectangle(rg, rr);
//        }

//        private void DrawBar(Graphics g)
//        {
//            Rectangle r = new Rectangle(1, 2, this.Width - 3, this.Height - 3);
//            r.Width = (int)(Value * 1.0F / (MaxValue - MinValue) * this.Width);
//            g.FillRectangle(new SolidBrush(GetIntermediateColor()), r);
//        }

//        private void DrawBarShadows(Graphics g)
//        {
//            Rectangle lr = new Rectangle(1, 2, 15, this.Height - 3);
//            LinearGradientBrush lg = new LinearGradientBrush(lr, Color.White, Color.White,
//                                                             LinearGradientMode.Horizontal);

//            ColorBlend lc = new ColorBlend(3);
//            lc.Colors = new Color[] { Color.Transparent, Color.FromArgb(40, 0, 0, 0), Color.Transparent };
//            lc.Positions = new float[] { 0.0F, 0.2F, 1.0F };
//            lg.InterpolationColors = lc;

//            lr.X--;
//            g.FillRectangle(lg, lr);

//            Rectangle rr = new Rectangle(this.Width - 3, 2, 15, this.Height - 3);
//            rr.X = (int)(Value * 1.0F / (MaxValue - MinValue) * this.Width) - 14;
//            LinearGradientBrush rg = new LinearGradientBrush(rr, Color.Black, Color.Black,
//                                                             LinearGradientMode.Horizontal);

//            ColorBlend rc = new ColorBlend(3);
//            rc.Colors = new Color[] { Color.Transparent, Color.FromArgb(40, 0, 0, 0), Color.Transparent };
//            rc.Positions = new float[] { 0.0F, 0.8F, 1.0F };w
//            rg.InterpolationColors = rc;

//            g.FillRectangle(rg, rr);
//        }

//        private void DrawHighlight(Graphics g)
//        {
//            Rectangle tr = new Rectangle(1, 1, this.Width - 1, 6);
//            GraphicsPath tp = RoundRect(tr, 2, 2, 0, 0);

//            g.SetClip(tp);
//            LinearGradientBrush tg = new LinearGradientBrush(tr, Color.White,
//                                                             Color.FromArgb(128, Color.White),
//                                                             LinearGradientMode.Vertical);
//            g.FillPath(tg, tp);
//            g.ResetClip();

//            Rectangle br = new Rectangle(1, this.Height - 8, this.Width - 1, 6);
//            GraphicsPath bp = RoundRect(br, 0, 0, 2, 2);

//            g.SetClip(bp);
//            LinearGradientBrush bg = new LinearGradientBrush(br, Color.Transparent,
//                                                             Color.FromArgb(100, this.HighlightColor),
//                                                             LinearGradientMode.Vertical);
//            g.FillPath(bg, bp);
//            g.ResetClip();
//        }

//        private void DrawInnerStroke(Graphics g)
//        {
//            Rectangle r = this.ClientRectangle;
//            r.X++; r.Y++; r.Width -= 3; r.Height -= 3;
//            GraphicsPath rr = RoundRect(r, 2, 2, 2, 2);
//            g.DrawPath(new Pen(Color.FromArgb(100, Color.White)), rr);
//        }

//        private void DrawGlow(Graphics g)
//        {
//            Rectangle r = new Rectangle(mGlowPosition, 0, 60, this.Height);
//            LinearGradientBrush lgb = new LinearGradientBrush(r, Color.White, Color.White,
//                                                              LinearGradientMode.Horizontal);

//            ColorBlend cb = new ColorBlend(4);
//            cb.Colors = new Color[] { Color.Transparent, this.GlowColor, this.GlowColor, Color.Transparent };
//            cb.Positions = new float[] { 0.0F, 0.5F, 0.6F, 1.0F };
//            lgb.InterpolationColors = cb;

//            Rectangle clip = new Rectangle(1, 2, this.Width - 3, this.Height - 3);
//            clip.Width = (int)(Value * 1.0F / (MaxValue - MinValue) * this.Width);
//            g.SetClip(clip);
//            g.FillRectangle(lgb, r);
//            g.ResetClip();
//        }

//        private void DrawOuterStroke(Graphics g)
//        {
//            Rectangle r = this.ClientRectangle; r.Width--; r.Height--;
//            GraphicsPath rr = RoundRect(r, 2, 2, 2, 2);
//            g.DrawPath(new Pen(Color.FromArgb(178, 178, 178)), rr);
//        }

//        #endregion

//        #region -  Functions  -

//        private GraphicsPath RoundRect(RectangleF r, float r1, float r2, float r3, float r4)
//        {
//            float x = r.X, y = r.Y, w = r.Width, h = r.Height;
//            GraphicsPath rr = new GraphicsPath();
//            rr.AddBezier(x, y + r1, x, y, x + r1, y, x + r1, y);
//            rr.AddLine(x + r1, y, x + w - r2, y);
//            rr.AddBezier(x + w - r2, y, x + w, y, x + w, y + r2, x + w, y + r2);
//            rr.AddLine(x + w, y + r2, x + w, y + h - r3);
//            rr.AddBezier(x + w, y + h - r3, x + w, y + h, x + w - r3, y + h, x + w - r3, y + h);
//            rr.AddLine(x + w - r3, y + h, x + r4, y + h);
//            rr.AddBezier(x + r4, y + h, x, y + h, x, y + h - r4, x, y + h - r4);
//            rr.AddLine(x, y + h - r4, x, y + r1);
//            return rr;
//        }

//        private bool InDesignMode()
//        {
//            return (LicenseManager.UsageMode == LicenseUsageMode.Designtime);
//        }

//        private Color GetIntermediateColor()
//        {
//            Color c = this.StartColor;
//            Color c2 = this.EndColor;

//            float pc = this.Value * 1.0F / (this.MaxValue - this.MinValue);

//            int ca = c.A, cr = c.R, cg = c.G, cb = c.B;
//            int c2a = c2.A, c2r = c2.R, c2g = c2.G, c2b = c2.B;

//            int a = (int)Math.Abs(ca + (ca - c2a) * pc);
//            int r = (int)Math.Abs(cr - ((cr - c2r) * pc));
//            int g = (int)Math.Abs(cg - ((cg - c2g) * pc));
//            int b = (int)Math.Abs(cb - ((cb - c2b) * pc));

//            if (a > 255) { a = 255; }
//            if (r > 255) { r = 255; }
//            if (g > 255) { g = 255; }
//            if (b > 255) { b = 255; }

//            return (Color.FromArgb(a, r, g, b));
//        }

//        #endregion

//        #region -  Other  -

//        private void ProgressBar_Paint(object sender, PaintEventArgs e)
//        {
//            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
//            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
//            DrawBackground(e.Graphics);
//            DrawBackgroundShadows(e.Graphics);
//            DrawBar(e.Graphics);
//            DrawBarShadows(e.Graphics);
//            DrawHighlight(e.Graphics);
//            DrawInnerStroke(e.Graphics);
//            DrawGlow(e.Graphics);
//            DrawOuterStroke(e.Graphics);
//        }

//        private void mGlowAnimation_Tick(object sender, EventArgs e)
//        {
//            if (this.Animate)
//            {
//                mGlowPosition += 4;
//                if (mGlowPosition > this.Width)
//                {
//                    mGlowPosition = -300;
//                }
//                this.Invalidate();
//            }
//            else
//            {
//                mGlowAnimation.Stop();
//                mGlowPosition = -320;
//            }
//        }

//        #endregion

//        #region -  Events  -

//        /// <summary>
//        /// When the Value property is changed.
//        /// </summary>
//        public delegate void ValueChangedHandler(object sender, EventArgs e);
//        /// <summary>
//        /// When the Value property is changed.
//        /// </summary>
//        public event ValueChangedHandler ValueChanged;

//        /// <summary>
//        /// When the MinValue property is changed.
//        /// </summary>
//        public delegate void MinChangedHandler(object sender, EventArgs e);
//        /// <summary>
//        /// When the MinValue property is changed.
//        /// </summary>
//        public event MinChangedHandler MinChanged;

//        /// <summary>
//        /// When the MaxValue property is changed.
//        /// </summary>
//        public delegate void MaxChangedHandler(object sender, EventArgs e);
//        /// <summary>
//        /// When the MaxValue property is changed.
//        /// </summary>
//        public event MaxChangedHandler MaxChanged;

//        #endregion

//    }
//}
//    class Progress
//    {
//        public Progress(string fileName, long fileSize, int direction)
//        {
//            _myForm = new Form();
//            _myForm.Name = "ProgressBarForm";
//            _myForm.Size = new System.Drawing.Size(350, 115);
//            _myForm.Location = new System.Drawing.Point(100, 100);
//            _myForm.Text = "File Transfer Progress...";
//            _myForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
//            _myForm.ShowIcon = false;
//            _myForm.ShowInTaskbar = false;
//            _myForm.BackColor = Color.PeachPuff;

//            /* Controls *********************************************/
//            _labelName = new Label();
//            _labelName.AutoSize = true;
//            _labelName.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            _labelName.Location = new System.Drawing.Point(5, 3);
//            _labelName.Size = new System.Drawing.Size(0, 16);
//            _labelName.BackColor = Color.Transparent;

//            _labelSize = new Label();
//            _labelSize.AutoSize = true;
//            _labelSize.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            _labelSize.Location = new System.Drawing.Point(5, 40);
//            _labelSize.Size = new System.Drawing.Size(0, 16);
//            _labelSize.BackColor = Color.Transparent;

//            _progressBar1 = new ProgressBar();
//            _progressBar1.Location = new System.Drawing.Point(1, 65);
//            _progressBar1.Size = new System.Drawing.Size(340, 23);
//            _progressBar1.Name = "FileProgressBar";
//            /*********************************************************/

//            /**** Set the data *************************************/
//            if (direction == (int)FILEACTION.OutgoingFile)
//                _labelName.Text = "Sending File: \n" + fileName;
//            else
//                _labelName.Text = "Receiving File: \n" + fileName;

//            if (fileSize < 1024)
//            {
//                _labelSize.Text = fileSize.ToString() + " bytes";
//            }
//            else if (fileSize >= 1024 && fileSize < 1000000)
//            {
//                _labelSize.Text = ConvertToKilobytes(fileSize, 2);
//            }
//            else if (fileSize >= 1000000)
//            {
//                _labelSize.Text = ConvertToMegabytes(fileSize, 3);
//            }

//            _progressBar1.MinValue = 0;
//            _progressBar1.MaxValue = (int)fileSize;
//            /*******************************************************/

//            _myForm.Controls.Add(_labelName);
//            _myForm.Controls.Add(_labelSize);
//            _myForm.Controls.Add(_progressBar1);

//            _progressBar1.Value = 0;
//            _myForm.Show();
//        }


//        public void SetProgressbarValue(int val)
//        {
//            if (_myForm.InvokeRequired)
//            {
//                Console.WriteLine("  ------  FYI: INVOKE IS REQUIRED IN SetProgressbarValue()  ------ ");
//            }

//            _progressBar1.Value = val;
//        }

//        public void Close()
//        {
//            _myForm.Close();
//            _myForm.Dispose();
//        }


//        private string ConvertToKilobytes(long bytes, uint places)
//        {
//            string format = "N" + places.ToString();
//            return ((decimal)bytes / 1024M).ToString(format) + " KB";
//        }

//        private string ConvertToMegabytes(long bytes, uint places)
//        {
//            string format = "N" + places.ToString();
//            return ((decimal)bytes / 1024M / 1024M).ToString(format) + " MB";
//        }

//        private Form _myForm;
//        private Label _labelName;
//        private Label _labelSize;
//        private ProgressBar _progressBar1;

//    }


