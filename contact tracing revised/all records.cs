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
    public partial class all_records : Form
    {
        public all_records()
        {
            InitializeComponent();
            var allRecords = Directory.GetFiles(@"C:\Users\arriane\source\repos\contact tracing revised\lists");
            foreach (var file in allRecords)
            {
                string allcontents = File.ReadAllText(file);
                lbl_Allrecords.Text = lbl_Allrecords.Text + "\n" + allcontents + "\n";
            }
        }
    }
}
