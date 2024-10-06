using System;
using System.Windows.Forms;

namespace ProjectTask
{
    partial class TeacherDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherDashBoard));
            this.Panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCource = new System.Windows.Forms.Button();
            this.btnclass = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnattendance = new System.Windows.Forms.Button();
            this.btnclasses = new System.Windows.Forms.Button();
            this.btnschedule = new System.Windows.Forms.Button();
            this.btnassignment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAssignment = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSassign = new System.Windows.Forms.Button();
            this.dtpassign = new System.Windows.Forms.DateTimePicker();
            this.lblAdeadline = new System.Windows.Forms.Label();
            this.labelassign = new System.Windows.Forms.Label();
            this.txtassign = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleAssignmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewScheduledItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMicOff = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnAddPeople = new System.Windows.Forms.Button();
            this.ScreenShare = new System.Windows.Forms.Button();
            this.btnMicOn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.Pnlclasscontrol = new System.Windows.Forms.Panel();
            this.Panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelAssignment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Pnlclasscontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel.Controls.Add(this.button8);
            this.Panel.Controls.Add(this.label4);
            this.Panel.Controls.Add(this.label3);
            this.Panel.Controls.Add(this.label2);
            this.Panel.Controls.Add(this.btnCource);
            this.Panel.Controls.Add(this.btnclass);
            this.Panel.Controls.Add(this.button5);
            this.Panel.Controls.Add(this.btnattendance);
            this.Panel.Controls.Add(this.btnclasses);
            this.Panel.Controls.Add(this.btnschedule);
            this.Panel.Controls.Add(this.btnassignment);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(257, 631);
            this.Panel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9.792F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dhiren2324";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "UserID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 42);
            this.label2.TabIndex = 8;
            this.label2.Text = "        Welcome,\r\n Dhirendra Kathayat";
            // 
            // btnCource
            // 
            this.btnCource.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCource.Font = new System.Drawing.Font("Lucida Fax", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCource.Location = new System.Drawing.Point(1, 414);
            this.btnCource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCource.Name = "btnCource";
            this.btnCource.Size = new System.Drawing.Size(246, 33);
            this.btnCource.TabIndex = 7;
            this.btnCource.Text = "Course ";
            this.btnCource.UseVisualStyleBackColor = false;
            // 
            // btnclass
            // 
            this.btnclass.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclass.Font = new System.Drawing.Font("Lucida Fax", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclass.Location = new System.Drawing.Point(1, 451);
            this.btnclass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnclass.Name = "btnclass";
            this.btnclass.Size = new System.Drawing.Size(246, 33);
            this.btnclass.TabIndex = 0;
            this.btnclass.Text = "Create Class";
            this.btnclass.UseVisualStyleBackColor = false;
            this.btnclass.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.Font = new System.Drawing.Font("Maiandra GD", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(0, 583);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(253, 44);
            this.button5.TabIndex = 5;
            this.button5.Text = "Log Out";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnattendance
            // 
            this.btnattendance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnattendance.Font = new System.Drawing.Font("Lucida Fax", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnattendance.Location = new System.Drawing.Point(0, 377);
            this.btnattendance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnattendance.Name = "btnattendance";
            this.btnattendance.Size = new System.Drawing.Size(246, 33);
            this.btnattendance.TabIndex = 4;
            this.btnattendance.Text = "Attendance";
            this.btnattendance.UseVisualStyleBackColor = false;
            this.btnattendance.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnclasses
            // 
            this.btnclasses.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclasses.Font = new System.Drawing.Font("Lucida Fax", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclasses.Location = new System.Drawing.Point(0, 337);
            this.btnclasses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnclasses.Name = "btnclasses";
            this.btnclasses.Size = new System.Drawing.Size(246, 35);
            this.btnclasses.TabIndex = 3;
            this.btnclasses.Text = "Classes";
            this.btnclasses.UseVisualStyleBackColor = false;
            this.btnclasses.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnschedule
            // 
            this.btnschedule.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnschedule.Font = new System.Drawing.Font("Lucida Fax", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnschedule.Location = new System.Drawing.Point(0, 298);
            this.btnschedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnschedule.Name = "btnschedule";
            this.btnschedule.Size = new System.Drawing.Size(246, 34);
            this.btnschedule.TabIndex = 2;
            this.btnschedule.Text = "Scheduling";
            this.btnschedule.UseVisualStyleBackColor = false;
            this.btnschedule.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnassignment
            // 
            this.btnassignment.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnassignment.Font = new System.Drawing.Font("Lucida Fax", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnassignment.Location = new System.Drawing.Point(0, 259);
            this.btnassignment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnassignment.Name = "btnassignment";
            this.btnassignment.Size = new System.Drawing.Size(246, 34);
            this.btnassignment.TabIndex = 1;
            this.btnassignment.Text = "Assignments";
            this.btnassignment.UseVisualStyleBackColor = false;
            this.btnassignment.Click += new System.EventHandler(this.btnassignment_Click);
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(54, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 108);
            this.label1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.Pnlclasscontrol);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(257, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1529, 631);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelAssignment);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1529, 542);
            this.panel1.TabIndex = 6;
            // 
            // panelAssignment
            // 
            this.panelAssignment.Controls.Add(this.dataGridView1);
            this.panelAssignment.Controls.Add(this.btnSassign);
            this.panelAssignment.Controls.Add(this.dtpassign);
            this.panelAssignment.Controls.Add(this.lblAdeadline);
            this.panelAssignment.Controls.Add(this.labelassign);
            this.panelAssignment.Controls.Add(this.txtassign);
            this.panelAssignment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAssignment.Location = new System.Drawing.Point(0, 29);
            this.panelAssignment.Name = "panelAssignment";
            this.panelAssignment.Size = new System.Drawing.Size(1529, 513);
            this.panelAssignment.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(703, 387);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 53;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(451, 198);
            this.dataGridView1.TabIndex = 5;
            // 
            // Col1
            // 
            this.Col1.HeaderText = "Assignment";
            this.Col1.MinimumWidth = 7;
            this.Col1.Name = "Col1";
            this.Col1.Width = 130;
            // 
            // Col2
            // 
            this.Col2.HeaderText = "Deadline";
            this.Col2.MinimumWidth = 7;
            this.Col2.Name = "Col2";
            this.Col2.Width = 130;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "none";
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column1.HeaderText = "Remarks";
            this.Column1.MinimumWidth = 7;
            this.Column1.Name = "Column1";
            this.Column1.Text = "Delete";
            this.Column1.ToolTipText = "Delete";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 130;
            // 
            // btnSassign
            // 
            this.btnSassign.Font = new System.Drawing.Font("Lucida Fax", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSassign.Location = new System.Drawing.Point(733, 212);
            this.btnSassign.Name = "btnSassign";
            this.btnSassign.Size = new System.Drawing.Size(446, 54);
            this.btnSassign.TabIndex = 4;
            this.btnSassign.Text = "Schedule Assignment";
            this.btnSassign.UseVisualStyleBackColor = true;
            this.btnSassign.Click += new System.EventHandler(this.btnSassign_Click);
            // 
            // dtpassign
            // 
            this.dtpassign.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpassign.Font = new System.Drawing.Font("Lucida Fax", 16.128F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpassign.Location = new System.Drawing.Point(650, 151);
            this.dtpassign.Name = "dtpassign";
            this.dtpassign.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpassign.Size = new System.Drawing.Size(581, 40);
            this.dtpassign.TabIndex = 3;
            // 
            // lblAdeadline
            // 
            this.lblAdeadline.AutoSize = true;
            this.lblAdeadline.Font = new System.Drawing.Font("Lucida Fax", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdeadline.Location = new System.Drawing.Point(323, 157);
            this.lblAdeadline.Name = "lblAdeadline";
            this.lblAdeadline.Size = new System.Drawing.Size(280, 27);
            this.lblAdeadline.TabIndex = 2;
            this.lblAdeadline.Text = "Select Deadline Here:";
            // 
            // labelassign
            // 
            this.labelassign.AutoSize = true;
            this.labelassign.Font = new System.Drawing.Font("Lucida Fax", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelassign.Location = new System.Drawing.Point(301, 62);
            this.labelassign.Name = "labelassign";
            this.labelassign.Size = new System.Drawing.Size(309, 27);
            this.labelassign.TabIndex = 1;
            this.labelassign.Text = "Your assignment Here:-";
            // 
            // txtassign
            // 
            this.txtassign.Font = new System.Drawing.Font("Lucida Fax", 17.856F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtassign.Location = new System.Drawing.Point(650, 51);
            this.txtassign.Name = "txtassign";
            this.txtassign.Size = new System.Drawing.Size(581, 44);
            this.txtassign.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(21, 21);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleToolStripMenuItem,
            this.viewScheduledItemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1529, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleClassToolStripMenuItem,
            this.scheduleAssignmentToolStripMenuItem,
            this.scheduleTestToolStripMenuItem});
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.scheduleToolStripMenuItem.Text = "Schedule";
            // 
            // scheduleClassToolStripMenuItem
            // 
            this.scheduleClassToolStripMenuItem.Name = "scheduleClassToolStripMenuItem";
            this.scheduleClassToolStripMenuItem.Size = new System.Drawing.Size(246, 30);
            this.scheduleClassToolStripMenuItem.Text = "Schedule class";
            // 
            // scheduleAssignmentToolStripMenuItem
            // 
            this.scheduleAssignmentToolStripMenuItem.Name = "scheduleAssignmentToolStripMenuItem";
            this.scheduleAssignmentToolStripMenuItem.Size = new System.Drawing.Size(246, 30);
            this.scheduleAssignmentToolStripMenuItem.Text = "Schedule Assignment";
            // 
            // scheduleTestToolStripMenuItem
            // 
            this.scheduleTestToolStripMenuItem.Name = "scheduleTestToolStripMenuItem";
            this.scheduleTestToolStripMenuItem.Size = new System.Drawing.Size(246, 30);
            this.scheduleTestToolStripMenuItem.Text = "Schedule Test";
            // 
            // viewScheduledItemToolStripMenuItem
            // 
            this.viewScheduledItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classToolStripMenuItem,
            this.assignmentToolStripMenuItem,
            this.testToolStripMenuItem});
            this.viewScheduledItemToolStripMenuItem.Name = "viewScheduledItemToolStripMenuItem";
            this.viewScheduledItemToolStripMenuItem.Size = new System.Drawing.Size(173, 25);
            this.viewScheduledItemToolStripMenuItem.Text = "View Scheduled Item ";
            // 
            // classToolStripMenuItem
            // 
            this.classToolStripMenuItem.Name = "classToolStripMenuItem";
            this.classToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.classToolStripMenuItem.Text = "Class";
            // 
            // assignmentToolStripMenuItem
            // 
            this.assignmentToolStripMenuItem.Name = "assignmentToolStripMenuItem";
            this.assignmentToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.assignmentToolStripMenuItem.Text = "Assignment";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // btnMicOff
            // 
            this.btnMicOff.BackColor = System.Drawing.Color.Transparent;
            this.btnMicOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMicOff.Image = ((System.Drawing.Image)(resources.GetObject("btnMicOff.Image")));
            this.btnMicOff.Location = new System.Drawing.Point(428, 15);
            this.btnMicOff.Name = "btnMicOff";
            this.btnMicOff.Size = new System.Drawing.Size(75, 62);
            this.btnMicOff.TabIndex = 5;
            this.btnMicOff.UseVisualStyleBackColor = false;
            this.btnMicOff.Click += new System.EventHandler(this.btnMicOff_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnEnd.Image")));
            this.btnEnd.Location = new System.Drawing.Point(846, 15);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 62);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnAddPeople
            // 
            this.btnAddPeople.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPeople.Image")));
            this.btnAddPeople.Location = new System.Drawing.Point(719, 15);
            this.btnAddPeople.Name = "btnAddPeople";
            this.btnAddPeople.Size = new System.Drawing.Size(76, 62);
            this.btnAddPeople.TabIndex = 3;
            this.btnAddPeople.UseVisualStyleBackColor = true;
            // 
            // ScreenShare
            // 
            this.ScreenShare.Image = ((System.Drawing.Image)(resources.GetObject("ScreenShare.Image")));
            this.ScreenShare.Location = new System.Drawing.Point(570, 15);
            this.ScreenShare.Name = "ScreenShare";
            this.ScreenShare.Size = new System.Drawing.Size(75, 62);
            this.ScreenShare.TabIndex = 2;
            this.ScreenShare.UseVisualStyleBackColor = true;
            this.ScreenShare.Click += new System.EventHandler(this.ScreenShare_Click);
            // 
            // btnMicOn
            // 
            this.btnMicOn.BackColor = System.Drawing.Color.Transparent;
            this.btnMicOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMicOn.Image = ((System.Drawing.Image)(resources.GetObject("btnMicOn.Image")));
            this.btnMicOn.Location = new System.Drawing.Point(428, 15);
            this.btnMicOn.Name = "btnMicOn";
            this.btnMicOn.Size = new System.Drawing.Size(75, 62);
            this.btnMicOn.TabIndex = 1;
            this.btnMicOn.UseVisualStyleBackColor = false;
            this.btnMicOn.Click += new System.EventHandler(this.btnMicOn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1529, 631);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Lucida Fax", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(-2, 489);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(248, 33);
            this.button8.TabIndex = 11;
            this.button8.Text = "Tests";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Pnlclasscontrol
            // 
            this.Pnlclasscontrol.BackColor = System.Drawing.Color.Gainsboro;
            this.Pnlclasscontrol.Controls.Add(this.btnMicOff);
            this.Pnlclasscontrol.Controls.Add(this.btnEnd);
            this.Pnlclasscontrol.Controls.Add(this.btnMicOn);
            this.Pnlclasscontrol.Controls.Add(this.btnAddPeople);
            this.Pnlclasscontrol.Controls.Add(this.ScreenShare);
            this.Pnlclasscontrol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnlclasscontrol.Location = new System.Drawing.Point(0, 542);
            this.Pnlclasscontrol.Name = "Pnlclasscontrol";
            this.Pnlclasscontrol.Size = new System.Drawing.Size(1529, 89);
            this.Pnlclasscontrol.TabIndex = 6;
            // 
            // TeacherDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1786, 631);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TeacherDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TeacherDashBoard_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAssignment.ResumeLayout(false);
            this.panelAssignment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Pnlclasscontrol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        

      

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnattendance;
        private System.Windows.Forms.Button btnclasses;
        private System.Windows.Forms.Button btnschedule;
        private System.Windows.Forms.Button btnassignment;
        private System.Windows.Forms.Button btnclass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnAddPeople;
        private System.Windows.Forms.Button ScreenShare;
        private System.Windows.Forms.Button btnMicOn;
        private System.Windows.Forms.Button btnMicOff;
        private EventHandler setting_Click;
        private PaintEventHandler panel1_Paint;
        private Button btnCource;
        private Label label3;
        private Label label2;
        private Label label4;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem scheduleToolStripMenuItem;
        private ToolStripMenuItem scheduleClassToolStripMenuItem;
        private ToolStripMenuItem scheduleAssignmentToolStripMenuItem;
        private ToolStripMenuItem scheduleTestToolStripMenuItem;
        private ToolStripMenuItem viewScheduledItemToolStripMenuItem;
        private ToolStripMenuItem classToolStripMenuItem;
        private ToolStripMenuItem assignmentToolStripMenuItem;
        private ToolStripMenuItem testToolStripMenuItem;
        private Panel panelAssignment;
        private DateTimePicker dtpassign;
        private Label lblAdeadline;
        private Label labelassign;
        private TextBox txtassign;
        private Button btnSassign;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Col1;
        private DataGridViewTextBoxColumn Col2;
        private DataGridViewButtonColumn Column1;
        private Button button8;
        private Panel Pnlclasscontrol;
    }
}