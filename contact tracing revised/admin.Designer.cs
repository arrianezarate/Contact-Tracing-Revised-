namespace contact_tracing_revised
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Admin = new System.Windows.Forms.Label();
            this.txtbox_Username = new System.Windows.Forms.TextBox();
            this.txtbox_Password = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Admin
            // 
            this.lbl_Admin.AutoSize = true;
            this.lbl_Admin.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Admin.ForeColor = System.Drawing.Color.White;
            this.lbl_Admin.Location = new System.Drawing.Point(85, 81);
            this.lbl_Admin.Name = "lbl_Admin";
            this.lbl_Admin.Size = new System.Drawing.Size(267, 60);
            this.lbl_Admin.TabIndex = 1;
            this.lbl_Admin.Text = "ADMIN LOGIN";
            // 
            // txtbox_Username
            // 
            this.txtbox_Username.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtbox_Username.Location = new System.Drawing.Point(527, 71);
            this.txtbox_Username.Name = "txtbox_Username";
            this.txtbox_Username.Size = new System.Drawing.Size(150, 23);
            this.txtbox_Username.TabIndex = 2;
            this.txtbox_Username.Text = "Enter your username";
            this.txtbox_Username.Enter += new System.EventHandler(this.txtbox_Username_Enter);
            this.txtbox_Username.Leave += new System.EventHandler(this.txtbox_Username_Leave);
            // 
            // txtbox_Password
            // 
            this.txtbox_Password.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtbox_Password.Location = new System.Drawing.Point(527, 134);
            this.txtbox_Password.Name = "txtbox_Password";
            this.txtbox_Password.PasswordChar = '•';
            this.txtbox_Password.Size = new System.Drawing.Size(150, 23);
            this.txtbox_Password.TabIndex = 3;
            this.txtbox_Password.Text = "Enter your password";
            this.txtbox_Password.Enter += new System.EventHandler(this.txtbox_Password_Enter);
            this.txtbox_Password.Leave += new System.EventHandler(this.txtbox_Password_Leave);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Username.ForeColor = System.Drawing.Color.White;
            this.lbl_Username.Location = new System.Drawing.Point(416, 71);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(75, 18);
            this.lbl_Username.TabIndex = 4;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Password.ForeColor = System.Drawing.Color.White;
            this.lbl_Password.Location = new System.Drawing.Point(419, 134);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(72, 18);
            this.lbl_Password.TabIndex = 5;
            this.lbl_Password.Text = "Password";
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_LogIn.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_LogIn.ForeColor = System.Drawing.Color.White;
            this.btn_LogIn.Location = new System.Drawing.Point(548, 173);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(97, 32);
            this.btn_LogIn.TabIndex = 6;
            this.btn_LogIn.Text = "LOGIN";
            this.btn_LogIn.UseVisualStyleBackColor = false;
            this.btn_LogIn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(157)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(744, 240);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.txtbox_Password);
            this.Controls.Add(this.txtbox_Username);
            this.Controls.Add(this.lbl_Admin);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Admin;
        private TextBox txtbox_Username;
        private TextBox txtbox_Password;
        private Label lbl_Username;
        private Label lbl_Password;
        private Button btn_LogIn;
    }
}