using System;
using System.Drawing;
using System.Windows.Forms;

namespace MS
{
    public partial class SignUpForm : Form
    {
        private Size originalFormSize;
        private IDBOperations db = new DB();
        public SignUpForm()
        {
            InitializeComponent();
            originalFormSize = this.Size;
            ResponsiveForm.SetInitialSize(this);
        }            

        private void SignUpForm_Resize(object sender, EventArgs e)
        {
            ResponsiveForm.ResizeForm(this, originalFormSize);
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (password_textBox.Text == Repassword_textBox.Text)
                {
                    string inputPassword = password_textBox.Text;
                    db.InsertUser(username_textBox.Text, password_textBox.Text, fullname_textBox.Text, email_textBox.Text);
                    MessageBox.Show("Sign Up Successful");
                    this.Hide();
                    LoginForm login = new LoginForm();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Password does not match");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
