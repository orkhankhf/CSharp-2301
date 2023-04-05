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
    public partial class MultipleListBoxResultView : Form
    {
        public MultipleListBoxResultView(List<Book> books)
        {
            InitializeComponent();

            foreach (var item in books)
            {
                var x = item;
            }
        }
    }
}
