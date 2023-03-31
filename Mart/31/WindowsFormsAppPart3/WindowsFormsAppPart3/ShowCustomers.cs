using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPart3
{
    public partial class ShowCustomers : Form
    {
        public ShowCustomers()
        {
            InitializeComponent();
        }

        private void ShowCustomers_Load(object sender, EventArgs e)
        {
            customerList.DataSource = VirtualDatabase.Customers;
        }
    }
}
