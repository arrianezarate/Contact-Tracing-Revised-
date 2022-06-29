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
    public partial class admin_access : Form
    {
        public admin_access()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            all_records listallrecords = new all_records();
            listallrecords.ShowDialog();
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            List<string> ByDate = new List<string>();
            string Date = SelectDate.Text;
            int results = 0;
            var txtlist = Directory.EnumerateFiles(@"C:\Users\arriane\source\repos\Contact-Tracing-Revisedd\lists");
            foreach (string file in txtlist)
            {
                string allcontents = File.ReadAllText(file);
                if (allcontents.Contains(Date))
                {
                    ByDate.Add(allcontents);
                    results++;
                    continue;
                }
            }
            if (results == 0)
            {
                MessageBox.Show("The list for the selected date is empty.");
            }
            else
            {
                StreamWriter file = new StreamWriter(@"C:\Users\arriane\source\repos\Contact-Tracing-Revisedd\lists\by date\records(by date).txt");
                foreach (string contents in ByDate)
                {
                    file.WriteLine(contents);
                }
                file.Close();
                MessageBox.Show("There are " + results + " record(s) on the selected date.");
                if (MessageBox.Show("Confirm", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    by_date bydate = new by_date();
                    bydate.ShowDialog();
                }
            }
        }
    }
}
