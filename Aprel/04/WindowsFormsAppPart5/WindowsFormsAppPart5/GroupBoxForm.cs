using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPart5
{
    public partial class GroupBoxForm : Form
    {
        public GroupBoxForm()
        {
            InitializeComponent();
        }

        private void GroupBoxForm_Load(object sender, EventArgs e)
        {
            int labelCount = 0;
            int textBoxCount = 0;
            int groupBoxCount = 0;

            foreach (var item in this.Controls)
            {
                if (item is Label)
                    labelCount++;
                else if (item is TextBox)
                    textBoxCount++;
                else if (item is GroupBox)
                    groupBoxCount++;
            }

            GroupBox groupBox = this.Controls["groupBox1"] as GroupBox;

            foreach (var item in groupBox.Controls)
            {
                if (item is Label)
                    labelCount++;
                else if (item is TextBox)
                    textBoxCount++;
            }
        }
    }
}
