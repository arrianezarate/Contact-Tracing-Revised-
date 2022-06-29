using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contact_tracing_revised
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void txtbox_Username_Enter(object sender, EventArgs e)
        {
            if (txtbox_Username.Text == "Enter your username")
            {
                txtbox_Username.Text = "";
                txtbox_Username.ForeColor = Color.Black;
            }
        }

        private void txtbox_Username_Leave(object sender, EventArgs e)
        {
            if (txtbox_Username.Text == "")
            {
                txtbox_Username.Text = "Enter your username";
                txtbox_Username.ForeColor = Color.Silver;
            }
        }

        private void txtbox_Password_Enter(object sender, EventArgs e)
        {
            if (txtbox_Password.Text == "Enter your password")
            {
                txtbox_Password.Text = "";
                txtbox_Password.ForeColor = Color.Black;
            }
        }

        private void txtbox_Password_Leave(object sender, EventArgs e)
        {
            if (txtbox_Password.Text == "")
            {
                txtbox_Password.Text = "Enter your password";
                txtbox_Password.ForeColor = Color.Silver;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtbox_Username.Text == "arrianezarate" && txtbox_Password.Text == "1234")
            {
                new admin_access().Show();
                this.Hide();
            }
        }
    }
}
