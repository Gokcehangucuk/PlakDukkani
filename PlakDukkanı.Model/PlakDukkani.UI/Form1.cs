using PlakDukkani.BLL.Funcions;

namespace PlakDukkani.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void lnkNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (PlakDukkaniFunc.UserControl(txtUserName.Text, txtPassword.Text))
            {
                MessageBox.Show("Giriþ baþarýlý.");
                this.Hide();
                Form3 form3 = new Form3();  
                form3.Show();
            }
            else
            {
                MessageBox.Show("Hatalý giriþ.");
            }
        }
    }
}