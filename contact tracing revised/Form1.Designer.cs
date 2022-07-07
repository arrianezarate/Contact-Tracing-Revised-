namespace contact_tracing_revised
{
    partial class ContactTracingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.lbl_ContactTracing = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_MiddleName = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.lbl_BirthDate = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.txtbox_FirstName = new System.Windows.Forms.TextBox();
            this.txtbox_Gender = new System.Windows.Forms.TextBox();
            this.txtbox_BirthDate = new System.Windows.Forms.TextBox();
            this.txtbox_Age = new System.Windows.Forms.TextBox();
            this.txtbox_LastName = new System.Windows.Forms.TextBox();
            this.txtbox_MiddleName = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Mobile = new System.Windows.Forms.Label();
            this.lbl_Travel = new System.Windows.Forms.Label();
            this.lbl_Symptoms = new System.Windows.Forms.Label();
            this.txtbox_Address = new System.Windows.Forms.TextBox();
            this.txtbox_Email = new System.Windows.Forms.TextBox();
            this.txtbox_Mobile = new System.Windows.Forms.TextBox();
            this.txtbox_Travel = new System.Windows.Forms.TextBox();
            this.txtbox_Symptoms = new System.Windows.Forms.TextBox();
            this.btn_Finish = new System.Windows.Forms.Button();
            this.formDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_Cam = new System.Windows.Forms.Label();
            this.combox_Cam = new System.Windows.Forms.ComboBox();
            this.picbox_Cam = new System.Windows.Forms.PictureBox();
            this.txtbox_DisplayTxt = new System.Windows.Forms.TextBox();
            this.lbl_DisplayTxt = new System.Windows.Forms.Label();
            this.btn_Scan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Cam)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(195)))), ((int)(((byte)(64)))));
            this.pnl_bottom.Controls.Add(this.btn_Admin);
            this.pnl_bottom.Controls.Add(this.lbl_ContactTracing);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 781);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(787, 83);
            this.pnl_bottom.TabIndex = 0;
            // 
            // btn_Admin
            // 
            this.btn_Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.btn_Admin.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Admin.ForeColor = System.Drawing.Color.White;
            this.btn_Admin.Location = new System.Drawing.Point(538, 0);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(165, 83);
            this.btn_Admin.TabIndex = 1;
            this.btn_Admin.Text = "Admin";
            this.btn_Admin.UseVisualStyleBackColor = false;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // lbl_ContactTracing
            // 
            this.lbl_ContactTracing.AutoSize = true;
            this.lbl_ContactTracing.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ContactTracing.ForeColor = System.Drawing.Color.White;
            this.lbl_ContactTracing.Location = new System.Drawing.Point(55, 14);
            this.lbl_ContactTracing.Name = "lbl_ContactTracing";
            this.lbl_ContactTracing.Size = new System.Drawing.Size(370, 60);
            this.lbl_ContactTracing.TabIndex = 0;
            this.lbl_ContactTracing.Text = "CONTACT TRACING";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_FirstName.ForeColor = System.Drawing.Color.White;
            this.lbl_FirstName.Location = new System.Drawing.Point(28, 64);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(80, 18);
            this.lbl_FirstName.TabIndex = 1;
            this.lbl_FirstName.Text = "First Name";
            // 
            // lbl_MiddleName
            // 
            this.lbl_MiddleName.AutoSize = true;
            this.lbl_MiddleName.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_MiddleName.ForeColor = System.Drawing.Color.White;
            this.lbl_MiddleName.Location = new System.Drawing.Point(28, 105);
            this.lbl_MiddleName.Name = "lbl_MiddleName";
            this.lbl_MiddleName.Size = new System.Drawing.Size(96, 18);
            this.lbl_MiddleName.TabIndex = 2;
            this.lbl_MiddleName.Text = "Middle Name";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_LastName.ForeColor = System.Drawing.Color.White;
            this.lbl_LastName.Location = new System.Drawing.Point(28, 144);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(80, 18);
            this.lbl_LastName.TabIndex = 3;
            this.lbl_LastName.Text = "Last Name";
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Age.ForeColor = System.Drawing.Color.White;
            this.lbl_Age.Location = new System.Drawing.Point(28, 187);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(35, 18);
            this.lbl_Age.TabIndex = 4;
            this.lbl_Age.Text = "Age";
            // 
            // lbl_BirthDate
            // 
            this.lbl_BirthDate.AutoSize = true;
            this.lbl_BirthDate.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_BirthDate.ForeColor = System.Drawing.Color.White;
            this.lbl_BirthDate.Location = new System.Drawing.Point(28, 230);
            this.lbl_BirthDate.Name = "lbl_BirthDate";
            this.lbl_BirthDate.Size = new System.Drawing.Size(76, 18);
            this.lbl_BirthDate.TabIndex = 5;
            this.lbl_BirthDate.Text = "Birth Date";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Gender.ForeColor = System.Drawing.Color.White;
            this.lbl_Gender.Location = new System.Drawing.Point(28, 271);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(57, 18);
            this.lbl_Gender.TabIndex = 6;
            this.lbl_Gender.Text = "Gender";
            // 
            // txtbox_FirstName
            // 
            this.txtbox_FirstName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtbox_FirstName.Location = new System.Drawing.Point(144, 64);
            this.txtbox_FirstName.Name = "txtbox_FirstName";
            this.txtbox_FirstName.Size = new System.Drawing.Size(131, 23);
            this.txtbox_FirstName.TabIndex = 7;
            this.txtbox_FirstName.Text = "First Name";
            this.txtbox_FirstName.Enter += new System.EventHandler(this.txtbox_FirstName_Enter);
            this.txtbox_FirstName.Leave += new System.EventHandler(this.txtbox_FirstName_Leave);
            // 
            // txtbox_Gender
            // 
            this.txtbox_Gender.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtbox_Gender.Location = new System.Drawing.Point(144, 266);
            this.txtbox_Gender.Name = "txtbox_Gender";
            this.txtbox_Gender.Size = new System.Drawing.Size(75, 23);
            this.txtbox_Gender.TabIndex = 8;
            this.txtbox_Gender.Text = "M/F";
            this.txtbox_Gender.Enter += new System.EventHandler(this.txtbox_Gender_Enter);
            this.txtbox_Gender.Leave += new System.EventHandler(this.txtbox_Gender_Leave);
            // 
            // txtbox_BirthDate
            // 
            this.txtbox_BirthDate.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtbox_BirthDate.Location = new System.Drawing.Point(144, 225);
            this.txtbox_BirthDate.Name = "txtbox_BirthDate";
            this.txtbox_BirthDate.Size = new System.Drawing.Size(122, 23);
            this.txtbox_BirthDate.TabIndex = 9;
            this.txtbox_BirthDate.Text = "Month, Date, Year";
            this.txtbox_BirthDate.Enter += new System.EventHandler(this.txtbox_BirthDate_Enter);
            this.txtbox_BirthDate.Leave += new System.EventHandler(this.txtbox_BirthDate_Leave);
            // 
            // txtbox_Age
            // 
            this.txtbox_Age.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtbox_Age.Location = new System.Drawing.Point(144, 182);
            this.txtbox_Age.Name = "txtbox_Age";
            this.txtbox_Age.Size = new System.Drawing.Size(44, 23);
            this.txtbox_Age.TabIndex = 10;
            this.txtbox_Age.Text = "Age";
            this.txtbox_Age.Enter += new System.EventHandler(this.txtbox_Age_Enter);
            this.txtbox_Age.Leave += new System.EventHandler(this.txtbox_Age_Leave);
            // 
            // txtbox_LastName
            // 
            this.txtbox_LastName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtbox_LastName.Location = new System.Drawing.Point(144, 144);
            this.txtbox_LastName.Name = "txtbox_LastName";
            this.txtbox_LastName.Size = new System.Drawing.Size(131, 23);
            this.txtbox_LastName.TabIndex = 11;
            this.txtbox_LastName.Text = "Last Name";
            this.txtbox_LastName.Enter += new System.EventHandler(this.txtbox_LastName_Enter);
            this.txtbox_LastName.Leave += new System.EventHandler(this.txtbox_LastName_Leave);
            // 
            // txtbox_MiddleName
            // 
            this.txtbox_MiddleName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtbox_MiddleName.Location = new System.Drawing.Point(144, 105);
            this.txtbox_MiddleName.Name = "txtbox_MiddleName";
            this.txtbox_MiddleName.Size = new System.Drawing.Size(131, 23);
            this.txtbox_MiddleName.TabIndex = 12;
            this.txtbox_MiddleName.Text = "NA";
            this.txtbox_MiddleName.Enter += new System.EventHandler(this.txtbox_MiddleName_Enter);
            this.txtbox_MiddleName.Leave += new System.EventHandler(this.txtbox_MiddleName_Leave);
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Address.ForeColor = System.Drawing.Color.White;
            this.lbl_Address.Location = new System.Drawing.Point(328, 69);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(60, 18);
            this.lbl_Address.TabIndex = 13;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Email.ForeColor = System.Drawing.Color.White;
            this.lbl_Email.Location = new System.Drawing.Point(328, 105);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(45, 18);
            this.lbl_Email.TabIndex = 14;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Mobile
            // 
            this.lbl_Mobile.AutoSize = true;
            this.lbl_Mobile.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Mobile.ForeColor = System.Drawing.Color.White;
            this.lbl_Mobile.Location = new System.Drawing.Point(328, 144);
            this.lbl_Mobile.Name = "lbl_Mobile";
            this.lbl_Mobile.Size = new System.Drawing.Size(76, 18);
            this.lbl_Mobile.TabIndex = 15;
            this.lbl_Mobile.Text = "Mobile No.";
            // 
            // lbl_Travel
            // 
            this.lbl_Travel.AutoSize = true;
            this.lbl_Travel.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Travel.ForeColor = System.Drawing.Color.White;
            this.lbl_Travel.Location = new System.Drawing.Point(328, 187);
            this.lbl_Travel.Name = "lbl_Travel";
            this.lbl_Travel.Size = new System.Drawing.Size(161, 18);
            this.lbl_Travel.TabIndex = 16;
            this.lbl_Travel.Text = "Did you travel recently?";
            // 
            // lbl_Symptoms
            // 
            this.lbl_Symptoms.AutoSize = true;
            this.lbl_Symptoms.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Symptoms.ForeColor = System.Drawing.Color.White;
            this.lbl_Symptoms.Location = new System.Drawing.Point(328, 225);
            this.lbl_Symptoms.Name = "lbl_Symptoms";
            this.lbl_Symptoms.Size = new System.Drawing.Size(289, 36);
            this.lbl_Symptoms.TabIndex = 17;
            this.lbl_Symptoms.Text = "Do you experience symptoms of COVID-19?\r\n(Flu, Cough, Runny nose, etc.)\r\n";
            // 
            // txtbox_Address
            // 
            this.txtbox_Address.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtbox_Address.Location = new System.Drawing.Point(410, 64);
            this.txtbox_Address.Name = "txtbox_Address";
            this.txtbox_Address.Size = new System.Drawing.Size(363, 23);
            this.txtbox_Address.TabIndex = 18;
            this.txtbox_Address.Text = "Street, Barangay, City. Province, Zip Code";
            this.txtbox_Address.Enter += new System.EventHandler(this.txtbox_Address_Enter);
            this.txtbox_Address.Leave += new System.EventHandler(this.txtbox_Address_Leave);
            // 
            // txtbox_Email
            // 
            this.txtbox_Email.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtbox_Email.Location = new System.Drawing.Point(410, 105);
            this.txtbox_Email.Name = "txtbox_Email";
            this.txtbox_Email.Size = new System.Drawing.Size(184, 23);
            this.txtbox_Email.TabIndex = 19;
            this.txtbox_Email.Text = "@mail.com";
            this.txtbox_Email.Enter += new System.EventHandler(this.txtbox_Email_Enter);
            this.txtbox_Email.Leave += new System.EventHandler(this.txtbox_Email_Leave);
            // 
            // txtbox_Mobile
            // 
            this.txtbox_Mobile.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtbox_Mobile.Location = new System.Drawing.Point(410, 144);
            this.txtbox_Mobile.Name = "txtbox_Mobile";
            this.txtbox_Mobile.Size = new System.Drawing.Size(131, 23);
            this.txtbox_Mobile.TabIndex = 20;
            this.txtbox_Mobile.Text = "Mobile No.";
            this.txtbox_Mobile.Enter += new System.EventHandler(this.txtbox_Mobile_Enter);
            this.txtbox_Mobile.Leave += new System.EventHandler(this.txtbox_Mobile_Leave);
            // 
            // txtbox_Travel
            // 
            this.txtbox_Travel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtbox_Travel.Location = new System.Drawing.Point(495, 182);
            this.txtbox_Travel.Name = "txtbox_Travel";
            this.txtbox_Travel.Size = new System.Drawing.Size(46, 23);
            this.txtbox_Travel.TabIndex = 21;
            this.txtbox_Travel.Text = "Yes/No";
            this.txtbox_Travel.Enter += new System.EventHandler(this.txtbox_Travel_Enter);
            this.txtbox_Travel.Leave += new System.EventHandler(this.txtbox_Travel_Leave);
            // 
            // txtbox_Symptoms
            // 
            this.txtbox_Symptoms.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtbox_Symptoms.Location = new System.Drawing.Point(623, 225);
            this.txtbox_Symptoms.Name = "txtbox_Symptoms";
            this.txtbox_Symptoms.Size = new System.Drawing.Size(44, 23);
            this.txtbox_Symptoms.TabIndex = 22;
            this.txtbox_Symptoms.Text = "Yes/No";
            this.txtbox_Symptoms.Enter += new System.EventHandler(this.txtbox_Symptoms_Enter);
            this.txtbox_Symptoms.Leave += new System.EventHandler(this.txtbox_Symptoms_Leave);
            // 
            // btn_Finish
            // 
            this.btn_Finish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.btn_Finish.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Finish.ForeColor = System.Drawing.Color.White;
            this.btn_Finish.Location = new System.Drawing.Point(621, 302);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(152, 51);
            this.btn_Finish.TabIndex = 2;
            this.btn_Finish.Text = "Finish";
            this.btn_Finish.UseVisualStyleBackColor = false;
            this.btn_Finish.Click += new System.EventHandler(this.btn_Finish_Click);
            // 
            // formDate
            // 
            this.formDate.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formDate.Location = new System.Drawing.Point(524, 22);
            this.formDate.Name = "formDate";
            this.formDate.Size = new System.Drawing.Size(249, 24);
            this.formDate.TabIndex = 23;
            // 
            // lbl_Cam
            // 
            this.lbl_Cam.AutoSize = true;
            this.lbl_Cam.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cam.ForeColor = System.Drawing.Color.White;
            this.lbl_Cam.Location = new System.Drawing.Point(460, 377);
            this.lbl_Cam.Name = "lbl_Cam";
            this.lbl_Cam.Size = new System.Drawing.Size(61, 18);
            this.lbl_Cam.TabIndex = 24;
            this.lbl_Cam.Text = "Camera";
            this.lbl_Cam.Click += new System.EventHandler(this.label1_Click);
            // 
            // combox_Cam
            // 
            this.combox_Cam.BackColor = System.Drawing.SystemColors.Info;
            this.combox_Cam.FormattingEnabled = true;
            this.combox_Cam.Location = new System.Drawing.Point(460, 398);
            this.combox_Cam.Name = "combox_Cam";
            this.combox_Cam.Size = new System.Drawing.Size(235, 23);
            this.combox_Cam.TabIndex = 25;
            // 
            // picbox_Cam
            // 
            this.picbox_Cam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.picbox_Cam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox_Cam.Location = new System.Drawing.Point(460, 427);
            this.picbox_Cam.Name = "picbox_Cam";
            this.picbox_Cam.Size = new System.Drawing.Size(285, 241);
            this.picbox_Cam.TabIndex = 26;
            this.picbox_Cam.TabStop = false;
            // 
            // txtbox_DisplayTxt
            // 
            this.txtbox_DisplayTxt.Location = new System.Drawing.Point(55, 427);
            this.txtbox_DisplayTxt.Multiline = true;
            this.txtbox_DisplayTxt.Name = "txtbox_DisplayTxt";
            this.txtbox_DisplayTxt.Size = new System.Drawing.Size(349, 277);
            this.txtbox_DisplayTxt.TabIndex = 27;
            // 
            // lbl_DisplayTxt
            // 
            this.lbl_DisplayTxt.AutoSize = true;
            this.lbl_DisplayTxt.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_DisplayTxt.ForeColor = System.Drawing.Color.White;
            this.lbl_DisplayTxt.Location = new System.Drawing.Point(55, 403);
            this.lbl_DisplayTxt.Name = "lbl_DisplayTxt";
            this.lbl_DisplayTxt.Size = new System.Drawing.Size(122, 18);
            this.lbl_DisplayTxt.TabIndex = 28;
            this.lbl_DisplayTxt.Text = "Decoded QrCode";
            // 
            // btn_Scan
            // 
            this.btn_Scan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.btn_Scan.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Scan.ForeColor = System.Drawing.Color.White;
            this.btn_Scan.Location = new System.Drawing.Point(99, 710);
            this.btn_Scan.Name = "btn_Scan";
            this.btn_Scan.Size = new System.Drawing.Size(265, 51);
            this.btn_Scan.TabIndex = 29;
            this.btn_Scan.Text = "Start Camera";
            this.btn_Scan.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.button1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(545, 674);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 46);
            this.button1.TabIndex = 30;
            this.button1.Text = "AutoFill";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ContactTracingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(215)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(787, 864);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Scan);
            this.Controls.Add(this.lbl_DisplayTxt);
            this.Controls.Add(this.txtbox_DisplayTxt);
            this.Controls.Add(this.picbox_Cam);
            this.Controls.Add(this.combox_Cam);
            this.Controls.Add(this.lbl_Cam);
            this.Controls.Add(this.formDate);
            this.Controls.Add(this.btn_Finish);
            this.Controls.Add(this.txtbox_Symptoms);
            this.Controls.Add(this.txtbox_Travel);
            this.Controls.Add(this.txtbox_Mobile);
            this.Controls.Add(this.txtbox_Email);
            this.Controls.Add(this.txtbox_Address);
            this.Controls.Add(this.lbl_Symptoms);
            this.Controls.Add(this.lbl_Travel);
            this.Controls.Add(this.lbl_Mobile);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.txtbox_MiddleName);
            this.Controls.Add(this.txtbox_LastName);
            this.Controls.Add(this.txtbox_Age);
            this.Controls.Add(this.txtbox_BirthDate);
            this.Controls.Add(this.txtbox_Gender);
            this.Controls.Add(this.txtbox_FirstName);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_BirthDate);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.lbl_MiddleName);
            this.Controls.Add(this.lbl_FirstName);
            this.Controls.Add(this.pnl_bottom);
            this.Name = "ContactTracingForm";
            this.Text = "Contact Tracing";
            this.pnl_bottom.ResumeLayout(false);
            this.pnl_bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Cam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnl_bottom;
        private Button btn_Admin;
        private Label lbl_ContactTracing;
        private Label lbl_FirstName;
        private Label lbl_MiddleName;
        private Label lbl_LastName;
        private Label lbl_Age;
        private Label lbl_BirthDate;
        private Label lbl_Gender;
        private TextBox txtbox_FirstName;
        private TextBox txtbox_Gender;
        private TextBox txtbox_BirthDate;
        private TextBox txtbox_Age;
        private TextBox txtbox_LastName;
        private TextBox txtbox_MiddleName;
        private Label lbl_Address;
        private Label lbl_Email;
        private Label lbl_Mobile;
        private Label lbl_Travel;
        private Label lbl_Symptoms;
        private TextBox txtbox_Address;
        private TextBox txtbox_Email;
        private TextBox txtbox_Mobile;
        private TextBox txtbox_Travel;
        private TextBox txtbox_Symptoms;
        private Button btn_Finish;
        private DateTimePicker formDate;
        private Label lbl_Cam;
        private ComboBox combox_Cam;
        private PictureBox picbox_Cam;
        private TextBox txtbox_DisplayTxt;
        private Label lbl_DisplayTxt;
        private Button btn_Scan;
        private Button button1;
    }
}