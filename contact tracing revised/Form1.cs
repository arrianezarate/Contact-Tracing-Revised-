namespace contact_tracing_revised
{
    public partial class ContactTracingForm : Form
    {
        public ContactTracingForm()
        {
            InitializeComponent();
        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\arriane\source\repos\Contact-Tracing-Revisedd\lists\" + txtbox_LastName.Text + ", " + txtbox_FirstName.Text + ", " + txtbox_MiddleName.Text + ".txt", true);
            file.WriteLine("First Name - " + txtbox_FirstName.Text);
            file.WriteLine("Middle Name - " + txtbox_MiddleName.Text);
            file.WriteLine("Last Name - " + txtbox_LastName.Text);
            file.WriteLine("Age - " + txtbox_Age.Text);
            file.WriteLine("Birth Date - " + txtbox_BirthDate.Text);
            file.WriteLine("Mobile No. - " + txtbox_Mobile.Text);
            file.WriteLine("Email - " + txtbox_Email.Text);
            file.WriteLine("Gender - " + txtbox_Gender.Text);
            file.WriteLine("Address - " + txtbox_Address.Text);
            file.WriteLine("Traveled recently? - " + txtbox_Travel.Text);
            file.WriteLine("Date - " + formDate.Text);
            file.WriteLine("Symptoms? - " + txtbox_Symptoms.Text);
            file.Close();

            MessageBox.Show("Thanks for cooperating.", "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Have a good day!", "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);


            txtbox_FirstName.Text = "First Name";
            txtbox_FirstName.ForeColor = Color.Silver;
            txtbox_MiddleName.Text = "NA";
            txtbox_MiddleName.ForeColor = Color.Silver;
            txtbox_LastName.Text = "Last name";
            txtbox_LastName.ForeColor = Color.Silver;
            txtbox_Age.Text = "Age";
            txtbox_Age.ForeColor = Color.Silver;
            txtbox_BirthDate.Text = "Month, Date, Year";
            txtbox_BirthDate.ForeColor = Color.Silver;
            txtbox_Mobile.Text = "Mobile No.";
            txtbox_Mobile.ForeColor = Color.Silver;
            txtbox_Email.Text = "@mail.com";
            txtbox_Email.ForeColor = Color.Silver;
            txtbox_Gender.Text = "M/F";
            txtbox_Gender.ForeColor = Color.Silver;
            txtbox_Address.Text = "Street, Barangay, City. Province, Zip Code";
            txtbox_Address.ForeColor = Color.Silver;
            txtbox_Travel.Text = "Yes/No";
            txtbox_Travel.ForeColor = Color.Silver;
            txtbox_Symptoms.Text = "Yes/No";
            txtbox_Symptoms.ForeColor = Color.Silver;
        }

        private void txtbox_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_FirstName_Enter(object sender, EventArgs e)
        {
            if (txtbox_FirstName.Text == "First Name")
            {
                txtbox_FirstName.Text = "";
                txtbox_FirstName.ForeColor = Color.Black;
            }
        }

        private void txtbox_FirstName_Leave(object sender, EventArgs e)
        {
            if (txtbox_FirstName.Text == "")
            {
                txtbox_FirstName.Text = "First Name";
                txtbox_FirstName.ForeColor = Color.Silver;
            }
        }

        private void txtbox_MiddleName_Enter(object sender, EventArgs e)
        {
            if (txtbox_MiddleName.Text == "NA")
            {
                txtbox_MiddleName.Text = "";
                txtbox_MiddleName.ForeColor = Color.Black;
            }
        }

        private void txtbox_MiddleName_Leave(object sender, EventArgs e)
        {
            if (txtbox_MiddleName.Text == "")
            {
                txtbox_MiddleName.Text = "NA";
                txtbox_MiddleName.ForeColor = Color.Silver;
            }
        }

        private void txtbox_LastName_Enter(object sender, EventArgs e)
        {
            if (txtbox_LastName.Text == "Last Name")
            {
                txtbox_LastName.Text = "";
                txtbox_LastName.ForeColor = Color.Black;
            }
        }

        private void txtbox_LastName_Leave(object sender, EventArgs e)
        {
            if (txtbox_LastName.Text == "")
            {
                txtbox_LastName.Text = "Last Name";
                txtbox_LastName.ForeColor = Color.Silver;
            }
        }

        private void txtbox_Age_Enter(object sender, EventArgs e)
        {
            if (txtbox_Age.Text == "Age")
            {
                txtbox_Age.Text = "";
                txtbox_Age.ForeColor = Color.Black;
            }
        }

        private void txtbox_Age_Leave(object sender, EventArgs e)
        {
            if (txtbox_Age.Text == "")
            {
                txtbox_Age.Text = "Age";
                txtbox_Age.ForeColor = Color.Silver;
            }
        }

        private void txtbox_BirthDate_Enter(object sender, EventArgs e)
        {
            if (txtbox_BirthDate.Text == "Month, Date, Year")
            {
                txtbox_BirthDate.Text = "";
                txtbox_BirthDate.ForeColor = Color.Black;
            }
        }

        private void txtbox_BirthDate_Leave(object sender, EventArgs e)
        {
            if (txtbox_BirthDate.Text == "")
            {
                txtbox_BirthDate.Text = "Month, Date, Year";
                txtbox_BirthDate.ForeColor = Color.Silver;
            }
        }

        private void txtbox_Gender_Enter(object sender, EventArgs e)
        {
            if (txtbox_Gender.Text == "M/F")
            {
                txtbox_Gender.Text = "";
                txtbox_Gender.ForeColor = Color.Black;
            }
        }

        private void txtbox_Gender_Leave(object sender, EventArgs e)
        {
            if  (txtbox_Gender.Text == "")
            {
                txtbox_Gender.Text = "M/F";
                txtbox_Gender.ForeColor = Color.Silver;
            }
        }

        private void txtbox_Address_Enter(object sender, EventArgs e)
        {
            if (txtbox_Address.Text == "Street, Barangay, City. Province, Zip Code")
            {
                txtbox_Address.Text = "";
                txtbox_Address.ForeColor = Color.Black;
            }
        }

        private void txtbox_Address_Leave(object sender, EventArgs e)
        {
            if (txtbox_Address.Text == "")
            {
                txtbox_Address.Text = "Street, Barangay, City. Province, Zip Code";
                txtbox_Address.ForeColor = Color.Silver;
            }
        }

        private void txtbox_Email_Enter(object sender, EventArgs e)
        {
            if (txtbox_Email.Text == "@mail.com")
            {
                txtbox_Email.Text = "";
                txtbox_Email.ForeColor = Color.Black;
            }
        }

        private void txtbox_Email_Leave(object sender, EventArgs e)
        {
            if (txtbox_Email.Text == "")
            {
                txtbox_Email.Text = "@mail.com";
                txtbox_Email.ForeColor = Color.Silver;
            }
        }

        private void txtbox_Mobile_Enter(object sender, EventArgs e)
        {
            if (txtbox_Mobile.Text == "Mobile No.")
            {
                txtbox_Mobile.Text = "";
                txtbox_Mobile.ForeColor = Color.Black;
            }
        }

        private void txtbox_Mobile_Leave(object sender, EventArgs e)
        {
            if (txtbox_Mobile.Text == "")
            {
                txtbox_Mobile.Text = "Mobile No.";
                txtbox_Mobile.ForeColor = Color.Silver;
            }
        }

        private void txtbox_Travel_Enter(object sender, EventArgs e)
        {
            if (txtbox_Travel.Text == "Yes/No")
            {
                txtbox_Travel.Text = "";
                txtbox_Travel.ForeColor = Color.Black;
            }
        }

        private void txtbox_Travel_Leave(object sender, EventArgs e)
        {
            if (txtbox_Travel.Text == "")
            {
                txtbox_Travel.Text = "Yes/No";
                txtbox_Travel.ForeColor = Color.Silver;
            }
        }

        private void txtbox_Symptoms_Enter(object sender, EventArgs e)
        {
            if (txtbox_Symptoms.Text == "Yes/No")
            {
                txtbox_Symptoms.Text = "";
                txtbox_Symptoms.ForeColor = Color.Black;
            }
        }

        private void txtbox_Symptoms_Leave(object sender, EventArgs e)
        {
            if (txtbox_Symptoms.Text == "")
            {
                txtbox_Symptoms.Text = "Yes/No";
                txtbox_Symptoms.ForeColor = Color.Silver;
            }
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            Admin show = new Admin();
            show.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}