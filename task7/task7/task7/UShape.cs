using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace task7
{
    [Serializable]
    public class UShape : Figure
    {
        private int legThickness = 30;
        public int LegThickness { get { return legThickness; } set { legThickness = value; } }

        public UShape() : base() { }
        public UShape(int x, int y, int width, int height, int thickness = 30) : base(x, y, width, height)
        {
            legThickness = thickness;
        }

        protected override void DrawFigure(Graphics g)
        {
            Pen pen = new Pen(stroke.Color, stroke.Width) { DashStyle = stroke.DashStyle };
            int t = Math.Min(legThickness, Math.Min(width, height) / 3);
            if (t < 10) t = 10;

            ApplyTransform(g, () =>
            {
                // ✅ П-образная фигура - ТОЛЬКО внешний контур (без внутренних линий)
                // Рисуем как полигон (замкнутый контур)
                PointF[] points = new PointF[]
                {
                    new PointF(0, 0),           // Верх-лево
                    new PointF(0, height),      // Низ-лево
                    new PointF(t, height),      // Низ-лево (внутренний)
                    new PointF(t, t),           // Внутренний угол лево
                    new PointF(width - t, t),   // Внутренний угол право
                    new PointF(width - t, height), // Низ-право (внутренний)
                    new PointF(width, height),  // Низ-право (внешний)
                    new PointF(width, 0),       // Верх-право
                    new PointF(0, 0)            // Замыкаем
                };

                // Рисуем контур
                g.DrawPolygon(pen, points);

                // Заливка если включена
                if (stroke.IsFilled)
                {
                    using (Brush brush = new SolidBrush(stroke.FillColor))
                    {
                        g.FillPolygon(brush, points);
                    }
                }
            });
        }

        private void ApplyTransform(Graphics g, Action drawAction)
        {
            Matrix original = g.Transform;
            float centerX = x + width / 2f;
            float centerY = y + height / 2f;

            g.TranslateTransform(centerX, centerY);
            g.RotateTransform(rotationAngle);

            if (mirrorHorizontal || mirrorVertical)
            {
                g.ScaleTransform(mirrorHorizontal ? -1 : 1, mirrorVertical ? -1 : 1);
            }

            g.TranslateTransform(-width / 2f, -height / 2f, MatrixOrder.Append);

            drawAction();

            g.Transform = original;
        }

        public override string GetTypeName() => "П-образная фигура";
    }
}