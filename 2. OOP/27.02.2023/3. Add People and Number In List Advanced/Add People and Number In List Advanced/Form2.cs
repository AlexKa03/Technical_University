namespace Add_People_and_Number_In_List_Advanced
{
    public partial class Form2 : Form
    {
        private Person _person ;

        public Person Person
        {
            get
            {
                return _person;
            }
            set
            {
                _person = value;

                textBoxName.Text = _person.Name;
                textBoxNum.Text = _person.Num;
            }
        }

        public Form2()
        {
            InitializeComponent();
            buttonOk.MouseEnter += OnMouseEnterButtonOk;
            buttonOk.MouseLeave += OnMouseLeaveButtonOk;
        }

        private void OnMouseEnterButtonOk(object sender, EventArgs e)
        {
            buttonOk.BackColor = Color.Green;
        }
        private void OnMouseLeaveButtonOk(object sender, EventArgs e)
        {
            buttonOk.BackColor = SystemColors.ButtonFace;
        }

        //


        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Person.Name = textBoxName.Text;
            Person.Num = textBoxNum.Text;

            DialogResult = DialogResult.OK;
            //this.Close();
        }
    }
}
