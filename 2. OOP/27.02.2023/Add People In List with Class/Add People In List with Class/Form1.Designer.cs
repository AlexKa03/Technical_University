namespace Add_People_In_List_with_Class
{
    partial class FormPersons
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelPerson = new Label();
            textBoxName = new TextBox();
            labelPersons = new Label();
            listBoxPersons = new ListBox();
            buttonAdd = new Button();
            buttonRemove = new Button();
            SuspendLayout();
            // 
            // labelPerson
            // 
            labelPerson.AutoSize = true;
            labelPerson.ForeColor = Color.White;
            labelPerson.Location = new Point(12, 19);
            labelPerson.Name = "labelPerson";
            labelPerson.Size = new Size(45, 20);
            labelPerson.TabIndex = 0;
            labelPerson.Text = "Лице";
            // 
            // textBoxName
            // 
            textBoxName.ForeColor = Color.FromArgb(54, 57, 69);
            textBoxName.Location = new Point(12, 42);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(776, 27);
            textBoxName.TabIndex = 1;
            // 
            // labelPersons
            // 
            labelPersons.AutoSize = true;
            labelPersons.ForeColor = Color.White;
            labelPersons.Location = new Point(12, 99);
            labelPersons.Name = "labelPersons";
            labelPersons.Size = new Size(45, 20);
            labelPersons.TabIndex = 0;
            labelPersons.Text = "Лица";
            // 
            // listBoxPersons
            // 
            listBoxPersons.FormattingEnabled = true;
            listBoxPersons.ItemHeight = 20;
            listBoxPersons.Location = new Point(12, 122);
            listBoxPersons.Name = "listBoxPersons";
            listBoxPersons.Size = new Size(776, 224);
            listBoxPersons.TabIndex = 2;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(160, 218, 169);
            buttonAdd.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            buttonAdd.Location = new Point(646, 361);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(142, 77);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.FromArgb(218, 160, 160);
            buttonRemove.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            buttonRemove.Location = new Point(480, 361);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(142, 77);
            buttonRemove.TabIndex = 3;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // FormPersons
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(54, 57, 69);
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(listBoxPersons);
            Controls.Add(textBoxName);
            Controls.Add(labelPersons);
            Controls.Add(labelPerson);
            Name = "FormPersons";
            Text = "Лица";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPerson;
        private TextBox textBoxName;
        private Label labelPersons;
        private ListBox listBoxPersons;
        private Button buttonAdd;
        private Button buttonRemove;
    }
}