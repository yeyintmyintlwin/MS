using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS
{
    public partial class LoginForm : Form
    {
        private IDBOperations db = new DB();
        private Size originalFormSize;
        public LoginForm()
        {
            InitializeComponent();
            originalFormSize = this.Size;
            ResponsiveForm.SetInitialSize(this);
        }
        private void Login_Load(object sender, EventArgs e)//load the form
        {

        }
        

        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {
                string inputPassword = password_textBox.Text;    
                string storedPassword = db.GetUserPassword(username_textBox.Text);//get the password from database
                if (storedPassword != null)//compare the password
                {
                    MessageBox.Show("Login Successful");
                    this.Hide();
                    MainMenuForm main = new MainMenuForm();
                    main.Show();

                    //Program.user_name = username_textBox.Text;
                    //main.UpdateUserNow();
                }

                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//show exception message
            }
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm signup = new SignUpForm();
            signup.Show();          
        }

        private void password_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                login_button_Click(sender, e);
            }
        }
    }
}
