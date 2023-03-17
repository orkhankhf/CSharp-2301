using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormFirstLesson
{
    public partial class ShowMessage : Form
    {
        public ShowMessage(string message)
        {
            InitializeComponent();
            textMessageLabel.Text = message;
        }
    }
}
