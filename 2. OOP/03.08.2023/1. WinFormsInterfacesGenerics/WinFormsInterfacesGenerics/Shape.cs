using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsInterfacesGenerics
{
    abstract class Shape : IDrawable, IDisposable
    {
        public Rectangle Bounds { get; set; }
        public Color Color
        {
            get => Brush.Color;
            set => Brush.Color = value;
        }
        protected SolidBrush Brush { get; }

        public Shape(Color color) => Brush = new SolidBrush(color);

        public abstract void Draw(Graphics graphics);

        public void Dispose() => Brush.Dispose();
    }
}
