namespace contact_tracing_revised
{
    partial class by_date
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
            this.lbl_Recordsbydate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Recordsbydate
            // 
            this.lbl_Recordsbydate.AutoSize = true;
            this.lbl_Recordsbydate.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Recordsbydate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(157)))), ((int)(((byte)(192)))));
            this.lbl_Recordsbydate.Location = new System.Drawing.Point(21, 20);
            this.lbl_Recordsbydate.Name = "lbl_Recordsbydate";
            this.lbl_Recordsbydate.Size = new System.Drawing.Size(163, 23);
            this.lbl_Recordsbydate.TabIndex = 3;
            this.lbl_Recordsbydate.Text = "Records (by date)\r\n";
            // 
            // by_date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(221)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Recordsbydate);
            this.Name = "by_date";
            this.Text = "By Date";
            this.Load += new System.EventHandler(this.by_date_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Recordsbydate;
    }
}