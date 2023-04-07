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
    public partial class DataGridViewForm : Form
    {
        public DataGridViewForm()
        {
            InitializeComponent();
        }

        private void DataGridViewForm_Load(object sender, EventArgs e)
        {
            VirtualDatabase db = new VirtualDatabase();
            List<Customer> customers = db.GetCustomers(100);

            customersDataGridView.DataSource = customers;//Ella

            customersDataGridView.Columns[0].Width = 25;
            customersDataGridView.Columns["Name"].HeaderText = "Ad";
            customersDataGridView.Columns["Fullname"].Visible = false;

            //1-ci yol
            var queryResult = (from item in customers
                               select new //anonymous type
                               {
                                   Sira = item.Id,
                                   Ad = item.Name,
                                   Soyad = item.Surname
                               }).ToList();

            //2-ci yol
            var queryResult2 = customers.Select(item => new
            {
                item.Id,
                Ad = item.Name,
                Soyad = item.Surname
            }).ToList();

            //customersDataGridView.DataSource = queryResult2;
        }

        private void customersDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int rowIndex = customersDataGridView.CurrentCell.RowIndex;
            int customerId = (int)customersDataGridView[0, rowIndex].Value;

            VirtualDatabase db = new VirtualDatabase();
            Customer selectedCustomer = db.GetCustomers(100).
                FirstOrDefault(i => i.Id == customerId);

            CustomerInfoPopup infoPopup = new CustomerInfoPopup(selectedCustomer);
            infoPopup.ShowDialog();
        }
    }
}
