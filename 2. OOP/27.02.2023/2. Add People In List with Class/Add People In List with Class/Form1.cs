namespace Add_People_In_List_with_Class
{
    public partial class FormPersons : Form
    {
        public FormPersons()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Name = textBoxName.Text;

            listBoxPersons.Items.Add(person);

            textBoxName.Text = string.Empty;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            listBoxPersons.Items.Remove(listBoxPersons.SelectedItem);
        }
    }
}