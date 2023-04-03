namespace PlakDukkani.UI
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
            btnEnter = new Button();
            lblKullaniciAdi = new Label();
            txtUserName = new TextBox();
            lnkNewUser = new LinkLabel();
            txtPassword = new TextBox();
            label2 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(172, 220);
            btnEnter.Margin = new Padding(4, 3, 4, 3);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(214, 49);
            btnEnter.TabIndex = 0;
            btnEnter.Text = "Giriş ";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(61, 57);
            lblKullaniciAdi.Margin = new Padding(4, 0, 4, 0);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(121, 23);
            lblKullaniciAdi.TabIndex = 1;
            lblKullaniciAdi.Text = "Kullanıcı Adi :";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(204, 57);
            txtUserName.Margin = new Padding(4, 3, 4, 3);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(182, 30);
            txtUserName.TabIndex = 2;
            // 
            // lnkNewUser
            // 
            lnkNewUser.AutoSize = true;
            lnkNewUser.Location = new Point(275, 290);
            lnkNewUser.Margin = new Padding(4, 0, 4, 0);
            lnkNewUser.Name = "lnkNewUser";
            lnkNewUser.Size = new Size(74, 23);
            lnkNewUser.TabIndex = 3;
            lnkNewUser.TabStop = true;
            lnkNewUser.Text = "Kayıt Ol";
            lnkNewUser.LinkClicked += lnkNewUser_LinkClicked;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(204, 113);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(182, 30);
            txtPassword.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 120);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 4;
            label2.Text = "Şifre : ";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(302, 160);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(84, 27);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Göster";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 392);
            Controls.Add(checkBox1);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(lnkNewUser);
            Controls.Add(txtUserName);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(btnEnter);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnter;
        private Label lblKullaniciAdi;
        private TextBox txtUserName;
        private LinkLabel lnkNewUser;
        private TextBox txtPassword;
        private Label label2;
        private CheckBox checkBox1;
    }
}