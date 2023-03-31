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
    public partial class HomePage : Form
    {
        public HomePage(User user)
        {
            InitializeComponent();
            nameEdit.Text = user.Name;
            surnameEdit.Text = user.Surname;
            usernameEdit.Text = user.Username;
            passwordEdit.Text = user.Password;
            aboutUserEdit.Text = user.AboutUser;
            saveUserInfoBtn.Tag = user.Id;
        }

        private void saveUserInfoBtn_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(saveUserInfoBtn.Tag);
            var editUser = VirtualDatabase.Users.Find(m => m.Id == userId);
            bool passwordChanged = false;

            editUser.Name = nameEdit.Text;
            editUser.Surname = surnameEdit.Text;
            editUser.AboutUser = aboutUserEdit.Text;

            if(editUser.Password != passwordEdit.Text)
            {
                passwordChanged = true;
            }

            editUser.Password = passwordEdit.Text;

            MessageBox.Show("Məlumatlar dəyişdirildi!");

            if (passwordChanged)
            {
                this.Close();
            }
        }
    }
}
