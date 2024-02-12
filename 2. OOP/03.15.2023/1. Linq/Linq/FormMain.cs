using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq
{
    public partial class FormMain : Form
    {
        private readonly Random _rnd;
        private readonly SolidBrush _solidBrush;
        private readonly Pen _pen;
        private List<Rect> _rects;
        private List<Color> _colors;
        private Rect _selectedRect;
        private Point _offset;
        private bool _doDrawGrayscale;
        private float _min;
        private float _max;

        public FormMain()
        {
            InitializeComponent();
            _rnd = new Random();
            _rects = new List<Rect>();
            _colors = new List<Color>();
            _solidBrush = new SolidBrush(Color.Black);
            _pen = new Pen(Color.Black, 10);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (_doDrawGrayscale)
            {
                var rects = _rects.OrderByDescending(r => r.GetArea()).ToArray();
                for (int i = 0; i < rects.Length; i++)
                {
                    byte c = (byte)((float)i / rects.Length * byte.MaxValue);
                    rects[i].Color = Color.FromArgb(c, c, c);
                    rects[i].Draw(e.Graphics, _solidBrush, _pen);
                }
            }
            else
            {
                foreach (var rect in _rects)
                    rect.Draw(e.Graphics, _solidBrush, _pen);
            }

            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            switch (e.Button)
            {
                case MouseButtons.Right:
                    _rects.Add(new Rect()
                    {
                        Location = e.Location,
                        Width = _rnd.Next(250),
                        Height = _rnd.Next(250),
                        Color = Color.FromArgb(
                            _rnd.Next(byte.MaxValue),
                            _rnd.Next(byte.MaxValue),
                            _rnd.Next(byte.MaxValue))
                    });
                    break;

                case MouseButtons.Left:
                    for (int i = _rects.Count - 1; i >= 0; i--)
                    {
                        if (!_rects[i].IsPointInside(e.Location)) continue;

                        _selectedRect = _rects[i];
                        _offset = _selectedRect.GetOffset(e.Location);
                        _selectedRect.IsSelected = true;
                        _rects[i] = _rects[_rects.Count - 1];
                        _rects[_rects.Count - 1] = _selectedRect;
                        break;
                    }
                    break;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            MoveSelected(e.Location);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (_selectedRect == null) return;
            MoveSelected(e.Location);
            _selectedRect.IsSelected = false;
            _selectedRect = null;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.E)
            {
                if (_doDrawGrayscale == false)
                {
                    _min = _rects.Min(r => r.GetArea());
                    _max = _rects.Max(r => r.GetArea());
                    _colors.Clear();
                    _colors.AddRange(_rects.Select(r => r.Color));
                    _doDrawGrayscale = true;
                }
                else
                {
                    for (int i = 0; i < _rects.Count; i++)
                        _rects[i].Color = _colors[i];
                    _doDrawGrayscale = false;
                }
            }
        }

        private void MoveSelected(Point point)
        {
            if (_selectedRect == null) return;
            _selectedRect.X = point.X - _offset.X;
            _selectedRect.Y = point.Y - _offset.Y;
        }
    }
}
