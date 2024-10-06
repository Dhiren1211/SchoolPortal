namespace ProjectTask.Admin
{
    partial class Reports
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbackward = new System.Windows.Forms.Button();
            this.btnforward = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1389, 773);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 53;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1389, 773);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnforward);
            this.panel2.Controls.Add(this.btnbackward);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1389, 97);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 13.824F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(746, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Reports !!";
            // 
            // btnbackward
            // 
            this.btnbackward.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnbackward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbackward.Font = new System.Drawing.Font("Lucida Fax", 20.16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackward.Location = new System.Drawing.Point(0, 0);
            this.btnbackward.Name = "btnbackward";
            this.btnbackward.Size = new System.Drawing.Size(50, 97);
            this.btnbackward.TabIndex = 1;
            this.btnbackward.Text = "«";
            this.btnbackward.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbackward.UseVisualStyleBackColor = true;
            this.btnbackward.Click += new System.EventHandler(this.btnbackward_Click);
            // 
            // btnforward
            // 
            this.btnforward.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnforward.Font = new System.Drawing.Font("Lucida Fax", 20.16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnforward.Location = new System.Drawing.Point(1337, 0);
            this.btnforward.Name = "btnforward";
            this.btnforward.Size = new System.Drawing.Size(52, 97);
            this.btnforward.TabIndex = 2;
            this.btnforward.Text = "»";
            this.btnforward.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnforward.UseVisualStyleBackColor = true;
            this.btnforward.Click += new System.EventHandler(this.btnforward_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 773);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.Text = "Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnbackward;
        private System.Windows.Forms.Button btnforward;
    }
}