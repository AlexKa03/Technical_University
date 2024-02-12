using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Rect
    {
        public static Color SelectedColor { get; set; } = Color.Blue;
        public Color Color { get; set; } = Color.Black;
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsSelected { get; set; }
        public Point Location
        {
            get => new Point(X, Y);
            set
            {
                X = value.X;
                Y = value.Y;
            }
        }

        public void Draw(Graphics graphics, SolidBrush brush, Pen pen)
        {
            brush.Color = Color;
            graphics.FillRectangle(brush, X, Y, Width, Height);

            if (!IsSelected) return;
            pen.Color = SelectedColor;
            graphics.DrawRectangle(pen, X, Y, Width, Height);
        }

        public bool IsPointInside(Point point) =>
            point.X >= X &&
            point.Y >= Y &&
            point.X <= X + Width &&
            point.Y <= Y + Height;

        public Point GetOffset(Point point) => new Point(point.X - X, point.Y - Y);

        public float GetArea() => Width * Height;
    }
}
