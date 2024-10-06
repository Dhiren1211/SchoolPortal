using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTask
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void linksignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            TeacherSignup New = new TeacherSignup();
            New.Show();
        }
        internal class TeacherS : TeacherSignup { }
        internal class Teacherl : Teacherlogin { }

        private void linklogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Teacherlogin New = new Teacherlogin();  
            New.Show();
        }
    }
}
