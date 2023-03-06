namespace Add_People_In_List
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
            textBoxName = new TextBox();
            buttonAdd = new Button();
            buttonRemove = new Button();
            label1 = new Label();
            labelOne = new Label();
            SuspendLayout();
            // 
            // listBoxPeople
            // 
            listBoxPeople.FormattingEnabled = true;
            listBoxPeople.ItemHeight = 20;
            listBoxPeople.Location = new Point(12, 106);
            listBoxPeople.Name = "listBoxPeople";
            listBoxPeople.Size = new Size(684, 264);
            listBoxPeople.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 32);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(684, 27);
            textBoxName.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(0, 161, 112);
            buttonAdd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(558, 376);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(126, 62);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.FromArgb(210, 56, 108);
            buttonRemove.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRemove.ForeColor = Color.White;
            buttonRemove.Location = new Point(426, 376);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(126, 62);
            buttonRemove.TabIndex = 3;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 4;
            label1.Text = "Лице";
            // 
            // labelOne
            // 
            labelOne.AutoSize = true;
            labelOne.Location = new Point(12, 83);
            labelOne.Name = "labelOne";
            labelOne.Size = new Size(45, 20);
            labelOne.TabIndex = 4;
            labelOne.Text = "Лица";
            labelOne.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 225, 206);
            ClientSize = new Size(708, 450);
            Controls.Add(labelOne);
            Controls.Add(label1);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxName);
            Controls.Add(listBoxPeople);
            Name = "Form1";
            Text = "Лица";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxPeople;
        private TextBox textBoxName;
        private Button buttonAdd;
        private Button buttonRemove;
        private Label label1;
        private Label labelOne;
    }
}