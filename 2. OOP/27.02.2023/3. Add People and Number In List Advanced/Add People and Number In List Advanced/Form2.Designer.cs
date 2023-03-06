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
            textBoxName.Location = new Point(12, 59);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(513, 34);
            textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(94, 40);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // textBoxNum
            // 
            textBoxNum.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxNum.Location = new Point(12, 146);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(513, 34);
            textBoxNum.TabIndex = 0;
            textBoxNum.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(80, 40);
            label2.TabIndex = 1;
            label2.Text = "Num";
            label2.Click += label2_Click;
            // 
            // buttonOk
            // 
            buttonOk.BackColor = Color.FromArgb(136, 176, 75);
            buttonOk.Font = new Font("Segoe UI", 35F, FontStyle.Bold, GraphicsUnit.Pixel);
            buttonOk.Location = new Point(12, 200);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(513, 89);
            buttonOk.TabIndex = 2;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = false;
            buttonOk.Click += buttonOk_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 86, 139);
            ClientSize = new Size(537, 309);
            Controls.Add(buttonOk);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNum);
            Controls.Add(textBoxName);
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