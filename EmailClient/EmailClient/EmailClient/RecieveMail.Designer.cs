namespace EmailClient
{
    partial class RecieveMail
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
            this.ReciveMailbtn = new System.Windows.Forms.Button();
            this.msgcounglb = new System.Windows.Forms.Label();
            this.Subjectlsbx = new System.Windows.Forms.ListBox();
            this.msgBodytbx = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pgBarMailFetched = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // ReciveMailbtn
            // 
            this.ReciveMailbtn.Location = new System.Drawing.Point(35, 16);
            this.ReciveMailbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReciveMailbtn.Name = "ReciveMailbtn";
            this.ReciveMailbtn.Size = new System.Drawing.Size(100, 28);
            this.ReciveMailbtn.TabIndex = 0;
            this.ReciveMailbtn.Text = "Recive";
            this.ReciveMailbtn.UseVisualStyleBackColor = true;
            this.ReciveMailbtn.Click += new System.EventHandler(this.ReciveMailbtn_Click);
            // 
            // msgcounglb
            // 
            this.msgcounglb.AutoSize = true;
            this.msgcounglb.Location = new System.Drawing.Point(692, 28);
            this.msgcounglb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.msgcounglb.Name = "msgcounglb";
            this.msgcounglb.Size = new System.Drawing.Size(31, 17);
            this.msgcounglb.TabIndex = 3;
            this.msgcounglb.Text = "N/A";
            // 
            // Subjectlsbx
            // 
            this.Subjectlsbx.FormattingEnabled = true;
            this.Subjectlsbx.ItemHeight = 16;
            this.Subjectlsbx.Location = new System.Drawing.Point(16, 52);
            this.Subjectlsbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Subjectlsbx.Name = "Subjectlsbx";
            this.Subjectlsbx.Size = new System.Drawing.Size(199, 452);
            this.Subjectlsbx.TabIndex = 4;
            this.Subjectlsbx.SelectedIndexChanged += new System.EventHandler(this.Subjectlsbx_SelectedIndexChanged);
            // 
            // msgBodytbx
            // 
            this.msgBodytbx.Location = new System.Drawing.Point(224, 52);
            this.msgBodytbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.msgBodytbx.Name = "msgBodytbx";
            this.msgBodytbx.Size = new System.Drawing.Size(552, 452);
            this.msgBodytbx.TabIndex = 5;
            this.msgBodytbx.Text = "";
            // 
            // pgBarMailFetched
            // 
            this.pgBarMailFetched.Location = new System.Drawing.Point(224, 528);
            this.pgBarMailFetched.Name = "pgBarMailFetched";
            this.pgBarMailFetched.Size = new System.Drawing.Size(552, 11);
            this.pgBarMailFetched.TabIndex = 6;
            // 
            // RecieveMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 583);
            this.Controls.Add(this.pgBarMailFetched);
            this.Controls.Add(this.msgBodytbx);
            this.Controls.Add(this.Subjectlsbx);
            this.Controls.Add(this.msgcounglb);
            this.Controls.Add(this.ReciveMailbtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RecieveMail";
            this.Text = "RecieveMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReciveMailbtn;
        private System.Windows.Forms.Label msgcounglb;
        private System.Windows.Forms.ListBox Subjectlsbx;
        private System.Windows.Forms.RichTextBox msgBodytbx;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar pgBarMailFetched;
    }
}