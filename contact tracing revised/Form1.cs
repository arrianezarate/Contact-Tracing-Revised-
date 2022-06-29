namespace contact_tracing_revised
{
    public partial class ContactTracingForm : Form
    {
        public ContactTracingForm()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\arriane\source\repos\contact tracing revised\lists\" + txtbox_LastName.Text + ", " + txtbox_FirstName.Text + ", " + txtbox_MiddleName.Text + ".txt", true);
            file.WriteLine("First name - " + txtbox_FirstName.Text);
            file.WriteLine("Middle name - " + txtbox_MiddleName.Text);
            file.WriteLine("Last name - " + txtbox_LastName.Text);
            file.WriteLine("Age - " + txtbox_Age.Text);
            file.WriteLine("Birth date - " + txtbox_BirthDate.Text);
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


            txtbox_FirstName.Text = "First name";
            txtbox_FirstName.ForeColor = Color.Silver;
            txtbox_MiddleName.Text = "Leave it blank if none";
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
    }
}