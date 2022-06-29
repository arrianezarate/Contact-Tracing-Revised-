namespace contact_tracing_revised
{
    partial class admin_access
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
            this.btn_Open = new System.Windows.Forms.Button();
            this.lbl_AllRecords = new System.Windows.Forms.Label();
            this.pnl_AllRecords = new System.Windows.Forms.Panel();
            this.SelectDate = new System.Windows.Forms.DateTimePicker();
            this.pnl_SelectDate = new System.Windows.Forms.Panel();
            this.lbl_ByDate = new System.Windows.Forms.Label();
            this.btn_Check = new System.Windows.Forms.Button();
            this.pnl_AllRecords.SuspendLayout();
            this.pnl_SelectDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Open
            // 
            this.btn_Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(157)))), ((int)(((byte)(192)))));
            this.btn_Open.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Open.ForeColor = System.Drawing.Color.White;
            this.btn_Open.Location = new System.Drawing.Point(40, 12);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(135, 49);
            this.btn_Open.TabIndex = 0;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = false;
            this.btn_Open.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_AllRecords
            // 
            this.lbl_AllRecords.AutoSize = true;
            this.lbl_AllRecords.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_AllRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(157)))), ((int)(((byte)(192)))));
            this.lbl_AllRecords.Location = new System.Drawing.Point(51, 76);
            this.lbl_AllRecords.Name = "lbl_AllRecords";
            this.lbl_AllRecords.Size = new System.Drawing.Size(111, 24);
            this.lbl_AllRecords.TabIndex = 1;
            this.lbl_AllRecords.Text = "All records";
            this.lbl_AllRecords.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnl_AllRecords
            // 
            this.pnl_AllRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(234)))), ((int)(((byte)(140)))));
            this.pnl_AllRecords.Controls.Add(this.lbl_AllRecords);
            this.pnl_AllRecords.Controls.Add(this.btn_Open);
            this.pnl_AllRecords.Location = new System.Drawing.Point(211, 12);
            this.pnl_AllRecords.Name = "pnl_AllRecords";
            this.pnl_AllRecords.Size = new System.Drawing.Size(216, 125);
            this.pnl_AllRecords.TabIndex = 2;
            // 
            // SelectDate
            // 
            this.SelectDate.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectDate.Location = new System.Drawing.Point(14, 57);
            this.SelectDate.Name = "SelectDate";
            this.SelectDate.Size = new System.Drawing.Size(230, 27);
            this.SelectDate.TabIndex = 3;
            // 
            // pnl_SelectDate
            // 
            this.pnl_SelectDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(234)))), ((int)(((byte)(140)))));
            this.pnl_SelectDate.Controls.Add(this.lbl_ByDate);
            this.pnl_SelectDate.Controls.Add(this.btn_Check);
            this.pnl_SelectDate.Controls.Add(this.SelectDate);
            this.pnl_SelectDate.Location = new System.Drawing.Point(91, 210);
            this.pnl_SelectDate.Name = "pnl_SelectDate";
            this.pnl_SelectDate.Size = new System.Drawing.Size(453, 141);
            this.pnl_SelectDate.TabIndex = 3;
            // 
            // lbl_ByDate
            // 
            this.lbl_ByDate.AutoSize = true;
            this.lbl_ByDate.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ByDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(157)))), ((int)(((byte)(192)))));
            this.lbl_ByDate.Location = new System.Drawing.Point(256, 87);
            this.lbl_ByDate.Name = "lbl_ByDate";
            this.lbl_ByDate.Size = new System.Drawing.Size(177, 24);
            this.lbl_ByDate.TabIndex = 2;
            this.lbl_ByDate.Text = "Records (by date)";
            this.lbl_ByDate.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(157)))), ((int)(((byte)(192)))));
            this.btn_Check.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Check.ForeColor = System.Drawing.Color.White;
            this.btn_Check.Location = new System.Drawing.Point(278, 35);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(135, 49);
            this.btn_Check.TabIndex = 2;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = false;
            // 
            // admin_access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(631, 405);
            this.Controls.Add(this.pnl_SelectDate);
            this.Controls.Add(this.pnl_AllRecords);
            this.Name = "admin_access";
            this.Text = "Admin Access";
            this.pnl_AllRecords.ResumeLayout(false);
            this.pnl_AllRecords.PerformLayout();
            this.pnl_SelectDate.ResumeLayout(false);
            this.pnl_SelectDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Open;
        private Label lbl_AllRecords;
        private Panel pnl_AllRecords;
        private DateTimePicker SelectDate;
        private Panel pnl_SelectDate;
        private Label lbl_ByDate;
        private Button btn_Check;
    }
}