using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Spend_Management
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            LoadPage(new LoginControl());
        }

        public void LoadPage(UserControl uc)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
        }
    }
}
