using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPart6
{
    public partial class CustomerInfoPopup : Form
    {
        Customer customer;

        public CustomerInfoPopup(Customer customer)
        {
            InitializeComponent();

            this.customer = customer;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerInfoPopup_Load(object sender, EventArgs e)
        {
            txtId.Text = customer.Id.ToString();
            txtName.Text = customer.Name;
            txtSurname.Text = customer.Surname;
            txtEmail.Text = customer.Email;
            txtPhone.Text = customer.Phone;
            txtCountry.Text = customer.Country;
            txtCity.Text = customer.City;
            txtAddress.Text = customer.Address;
        }
    }
}
