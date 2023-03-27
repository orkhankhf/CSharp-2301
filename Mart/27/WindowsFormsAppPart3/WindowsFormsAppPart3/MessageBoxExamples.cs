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
    public partial class MessageBoxExamples : Form
    {
        public MessageBoxExamples()
        {
            InitializeComponent();
        }

        private void standartMessageBoxBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu bir MessageBox'dur!", "Başlıq", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void questionWithCancelMessageBoxBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hə, Yox və ya İmtina seçin!", "Hə/Yox/İmtina Sualı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        private void exitProgramBtn_Click(object sender, EventArgs e)
        {
            DialogResult exitProgram = MessageBox.Show("Proqramdan çıxılsın?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (exitProgram == DialogResult.Yes)
                Application.Exit();
        }
    }
}
