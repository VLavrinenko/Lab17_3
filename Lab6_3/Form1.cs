using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Timers;

// spaghetti code 
// dodelat 3,4 punkti
namespace Lab6_3
{

    public partial class Form1 : Form
    {
        private static Pen BlackPen = new Pen(Color.Black, 2);
        private SolidBrush GreyBrush = new SolidBrush(Color.Gray);
        private SolidBrush GreyBrush1 = new SolidBrush(Color.Gray);
        private Pen RainbowPen = new Pen(Color.Black, 3);
        private static Pen DottedPen = new Pen(Color.Black, 3);
        private bool DiscoFlag = false;
        private static int DLarge = 240, D = 120;
        private static int RLarge = 120, R = 60;
        private int FirstSegment, SecondSegment, ThirdSegment;
        private Point[] NewLines;
        private Point[] NewLines1;
        private bool small = true, large = true;
        System.Windows.Forms.Timer aTimer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
        }
        private void Color1_Button_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                GreyBrush.Color = dialog.Color;
                panel1.Invalidate();
            }

        }
        private void Color2_Button_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                GreyBrush1.Color = dialog.Color;
                panel1.Invalidate();
            }

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(10, 10);
            BlackPen.CustomEndCap = bigArrow;
            DottedPen.DashStyle = DashStyle.Dash;
            Graphics Axis = e.Graphics;
            Graphics Figures = e.Graphics;
            NewLines = First(e);
            NewLines1 = Second(e);

            Figures.FillPolygon(GreyBrush, NewLines);
            Figures.FillPolygon(GreyBrush1, NewLines1);

            Axis.DrawLine(BlackPen, 30, panel1.Height / 2, panel1.Width - 30, panel1.Height / 2);//X axis
            Axis.DrawLine(BlackPen, panel1.Width / 2, panel1.Height - 30, panel1.Width / 2, 30);//Y axis

            Figures.DrawEllipse(RainbowPen, (panel1.Width - DLarge) / 2, (panel1.Height - DLarge) / 2, DLarge, DLarge);// large ellipse
            Figures.DrawEllipse(RainbowPen, (panel1.Width - D) / 2, (panel1.Height - D) / 2, D, D);// small ellipse center
            Figures.DrawEllipse(RainbowPen, (panel1.Width - D) / 2 + 60, (panel1.Height - D) / 2, D, D);// small ellipse right
            Figures.DrawEllipse(BlackPen, 498, 378, 4, 4);//dot right
            Figures.DrawLine(RainbowPen, 380 - 120, 380 + 60, 380 + 180, 380 - 90); // y = 2x 
            Figures.DrawLine(DottedPen, 380, 380 - 60, 380 + 120, 380 - 60); //horisontal dash
            Figures.DrawLine(DottedPen, 380 + 120, 380 - 60, 380 + 120, 380);//vertical dash
        }
        private void Play_Click(object sender, EventArgs e)
        {
            DiscoFlag = true;
            Timer();
        }
        private void Timer()
        {
            aTimer.Interval = 1000;
            aTimer.Enabled = true;
            aTimer.Tick += new EventHandler(Redraw);
        }
        private void Label_MouseUp(object sender, MouseEventArgs e)
        {
            Label label = (sender as Label);
            Point temp = new Point(label.Location.X + e.X - Convert.ToInt32(label.Font.Size), label.Location.Y + e.Y - Convert.ToInt32(label.Font.Size)); ;
            label.Location = temp;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            int min = 0, max = 255;
            X_box.Text = Convert.ToString(e.X);
            Y_box.Text = Convert.ToString(e.Y);
            GraphicsPath SmallPath = new GraphicsPath();
            GraphicsPath LargePath = new GraphicsPath();
            SmallPath.AddPolygon(NewLines);
            LargePath.AddPolygon(NewLines1);
            Region SmallRegion = new Region(SmallPath);
            Region LargeRegion = new Region(LargePath);
            Point temp = new Point(e.X, e.Y);
            if (SmallRegion.IsVisible(temp) && small)
            {
                small = false;
                GreyBrush.Color = Color.FromArgb(random.Next(min, max), random.Next(min, max), random.Next(min, max));
                panel1.Invalidate();
            }
            if (LargeRegion.IsVisible(temp) && large)
            {
                large = false;
                GreyBrush1.Color = Color.FromArgb(random.Next(min, max), random.Next(min, max), random.Next(min, max));
                panel1.Invalidate();
            }
            if (!SmallRegion.IsVisible(temp))
            {
                small = true;
            }
            if (!LargeRegion.IsVisible(temp))
            {
                large = true;
            }
        }

        private void Redraw(Object myObject, EventArgs myEventArgs)
        {
            if (DiscoFlag)
            {
                Random random = new Random();
                int min = 0, max = 255;
                int f = random.Next(6, 25);
                Label_Two_Down.Font = new Font("Segoe UI", f);
                Label_Two_Left.Font = new Font("Segoe UI", f);
                Label_Two_Right.Font = new Font("Segoe UI", f);
                Label_Two_Up.Font = new Font("Segoe UI", f);
                One_Label.Font = new Font("Segoe UI", f);
                Zero_Label.Font = new Font("Segoe UI", f);
                X_Label.Font = new Font("Segoe UI", f);
                Y_Label.Font = new Font("Segoe UI", f);

                GreyBrush.Color = Color.FromArgb(random.Next(min, max), random.Next(min, max), random.Next(min, max));
                GreyBrush1.Color = Color.FromArgb(random.Next(min, max), random.Next(min, max), random.Next(min, max));
                panel1.Invalidate();
            }
            else
                aTimer.Stop();
        }
        private void Pause_Click(object sender, EventArgs e)
        {
            DiscoFlag = false;
        }
        private Point[] First(PaintEventArgs e)
        {
            FirstSegment = R + R - 8 * R / 5;
            SecondSegment = R - Convert.ToInt32(Math.Ceiling(2 * R / Math.Sqrt(5))); //x

            Point[] curvePoints = new Point[FirstSegment + 1 + SecondSegment + 1];
            for (int i = 0; i + R - FirstSegment <= R; i++)
            {
                Point temp = new Point(380 + R * 2 - i, 380 - Convert.ToInt32(Math.Sqrt(R * R - (i - R) * (i - R))));
                curvePoints[i] = temp;
            }

            for (int i = 0; i + R - SecondSegment <= R; i++)
            {
                Point temp = new Point(380 + i + R - SecondSegment, 380 - Convert.ToInt32(Math.Sqrt(R * R - (i + R - SecondSegment) * (i + R - SecondSegment))));
                curvePoints[FirstSegment + 1 + i] = temp;
            }
            return curvePoints;
        }
        private Point[] Second(PaintEventArgs e)
        {
            FirstSegment = Convert.ToInt32(Math.Ceiling(2 * RLarge / Math.Sqrt(5)));
            ThirdSegment = R / 2; //x^2 = (x-R)^2
            SecondSegment = 8 * R / 5 - ThirdSegment;

            Point[] curvePoints1 = new Point[FirstSegment + 1 + SecondSegment + 1 + ThirdSegment + 1];

            for (int i = 0; i <= FirstSegment; i++)
            {
                Point temp = new Point(380 + i, 380 - Convert.ToInt32(Math.Sqrt(RLarge * RLarge - i * i)));
                curvePoints1[i] = temp;
            }

            for (int i = 0; i <= SecondSegment; i++)
            {
                Point temp = new Point(380 + ThirdSegment + i, 380 - Convert.ToInt32(Math.Sqrt(R * R - (ThirdSegment + i - R) * (ThirdSegment + i - R))));
                curvePoints1[FirstSegment + 1 + SecondSegment - i] = temp;
            }

            for (int i = 0; i <= ThirdSegment; i++)
            {
                Point temp = new Point(380 + i, 380 - Convert.ToInt32(Math.Sqrt(R * R - i * i)));
                curvePoints1[FirstSegment + 1 + SecondSegment + 1 + ThirdSegment - i] = temp;
            }
            return curvePoints1;
        }
    }
}
