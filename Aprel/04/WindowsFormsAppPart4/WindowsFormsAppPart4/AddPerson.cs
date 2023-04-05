using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPart4
{
    public partial class AddPerson : Form
    {
        public AddPerson()
        {
            InitializeComponent();
        }

        private void saveFormBtn_Click(object sender, EventArgs e)
        {
            VerifyPersonData form = new VerifyPersonData();
            ((TextBox)form.Controls["nameDisabledTextBox"]).Text = nameTextBox.Text;
            ((TextBox)form.Controls["surnameDisabledTextBox"]).Text = surnameTextBox.Text;
            ((TextBox)form.Controls["docSerialDisabledTextBox"]).Text = docSerialTextBox.Text;
            ((TextBox)form.Controls["docNumberDisabledTextBox"]).Text = docNumberTextBox.Text;
            form.ShowDialog();
        }
    }
}
