using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spend_Management
{
    public partial class AddItemForm : Form
    {
        public string CategoryName { get; set; }
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CategoryName = textBoxCategory.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
