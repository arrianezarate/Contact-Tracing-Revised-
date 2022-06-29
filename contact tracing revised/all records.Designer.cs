namespace contact_tracing_revised
{
    partial class all_records
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
            this.lbl_Allrecords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Allrecords
            // 
            this.lbl_Allrecords.AutoSize = true;
            this.lbl_Allrecords.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Allrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(157)))), ((int)(((byte)(192)))));
            this.lbl_Allrecords.Location = new System.Drawing.Point(21, 23);
            this.lbl_Allrecords.Name = "lbl_Allrecords";
            this.lbl_Allrecords.Size = new System.Drawing.Size(98, 23);
            this.lbl_Allrecords.TabIndex = 2;
            this.lbl_Allrecords.Text = "All records\r\n";
            // 
            // all_records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Allrecords);
            this.Name = "all_records";
            this.Text = "All Records";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Allrecords;
    }
}