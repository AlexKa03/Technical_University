namespace Add_People_and_Number_In_List_Advanced
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxName = new TextBox();
            label1 = new Label();
            textBoxNum = new TextBox();
            label2 = new Label();
            buttonOk = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxName.Location = new Point(10, 44);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(449, 34);
            textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 6);
            label1.Name = "label1";
            label1.Size = new Size(91, 38);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // textBoxNum
            // 
            textBoxNum.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxNum.Location = new Point(10, 115);
            textBoxNum.Margin = new Padding(3, 2, 3, 2);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(449, 34);
            textBoxNum.TabIndex = 0;
            textBoxNum.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 77);
            label2.Name = "label2";
            label2.Size = new Size(78, 38);
            label2.TabIndex = 1;
            label2.Text = "Num";
            label2.Click += label2_Click;
            // 
            // buttonOk
            // 
            buttonOk.BackColor = Color.FromArgb(136, 176, 75);
            buttonOk.Font = new Font("Segoe UI", 35F, FontStyle.Bold, GraphicsUnit.Pixel);
            buttonOk.Location = new Point(10, 155);
            buttonOk.Margin = new Padding(3, 2, 3, 2);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(449, 67);
            buttonOk.TabIndex = 2;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = false;
            buttonOk.Click += buttonOk_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 86, 139);
            ClientSize = new Size(470, 232);
            Controls.Add(buttonOk);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNum);
            Controls.Add(textBoxName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Person Dialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private Label label1;
        private TextBox textBoxNum;
        private Label label2;
        private Button buttonOk;
    }
}