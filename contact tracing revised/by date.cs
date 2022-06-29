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
    public partial class by_date : Form
    {
        public by_date()
        {
            InitializeComponent();
            var recordselectedDate = Directory.GetFiles(@"C:\Users\arriane\source\repos\contact tracing revised\lists\by date\");
            foreach (string file in recordselectedDate)
            {
                string dates = File.ReadAllText(file);
                lbl_Recordsbydate.Text = lbl_Recordsbydate.Text + dates + "\n";
            }

        }

        private void by_date_Load(object sender, EventArgs e)
        {

        }
    }
}
