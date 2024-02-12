using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsInterfacesGenerics
{
    class Elipse : Shape
    {
        public Elipse(Color color) : base(color) { }

        public override void Draw(Graphics graphics) => graphics.FillEllipse(Brush, Bounds);
    }
}
