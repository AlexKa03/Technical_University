using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsInterfacesGenerics
{
    class RectangleShape : Shape // If the name was just "Rectangle" it would have collided with the struct System.Drawing.Rectangle
    {
        public RectangleShape(Color color) : base(color) { }

        public override void Draw(Graphics graphics) => graphics.FillRectangle(Brush, Bounds);
    }
}
