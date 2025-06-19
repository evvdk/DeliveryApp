using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DeliveryApp
{
    public class CustomButton : Button
    {
        public CustomButton() : base() {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.borderRadius = 5;
            this.Font = new Font("Microsoft YaHei UI", 12F);
        }
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private int borderRadius = 15;

        [Category("Props")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);


            Rectangle rectSurface = this.ClientRectangle;
            int smoothSize = 2;

            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
      
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                }
            }
            else
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                this.Region = new Region(rectSurface);
            }
        }

    }
}
