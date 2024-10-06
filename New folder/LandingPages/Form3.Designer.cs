namespace ProjectTask
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.panelbody = new System.Windows.Forms.Panel();
            this.panelfooter = new System.Windows.Forms.Panel();
            this.linklogin = new System.Windows.Forms.LinkLabel();
            this.logintxt = new System.Windows.Forms.Label();
            this.signuptxt = new System.Windows.Forms.Label();
            this.linksignup = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.scllogo = new System.Windows.Forms.PictureBox();
            this.wlctxt = new System.Windows.Forms.Label();
            this.panelbody.SuspendLayout();
            this.panelfooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scllogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelbody
            // 
            this.panelbody.Controls.Add(this.panelfooter);
            this.panelbody.Controls.Add(this.label4);
            this.panelbody.Controls.Add(this.scllogo);
            this.panelbody.Controls.Add(this.wlctxt);
            this.panelbody.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelbody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelbody.Location = new System.Drawing.Point(0, 0);
            this.panelbody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelbody.Name = "panelbody";
            this.panelbody.Size = new System.Drawing.Size(1188, 498);
            this.panelbody.TabIndex = 2;
            // 
            // panelfooter
            // 
            this.panelfooter.Controls.Add(this.linklogin);
            this.panelfooter.Controls.Add(this.logintxt);
            this.panelfooter.Controls.Add(this.signuptxt);
            this.panelfooter.Controls.Add(this.linksignup);
            this.panelfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelfooter.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelfooter.Location = new System.Drawing.Point(0, 452);
            this.panelfooter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelfooter.Name = "panelfooter";
            this.panelfooter.Size = new System.Drawing.Size(1188, 46);
            this.panelfooter.TabIndex = 7;
            // 
            // linklogin
            // 
            this.linklogin.AutoSize = true;
            this.linklogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.linklogin.Font = new System.Drawing.Font("Maiandra GD", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklogin.Location = new System.Drawing.Point(138, 0);
            this.linklogin.Name = "linklogin";
            this.linklogin.Size = new System.Drawing.Size(68, 25);
            this.linklogin.TabIndex = 2;
            this.linklogin.TabStop = true;
            this.linklogin.Text = "Login";
            this.linklogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklogin_LinkClicked);
            // 
            // logintxt
            // 
            this.logintxt.AutoSize = true;
            this.logintxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.logintxt.Font = new System.Drawing.Font("Maiandra GD", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintxt.Location = new System.Drawing.Point(0, 0);
            this.logintxt.Name = "logintxt";
            this.logintxt.Size = new System.Drawing.Size(138, 25);
            this.logintxt.TabIndex = 1;
            this.logintxt.Text = "Login Here!!";
            // 
            // signuptxt
            // 
            this.signuptxt.AutoSize = true;
            this.signuptxt.Dock = System.Windows.Forms.DockStyle.Right;
            this.signuptxt.Font = new System.Drawing.Font("Maiandra GD", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signuptxt.Location = new System.Drawing.Point(941, 0);
            this.signuptxt.Name = "signuptxt";
            this.signuptxt.Size = new System.Drawing.Size(148, 25);
            this.signuptxt.TabIndex = 3;
            this.signuptxt.Text = "Signup Here!!";
            // 
            // linksignup
            // 
            this.linksignup.AutoSize = true;
            this.linksignup.Dock = System.Windows.Forms.DockStyle.Right;
            this.linksignup.Font = new System.Drawing.Font("Maiandra GD", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linksignup.Location = new System.Drawing.Point(1089, 0);
            this.linksignup.Name = "linksignup";
            this.linksignup.Size = new System.Drawing.Size(99, 25);
            this.linksignup.TabIndex = 4;
            this.linksignup.TabStop = true;
            this.linksignup.Text = "Signup   ";
            this.linksignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linksignup_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Jokerman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(846, 41);
            this.label4.TabIndex = 6;
            this.label4.Text = "POWERED BY BUDHANILKANTHA SECONDARY SCHOOL";
            // 
            // scllogo
            // 
            this.scllogo.Image = ((System.Drawing.Image)(resources.GetObject("scllogo.Image")));
            this.scllogo.Location = new System.Drawing.Point(440, 126);
            this.scllogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scllogo.Name = "scllogo";
            this.scllogo.Size = new System.Drawing.Size(235, 176);
            this.scllogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scllogo.TabIndex = 5;
            this.scllogo.TabStop = false;
            // 
            // wlctxt
            // 
            this.wlctxt.AutoSize = true;
            this.wlctxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.wlctxt.Font = new System.Drawing.Font("Snap ITC", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wlctxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.wlctxt.Location = new System.Drawing.Point(0, 0);
            this.wlctxt.Name = "wlctxt";
            this.wlctxt.Size = new System.Drawing.Size(788, 120);
            this.wlctxt.TabIndex = 0;
            this.wlctxt.Text = "       Welcome \r\n                   Dear Student";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 498);
            this.Controls.Add(this.panelbody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Student";
            this.panelbody.ResumeLayout(false);
            this.panelbody.PerformLayout();
            this.panelfooter.ResumeLayout(false);
            this.panelfooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scllogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelbody;
        private System.Windows.Forms.Panel panelfooter;
        private System.Windows.Forms.LinkLabel linklogin;
        private System.Windows.Forms.Label logintxt;
        private System.Windows.Forms.Label signuptxt;
        private System.Windows.Forms.LinkLabel linksignup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox scllogo;
        private System.Windows.Forms.Label wlctxt;
    }
}