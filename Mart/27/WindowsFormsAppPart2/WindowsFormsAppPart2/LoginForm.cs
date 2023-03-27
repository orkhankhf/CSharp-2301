using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPart2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginMethod(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            User foundUser = VirtualDatabase.Users.Find(m => m.Username == username && m.Password == password);
            
            if(foundUser != null)
            {
                HomePage homePage = new HomePage(foundUser);
                homePage.Show();
            }
            else
            {
                MessageBox.Show("Istifadeci melumatlari yanlisdir!", "Xeta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxEnterColor(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.Yellow;
        }

        private void TextBoxLeaveColor(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.White;
        }
    }
}
