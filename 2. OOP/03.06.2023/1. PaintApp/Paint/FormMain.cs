namespace Paint
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;

            Pen pen = new Pen(Color.Red, 10);

            graphics.DrawLine(pen, 30, 30, 90, 90);
            graphics.DrawLine(pen, 90, 30, 30, 90);
        }
    }
}