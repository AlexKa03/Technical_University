using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsInterfacesGenerics
{
    class ImageNumber : IDrawable, IDisposable
    {
        private readonly Bitmap _bitmap;
        private Pen _pen;
        private bool _doDrawBoarder;
        public Point Location { get; set; }
        public bool DoDrawBoarder 
        {
            get => _doDrawBoarder; 
            set
            {
                if (_pen == null)
                    _pen = new Pen(Color.Black);

                _doDrawBoarder = value;
            }
        }

        public ImageNumber(int width, int height, int number, Color color)
        {
            int digits = number.ToString().Length;
            _bitmap = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(_bitmap))
            using (Font font = new Font(FontFamily.GenericMonospace, Math.Min(width, height) / (float)digits, GraphicsUnit.Pixel)) // Convert the division from int to float
            using (Brush brush = new SolidBrush(color))
            using (StringFormat stringFormat = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                graphics.DrawString(number.ToString(), font, brush, new RectangleF(Location, _bitmap.PhysicalDimension), stringFormat);
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawImage(_bitmap, Location);

            if (DoDrawBoarder)
                graphics.DrawRectangle(_pen, new Rectangle(Location, _bitmap.PhysicalDimension.ToSize()));
        }

        public void Dispose()
        {
            _bitmap.Dispose();
            _pen?.Dispose();
        }
    }
}
