namespace PlakDukkani.UI
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
            label1 = new Label();
            txtFirstName = new TextBox();
            txtUserName = new TextBox();
            label2 = new Label();
            txtPassword1 = new TextBox();
            label3 = new Label();
            txtPassword2 = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label5 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 50);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Yönetici Adı :";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(260, 47);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(147, 27);
            txtFirstName.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(260, 145);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(147, 27);
            txtUserName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 148);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 2;
            label2.Text = "Kullanıcı Adı : ";
            // 
            // txtPassword1
            // 
            txtPassword1.Location = new Point(260, 194);
            txtPassword1.Name = "txtPassword1";
            txtPassword1.Size = new Size(147, 27);
            txtPassword1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 197);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Şifre :";
            // 
            // txtPassword2
            // 
            txtPassword2.Location = new Point(260, 243);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.Size = new Size(147, 27);
            txtPassword2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 246);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 6;
            label4.Text = "Şifre Tekrarı : ";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(260, 96);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(147, 27);
            txtLastName.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 99);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 8;
            label5.Text = "Yönetici Soyadı :";
            // 
            // button1
            // 
            button1.Location = new Point(171, 330);
            button1.Name = "button1";
            button1.Size = new Size(236, 59);
            button1.TabIndex = 10;
            button1.Text = "Kayıt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(333, 289);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(74, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Göster";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 454);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(txtLastName);
            Controls.Add(label5);
            Controls.Add(txtPassword2);
            Controls.Add(label4);
            Controls.Add(txtPassword1);
            Controls.Add(label3);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private TextBox txtUserName;
        private Label label2;
        private TextBox txtPassword1;
        private Label label3;
        private TextBox txtPassword2;
        private Label label4;
        private TextBox txtLastName;
        private Label label5;
        private Button button1;
        private CheckBox checkBox1;
    }
}