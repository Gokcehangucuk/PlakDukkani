using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlakDukkani.BLL.Funcions;
using PlakDukkanı.DAL.Context;
using PlakDukkanı.Model.Models;

namespace PlakDukkani.UI
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtPassword1.PasswordChar = '*';
            txtPassword2.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword1.PasswordChar = '\0';
                txtPassword2.PasswordChar = '\0';
            }
            else
            {
                txtPassword1.PasswordChar = '*';
                txtPassword2.PasswordChar = '*';
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //Giriş ekranındaki textbox ve şifre kontrolleri burada yapılmaktadır.
            if (txtFirstName.Text !=string.Empty && txtLastName.Text!=string.Empty && txtPassword1.Text !=string.Empty && txtPassword2.Text !=string.Empty&&txtUserName.Text!=string.Empty) 
            {
                string password = txtPassword1.Text;
                if (txtPassword2.Text == password)
                {
                    int lowerCase = 0;
                    int upperCase = 0;
                    List<char> specialChar = new List<char>();

                    for (int i = 0; i < password.Length; i++)
                    {
                        if (password[i] == '!' || password[i] == ':' || password[i] == '*' || password[i] == '+')
                        {
                            if (!(specialChar.Contains(password[i])))
                            {
                                specialChar.Add(password[i]);
                            }
                        }
                        else if (char.IsLower(password[i]))
                        {
                            lowerCase++;
                        }
                        else if (char.IsUpper(password[i]))
                        {
                            upperCase++;
                        }
                    }
                    if (password.Length >= 8 && lowerCase >= 3 && upperCase >= 2 && specialChar.Count >= 2)
                    {
                        Administrator administrator = new Administrator();
                        administrator.FirstName = txtFirstName.Text;
                        administrator.LastName = txtLastName.Text;
                        administrator.UserName = txtUserName.Text;//kullanıcı kontrolu yapılacak
                        administrator.SetPassword(password);
                        PlakDukkaniFunc._db.Administrators.Add(administrator);
                        PlakDukkaniFunc._db.SaveChanges();
                        MessageBox.Show("Kayıt işlemi başarılı");
                    }
                    else
                    {
                        MessageBox.Show("• En az 8 karakter uzunluğunda olmalıdır.\r\n• En az 2 büyük harf içermelidir.\r\n• En az 3 küçük harf içermelidir.\r\n• ! (ünlem), : (iki nokta üst üste), +(artı), *(yıldız) karakterlerinden en az 2 tanesini içermelidir. (Aynı karakterden birden fazla olabilir)");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler aynı değildir.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bilgilerin hepsini doldurunuz.");
            }
            
        }
    }
}
