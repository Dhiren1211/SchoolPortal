using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTask
{
    public partial class Teacherlogin : Form
    {
        public string UId { get; set; }
        public string Pass { get; set; }
        public Teacherlogin()
        {
            InitializeComponent();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            TeacherSignup teacherSignup = new TeacherSignup();
            teacherSignup.Show();
        }
        internal class signup : TeacherSignup { }

        private void button1_Click(object sender, EventArgs e)
        {
            
            UId = textBox1.Text;
            Pass = textBox2.Text;
            if (UId == "Admin" && Pass == "AdminPassword") 
            {

                this.Hide();
                AdminDashBoard New = new AdminDashBoard();
                New.Show();
            }
            else if(UId == "" || Pass == "")
            {
                if(UId == "")
                {
                    MessageBox.Show("please Enter your UserID!!");    
                }
                else
                {
                    MessageBox.Show("please Enter your Password!!");
                }
                  
            }
            else
            {
                string constring = "Data Source=DESKTOP-DHIREN;Initial Catalog=OnlineTeachingPortal;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
                string Query1 = "SELECT COUNT(*) FROM TeacherSignup WHERE UserID = @value1 AND TPassword = @value2;";
                int n = 0;
                try
                {
                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(Query1, con))
                        {
                            cmd.Parameters.AddWithValue("@value1", UId);
                            cmd.Parameters.AddWithValue("@value2", Pass);
                            n = (int)cmd.ExecuteScalar();
                        }
                    }
                    if (n > 0)
                    {
                        MessageBox.Show("Login Sucessful!!");
                        this.Hide();
                        TeacherDashBoard New = new TeacherDashBoard();
                        New.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sorry We can't log you in!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
        internal class admin : AdminDashBoard { }
    }
}
