namespace Add_People_In_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listBoxPeople.Items.Add(textBoxName.Text);
            textBoxName.Text = string.Empty;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            listBoxPeople.Items.Remove(listBoxPeople.SelectedItem);
        }
    }
}