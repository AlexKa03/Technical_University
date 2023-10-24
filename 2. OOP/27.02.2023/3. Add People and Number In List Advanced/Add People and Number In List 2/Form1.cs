namespace Add_People_and_Number_In_List_Advanced
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var formPerson = new Form2();
            var person = new Person();

            formPerson.Person = person;

            if (formPerson.ShowDialog() == DialogResult.OK)
            {
                listBoxPeople.Items.Add(person);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            listBoxPeople.Items.Remove(listBoxPeople.SelectedItem);
        }

        private void listBoxPeople_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxPeople.SelectedItem == null)
            {
                MessageBox.Show("Invalid");
                return;
            }

            var formPerson = new Form2();

            var person = (Person)listBoxPeople.SelectedItem;
            formPerson.Person = person;

            if (formPerson.ShowDialog() == DialogResult.OK)
            {
                int index = listBoxPeople.SelectedIndex;
                listBoxPeople.Items.RemoveAt(index);
                listBoxPeople.Items.Insert(index, person);
            }
        }
    }
}