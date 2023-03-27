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
    public partial class FormControls : Form
    {
        public FormControls()
        {
            InitializeComponent();
        }

        private void FormControls_Load(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                //MessageBox.Show(item.Name);
            }
        }

        private void clearFormBtn_Click(object sender, EventArgs e)
        {
            DialogResult resultEnum = MessageBox.Show(
                                                        "Form dəyərlərini sıfırlamaq istədiyinizdən əminsiniz?",
                                                        "Sıfırlamaq",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);

            if(resultEnum == DialogResult.Yes)
            {
                foreach (Control item in this.Controls)
                {
                    if(item is TextBox)
                    {
                        TextBox textBox = (TextBox)item;
                        textBox.Text = string.Empty;
                    }
                }

                ((TextBox)this.Controls["nameTextBox"]).Text = string.Empty;
                ((TextBox)this.Controls["surnameTextBox"]).Text = string.Empty;
                ((TextBox)this.Controls["emailTextBox"]).Text = string.Empty;
                ((TextBox)this.Controls["phoneTextBox"]).Text = string.Empty;
            }
            else
            {
                //Legv edildi
            }
        }
    }
}
