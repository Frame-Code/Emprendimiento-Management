using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinForms.Views.Util
{
    public class RoundedPanel : Panel
    {
        public int BorderRadius { get; set; } = 20;
        public Color BorderColor { get; set; } = Color.LightGray;
        public int BorderSize { get; set; } = 1;

        public RoundedPanel()
        {
            // Para que se pinte bien y sin parpadeos
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            this.BackColor = Color.FromArgb(250, 250, 250); // importante que contraste con el form
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Rectángulo interno (dejamos 1px para el borde)
            Rectangle rect = new Rectangle(1, 1, this.Width - 1, this.Height - 1);

            using (GraphicsPath path = GetRoundedPath(rect, BorderRadius))
            {
                // Recortar la región del panel
                this.Region = new Region(path);

                // Rellenar el fondo
                using (SolidBrush brush = new SolidBrush(this.BackColor))
                    e.Graphics.FillPath(brush, path);

                // Dibujar borde
                if (BorderSize > 0)
                {
                    using (Pen pen = new Pen(BorderColor, BorderSize))
                        e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curve = radius * 2f;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curve, curve, 180, 90);                       // arriba-izquierda
            path.AddArc(rect.Right - curve, rect.Y, curve, curve, 270, 90);           // arriba-derecha
            path.AddArc(rect.Right - curve, rect.Bottom - curve, curve, curve, 0, 90); // abajo-derecha
            path.AddArc(rect.X, rect.Bottom - curve, curve, curve, 90, 90);          // abajo-izquierda
            path.CloseFigure();

            return path;
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            this.Invalidate(); // vuelve a dibujar cuando cambias el tamaño
        }
    }
}