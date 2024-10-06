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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void linklogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Studentlogin New = new Studentlogin();
            New.Show();
        }
        internal class Login : Studentlogin { }
        internal class Signup :StudentSignup { }    
        private void linksignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            StudentSignup New = new StudentSignup();
            New.Show();
        }
    }
}
