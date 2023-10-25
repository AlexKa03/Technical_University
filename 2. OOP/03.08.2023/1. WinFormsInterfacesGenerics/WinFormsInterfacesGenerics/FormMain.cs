using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsInterfacesGenerics
{
    public partial class FormMain : Form
    {
        private readonly List<IDrawable> _drawables = new List<IDrawable>();
        private readonly Random _rnd = new Random();

        public FormMain() => InitializeComponent();

        protected override void OnPaint(PaintEventArgs e) // or subscribe to the Paint event
        {
            base.OnPaint(e);
            foreach (var drawable in _drawables)
                drawable.Draw(e.Graphics);
        }

        protected override void OnMouseClick(MouseEventArgs e) // or subscribe to the MouseClick event
        {
            base.OnMouseClick(e);

            Color rndColor = Color.FromArgb(_rnd.Next(byte.MaxValue), _rnd.Next(byte.MaxValue), _rnd.Next(byte.MaxValue));
            Size rndSize = new Size(_rnd.Next(50, 200), _rnd.Next(50, 200));

            switch (e.Button)
            {
                case MouseButtons.Left:
                    _drawables.Add(new RectangleShape(rndColor) { Bounds = new Rectangle(e.Location, rndSize) });
                    break;

                case MouseButtons.Right:
                    _drawables.Add(new Elipse(rndColor) { Bounds = new Rectangle(e.Location, rndSize) });
                    break;

                case MouseButtons.Middle:
                    _drawables.Add(new ImageNumber(rndSize.Width, rndSize.Height, _rnd.Next(1_000), rndColor)
                    {
                        Location = e.Location,
                        DoDrawBoarder = _rnd.Next() % 2 == 0
                    });
                    break;
            }

            Refresh(); // Forces repaint
        }

        protected override void OnKeyDown(KeyEventArgs e) // or subscribe to the KeyDown event
        {
            base.OnKeyDown(e);

            switch (e.KeyCode)
            {
                case Keys.F:
                    WindowState = WindowState == FormWindowState.Normal // Checks if the state is normal and sets it to maximized otherwise sets it to normal
                        ? FormWindowState.Maximized
                        : FormWindowState.Normal;
                    break;

                case Keys.R:
                    _drawables.Clear();
                    break;

                case Keys.Escape:
                    Close();
                    return;
            }

            Refresh();
        }
    }
}
