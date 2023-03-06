namespace Add_People_and_Number_In_List_Advanced
{
    partial class Form1
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
            listBoxPeople = new ListBox();
            buttonRemove = new Button();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // listBoxPeople
            // 
            listBoxPeople.Font = new Font("Segoe UI", 13.5F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxPeople.FormattingEnabled = true;
            listBoxPeople.ItemHeight = 30;
            listBoxPeople.Location = new Point(12, 12);
            listBoxPeople.Name = "listBoxPeople";
            listBoxPeople.Size = new Size(513, 424);
            listBoxPeople.TabIndex = 0;
            listBoxPeople.DoubleClick += listBoxPeople_DoubleClick;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.FromArgb(255, 111, 97);
            buttonRemove.Font = new Font("Segoe UI", 35F, FontStyle.Bold, GraphicsUnit.Pixel);
            buttonRemove.Location = new Point(14, 455);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(245, 89);
            buttonRemove.TabIndex = 1;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(136, 176, 75);
            buttonAdd.Font = new Font("Segoe UI", 35F, FontStyle.Bold, GraphicsUnit.Pixel);
            buttonAdd.Location = new Point(280, 455);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(245, 89);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 86, 139);
            ClientSize = new Size(537, 556);
            Controls.Add(buttonAdd);
            Controls.Add(buttonRemove);
            Controls.Add(listBoxPeople);
            Name = "Form1";
            Text = "People";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxPeople;
        private Button buttonRemove;
        private Button buttonAdd;
    }
}